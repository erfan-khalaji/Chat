// ***************************************************************************
//		CChatFd
//		copyright	: 	(C) Okan Topcu
//		email			: 	okantopcu@gmail.com
// ***************************************************************************
/// <summary>
/// The application specific federate that is extended from the Generic Federate Class of Racon API
/// </summary>

#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Racon;
using Racon.RtiLayer;
using Chat_DDM.Som;

#endregion //Using Directives
namespace Chat_DDM
{
  public partial class CChatFd : Racon.Federation.CGenericFederate
  {
    #region Manually Added Code
    private Object thisLock = new Object();
    // Local Data
    private CSimulationManager simManager;
    private String _systemMessage;
    public String NickName;
    #region Properties
    public String ViewText
    {
      get { return _systemMessage; }
      set
      {
        _systemMessage = value;
        this.simManager.view.ChatScreen.AppendText(_systemMessage); // Bad Coding
      }
    }
    #endregion // Properties
    public CChatFd(CSimulationManager parent)
      : this()
    {
      // Set simulation manager
      simManager = parent;
    }
    // Send Chat ChatIC.Message
    public bool SendMessage(String txt)
    {
      Racon.RtiLayer.HlaInteraction interaction = new Racon.RtiLayer.HlaInteraction(this.Som.ChatIC, "Chat");
      // Add Values
      interaction.AddParameterValue(this.Som.ChatIC.Sender, this.NickName);
      interaction.AddParameterValue(this.Som.ChatIC.Message, txt);
      interaction.AddParameterValue(this.Som.ChatIC.TimeStamp, DateTime.Now);
      // Enums
      //interaction.AddParameterValue(this.ChatIC.TimeStamp, (uint)StatusTypes.READY);
      // Send interaction
      return (this.SendInteraction(interaction));
    }
    public bool SendMessage(String txt, CHlaRegion region)
    {
      Racon.RtiLayer.HlaInteraction interaction = new Racon.RtiLayer.HlaInteraction(this.Som.ChatIC, "Chat");
      // Add Values
      interaction.AddParameterValue(this.Som.ChatIC.Sender, this.NickName);
      interaction.AddParameterValue(this.Som.ChatIC.Message, txt);
      interaction.AddParameterValue(this.Som.ChatIC.TimeStamp, DateTime.Now);
      // Send interaction
      return (this.SendInteraction(interaction, region));
    }    
    // UpdateName
    public bool UpdateName(CUser user)
    {
      // Add Values
      user.AddAttributeValue(Som.UserOC.NickName, user.NickName);
      // Update attribute
      return (this.UpdateAttributeValues(user));
    }
    // UpdateStatus
    public bool UpdateStatus(CUser user)
    {
      user.AddAttributeValue(Som.UserOC.Status, (uint)user.Status);
      return (this.UpdateAttributeValues(user));
    }
    // Subscribe
    public void Subscribe(CChatIC ic, Racon.RtiLayer.CHlaRegion region)
    {
      this.SubscribeInteractionClass(ic, region);
    }
    // RtiAmb Events
    public override void RtiAmb_FederationExecutionCreated(object sender, Racon.RtiLayer.RaconEventArgs e)
    {
      // Always call the base class handler first
      base.RtiAmb_FederationExecutionCreated(sender, e);
      // Specialize the event handler, if needed.
    }

    // Cut and paste the callbacks that you want to modify from the Generated ChatFd file (ChatFd_Generated.cs)
    #region Event Handlers
    #region Federate Callback Event Handlers
    #region Declaration Management Callbacks
    // Start Registration
    public override void FdAmb_StartRegistrationForObjectClassAdvisedHandler(object sender, Racon.RtiLayer.HlaDeclarationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_StartRegistrationForObjectClassAdvisedHandler(sender, data);

      // User code
      // Check that this is for the USerOC
      if (data.ObjectClassHandle == this.Som.UserOC.Handle)
        this.RegisterHlaObject(this.simManager.Users[0]);
    }
    // Turn Interactions On
    public override void FdAmb_TurnInteractionsOnAdvisedHandler(object sender, Racon.RtiLayer.HlaDeclarationManagementEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_TurnInteractionsOnAdvisedHandler(sender, data);

      // User code
    }
    #endregion //Declaration Management Callbacks
    #region Object Management Callbacks
    // An Object is Discovered
    public override void FdAmb_ObjectDiscoveredHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ObjectDiscoveredHandler(sender, data);

