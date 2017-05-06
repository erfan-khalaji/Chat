using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;// For Marshalling
using System.Threading;

namespace Chat_DDM
{
  public partial class Form1 : Form
  {
    public CSimulationManager simulation;
    public RichTextBox ChatScreen;
    //delegate void SetTextCallback();

    // Constructor
    public Form1()
    {
      InitializeComponent();
      ChatScreen = new RichTextBox();
      simulation = new CSimulationManager(this);
      dataGridView1.DataSource = this.simulation.Users;
      
      // Getting the information/debugging messages
      this.simulation.federate.StatusMessageChanged += new EventHandler(CChatFd_StatusMessageChanged);
      this.simulation.federate.LogLevel = Racon.LogLevel.ALL;
    }

    // Racon Information recevied
    void CChatFd_StatusMessageChanged(object sender, EventArgs e)
    {
      this.TB_RaconMsg.AppendText(this.simulation.federate.StatusMessage + Environment.NewLine);
    }
    // Initialize Federation
    private void Button_enter_Click(object sender, EventArgs e)
    {
      NickNameDialog _nDlg = new NickNameDialog();
      _nDlg.ShowDialog();
      if (_nDlg.DialogResult == DialogResult.OK)
      {
        simulation.federate.NickName = _nDlg.NickName;
        simulation.federation.FederateName = simulation.federate.NickName;
        this.simulation.Users[0].NickName = simulation.federate.NickName;
        this.simulation.Users[0].Status = StatusTypes.INCHAT;
        //this.simulation.Users[0].ObjectInstanceName = _nDlg.UserOC.NickName; // RTI performance penalty due to the name reservation

        // Initialize Federation
        bool result = this.simulation.federate.InitializeFederation(simulation.federation);
        if (result)
        {
          // GUI Setup for chat
          this.button_exit.Enabled = true;
          this.button_send.Enabled = true;
          this.Button_enter.Enabled = false;
          this.AcceptButton = this.button_send;
          this.textBox_send.Focus();
          // InitializeFederation subscribes to ChatIC by default. So, we unsubscribe it
          this.simulation.federate.UnsubscribeInteractionClass(this.simulation.federate.Som.ChatIC);


          //****************
          // Subscribe with a region, first construct a attributes list
          List<Racon.RtiLayer.HlaAttribute > Attributes = new List<Racon.RtiLayer.HlaAttribute>();
          Attributes.Add(this.simulation.federate.Som.UserOC.NickName);
          this.simulation.federate.subscribeObjectClassAttributesWithRegion(this.simulation.federate.Som.UserOC,  Attributes, this.simulation.federate.Som.ChatWorldSpace.Room1Region);

          //object
          CUser ok = new CUser(this.simulation.federate.Som.UserOC);

          //****************
          // First register, then associate region for updates
          this.simulation.federate.RegisterHlaObject(ok);
          this.simulation.federate.AssociateRegionForUpdates(this.simulation.federate.Som.ChatWorldSpace.Room1Region, ok, Attributes);

          //****************
          // All publishable attributes
          this.simulation.federate.RegisterHlaObject(ok, this.simulation.federate.Som.ChatWorldSpace.Room1Region);
          // Selected Attributes
          this.simulation.federate.RegisterHlaObject(ok, Attributes, this.simulation.federate.Som.ChatWorldSpace.Room1Region);
        }
      }
    }

    // Exit Federation
    private void button_exit_Click(object sender, EventArgs e)
    {
      // Leave federation
      //bool result = this.simulation.federate.FinalizeFederation(this.simulation.federation, Racon.Federation.ResignAction.DELETE_OBJECTS_THEN_DIVEST);
      bool result = this.simulation.federate.FinalizeFederation(this.simulation.federation);
      // Reset Local data
      this.simulation.Users[0].Status = StatusTypes.READY;
      // GUI Setup for enter
      this.button_exit.Enabled = false;
      this.button_send.Enabled = false;
      this.textBox_send.Enabled = false;
      this.Button_enter.Enabled = true;
      this.AcceptButton = this.Button_enter;
    }

    // Send message
    private void button_send_Click(object sender, EventArgs e)
    {
      String message = this.textBox_send.Text;
      Boolean res = false;
      // Send Chat Interaction
      if (this.ChatScreen == this.OzelOda1_Ekran)
        res = this.simulation.federate.SendMessage(message, this.simulation.federate.Som.ChatWorldSpace.Room1Region);
      else if (this.ChatScreen == this.OzelOda2)
        res = this.simulation.federate.SendMessage(message, this.simulation.federate.Som.ChatWorldSpace.Room2Region);
      else
        res = this.simulation.federate.SendMessage(message, this.simulation.federate.Som.ChatWorldSpace.Oda0Region); 
      if (res)
      {
        this.ChatScreen.ForeColor = Color.Blue;
        this.ChatScreen.AppendText(simulation.federate.NickName + "> " + message + Environment.NewLine);
        this.textBox_send.Clear();
      }
    }
    // DoSimulation
    public void DoSimulation()
    {
      if (this.simulation.federate.FederateState == Racon.FederateStates.JOINED)
      {
        this.simulation.federate.Run();
      }
    }

    private void BT_Copy_Click(object sender, EventArgs e)
    {
      this.TB_RaconMsg.SelectAll();
      this.TB_RaconMsg.Copy();
    }

    private void BT_Clear_Click(object sender, EventArgs e)
    {
      this.TB_RaconMsg.Clear();
    }

    private void JoinRoom1_Click(object sender, EventArgs e)
    {
      this.ChatScreen = OzelOda1_Ekran;
      // Resubscribe
      this.simulation.federate.Subscribe(this.simulation.federate.Som.ChatIC, this.simulation.federate.Som.ChatWorldSpace.Room1Region);

      this.textBox_send.Enabled = true;
      this.BT_Room1_Join.Enabled = false;
      this.BT_Room1_Leave.Enabled = true;
    }

    private void LeaveRoom1_Click(object sender, EventArgs e)
    {
      // Unsubscribe
       this.simulation.federate.UnsubscribeInteractionClass(this.simulation.federate.Som.ChatIC, this.simulation.federate.Som.ChatWorldSpace.Room1Region);
      this.BT_Room1_Join.Enabled = true;
      this.BT_Room1_Leave.Enabled = false;
      if (this.BT_Room1_Join.Enabled && this.BT_Room2_Join.Enabled) this.textBox_send.Enabled = false;
    }

    private void JoinRoom2_Click(object sender, EventArgs e)
    {
        this.ChatScreen = OzelOda2;
        // Resubscribe
        this.simulation.federate.Subscribe(this.simulation.federate.Som.ChatIC, this.simulation.federate.Som.ChatWorldSpace.Room2Region);
        this.textBox_send.Enabled = true;
        this.BT_Room2_Join.Enabled = false;
        this.BT_Room2_Leave.Enabled = true;

    }

    private void LeaveRoom2_Click(object sender, EventArgs e)
    {
        // Unsubscribe
        this.simulation.federate.UnsubscribeInteractionClass(this.simulation.federate.Som.ChatIC, this.simulation.federate.Som.ChatWorldSpace.Room2Region);
        this.BT_Room2_Join.Enabled = true;
        this.BT_Room2_Leave.Enabled = false;
        if (this.BT_Room1_Join.Enabled && this.BT_Room2_Join.Enabled) this.textBox_send.Enabled = false;
    }

  }
}