      // User code
      // Check the class type of the discovered object
      if (data.ClassHandle == this.Som.UserOC.Handle)
      //if (fe.Handle == this.UserOC.Handle)
      {
        // Create and add a new user to the list
        CUser nUser = new CUser(this.Som.UserOC, data);

        this.simManager.Users.Add(nUser);
        // Request update for this object
        this.RequestAttributeUpdate(this.Som.UserOC);
      }
    }
    // An Object is Removed
    public override void FdAmb_ObjectRemovedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ObjectRemovedHandler(sender, data);

      // User code
      // Lock while taking a snapshot - to avoid foreach loop enumeration exception
      object[] snap;
      lock (this.thisLock)
      {
        snap = this.simManager.Users.ToArray();
      }
      foreach (CUser user in snap)
      {
        if (data.ObjectInstance.Handle == user.Handle)// Find the Object
        {
          this.simManager.Users.Remove(user);
          this.ViewText = "User: " + user.NickName + " left. Number of Users Left: " + this.simManager.Users.Count + Environment.NewLine;
        }
      }
    }
    // Attribute Value Update is Requested
    public override void FdAmb_AttributeValueUpdateRequestedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_AttributeValueUpdateRequestedHandler(sender, data);

      // User code
      // !!! If it is created only one object, then it is sufficient to check the handle of that object, otherwise we need to check all the collection
      // Find the object class for which the request is made
      //foreach (CUser user in this.simManager.Users)
      //{
      if (data.ObjectInstance.Handle == this.simManager.Users[0].Handle)
      {
        // We can further try to figure out the attributes for which update is requested.
        // First check the  update is requested for the attribute, if true provide an update for that specific attribute
        this.UpdateName(this.simManager.Users[0]);
       this.UpdateStatus(this.simManager.Users[0]);
        // We can update all attributes if we dont want to check every attribute.
        //this.UpdateName(this.simManager.Users[0]);
        //this.UpdateStatus(this.simManager.Users[0]);
      }
    }
    // Reflect Object Attributes
    public override void FdAmb_ObjectAttributesReflectedHandler(object sender, Racon.RtiLayer.HlaObjectEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_ObjectAttributesReflectedHandler(sender, data);

      // User code
      foreach (CUser user in this.simManager.Users)
      {
        // Find the Object
        if (data.ObjectHandle == user.ObjectHandle)
        {
          // First check wheather the attr is updated or not. Result returns 0/null if the updated attribute set does not contain the attr and its value 
          if (data.IsValueUpdated(Som.UserOC.NickName))
            user.NickName = data.GetAttributeValue<String>(this.Som.UserOC.NickName);
          if (data.IsValueUpdated(Som.UserOC.Status))
            user.Status = (StatusTypes)data.GetAttributeValue<uint>(this.Som.UserOC.Status);
        }
      }
    }
    // Interaction Received
    public override void FdAmb_InteractionReceivedHandler(object sender, Racon.RtiLayer.HlaInteractionEventArgs data)
    {
      // Call the base class handler
      base.FdAmb_InteractionReceivedHandler(sender, data);

      // User code
      // Which interaction class?
      if (data.InteractionClassHandle == this.Som.ChatIC.Handle)
      {
        String sentBy = "";
        String msg = "";
        DateTime ts = new DateTime();
        /// First check wheather the param is updated or not. Result returns 0/null if the updated param set does not contain the param and its value
        if (data.IsValueUpdated(this.Som.ChatIC.Sender)) sentBy = data.GetParameterValue<String>(this.Som.ChatIC.Sender);
        if (data.IsValueUpdated(this.Som.ChatIC.Message)) msg = data.GetParameterValue<String>(this.Som.ChatIC.Message);
        if (data.IsValueUpdated(this.Som.ChatIC.TimeStamp)) ts = data.GetParameterValue<DateTime>(this.Som.ChatIC.TimeStamp);

        this.ViewText = sentBy + "> " + msg + " (" + ts.TimeOfDay + ")" + Environment.NewLine;
      }
    }
    #endregion //Object Management Callbacks
    #endregion //Federate Callback Event Handlers
    #endregion //Event Handlers

    #endregion //Manually Added Code


  }
}
