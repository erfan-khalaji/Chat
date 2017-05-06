namespace Chat_DDM
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.Button_enter = new System.Windows.Forms.Button();
      this.button_exit = new System.Windows.Forms.Button();
      this.textBox_send = new System.Windows.Forms.TextBox();
      this.TB_RaconMsg = new System.Windows.Forms.TextBox();
      this.button_send = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.BT_Clear = new System.Windows.Forms.Button();
      this.BT_Copy = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.OzelOda1_Ekran = new System.Windows.Forms.RichTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.BT_Room1_Join = new System.Windows.Forms.Button();
      this.BT_Room1_Leave = new System.Windows.Forms.Button();
      this.OzelOda2 = new System.Windows.Forms.RichTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.BT_Room2_Join = new System.Windows.Forms.Button();
      this.BT_Room2_Leave = new System.Windows.Forms.Button();
      this.cUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUserBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // Button_enter
      // 
      this.Button_enter.Location = new System.Drawing.Point(864, 335);
      this.Button_enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Button_enter.Name = "Button_enter";
      this.Button_enter.Size = new System.Drawing.Size(272, 57);
      this.Button_enter.TabIndex = 0;
      this.Button_enter.Text = "Enter";
      this.Button_enter.UseVisualStyleBackColor = true;
      this.Button_enter.Click += new System.EventHandler(this.Button_enter_Click);
      // 
      // button_exit
      // 
      this.button_exit.Enabled = false;
      this.button_exit.Location = new System.Drawing.Point(864, 398);
      this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button_exit.Name = "button_exit";
      this.button_exit.Size = new System.Drawing.Size(272, 66);
      this.button_exit.TabIndex = 1;
      this.button_exit.Text = "Exit chat";
      this.button_exit.UseVisualStyleBackColor = true;
      this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
      // 
      // textBox_send
      // 
      this.textBox_send.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox_send.Enabled = false;
      this.textBox_send.Location = new System.Drawing.Point(463, 505);
      this.textBox_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox_send.Name = "textBox_send";
      this.textBox_send.Size = new System.Drawing.Size(395, 22);
      this.textBox_send.TabIndex = 1;
      // 
      // TB_RaconMsg
      // 
      this.TB_RaconMsg.BackColor = System.Drawing.SystemColors.HighlightText;
      this.TB_RaconMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TB_RaconMsg.Location = new System.Drawing.Point(12, 28);
      this.TB_RaconMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TB_RaconMsg.Multiline = true;
      this.TB_RaconMsg.Name = "TB_RaconMsg";
      this.TB_RaconMsg.ReadOnly = true;
      this.TB_RaconMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.TB_RaconMsg.Size = new System.Drawing.Size(417, 445);
      this.TB_RaconMsg.TabIndex = 1;
      // 
      // button_send
      // 
      this.button_send.Enabled = false;
      this.button_send.Location = new System.Drawing.Point(864, 470);
      this.button_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button_send.Name = "button_send";
      this.button_send.Size = new System.Drawing.Size(272, 66);
      this.button_send.TabIndex = 2;
      this.button_send.Text = "Send";
      this.button_send.UseVisualStyleBackColor = true;
      this.button_send.Click += new System.EventHandler(this.button_send_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(895, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "Users";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(864, 28);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(272, 224);
      this.dataGridView1.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 7);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(136, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Racon Messages";
      // 
      // BT_Clear
      // 
      this.BT_Clear.Location = new System.Drawing.Point(211, 479);
      this.BT_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BT_Clear.Name = "BT_Clear";
      this.BT_Clear.Size = new System.Drawing.Size(197, 57);
      this.BT_Clear.TabIndex = 0;
      this.BT_Clear.Text = "Clear";
      this.BT_Clear.UseVisualStyleBackColor = true;
      this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
      // 
      // BT_Copy
      // 
      this.BT_Copy.Location = new System.Drawing.Point(12, 479);
      this.BT_Copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BT_Copy.Name = "BT_Copy";
      this.BT_Copy.Size = new System.Drawing.Size(197, 57);
      this.BT_Copy.TabIndex = 0;
      this.BT_Copy.Text = "Copy";
      this.BT_Copy.UseVisualStyleBackColor = true;
      this.BT_Copy.Click += new System.EventHandler(this.BT_Copy_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Chat_DDM.Properties.Resources.Racon;
      this.pictureBox1.Location = new System.Drawing.Point(915, 258);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(161, 70);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // OzelOda1_Ekran
      // 
      this.OzelOda1_Ekran.Location = new System.Drawing.Point(449, 28);
      this.OzelOda1_Ekran.Margin = new System.Windows.Forms.Padding(4);
      this.OzelOda1_Ekran.Name = "OzelOda1_Ekran";
      this.OzelOda1_Ekran.ReadOnly = true;
      this.OzelOda1_Ekran.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
      this.OzelOda1_Ekran.Size = new System.Drawing.Size(199, 364);
      this.OzelOda1_Ekran.TabIndex = 7;
      this.OzelOda1_Ekran.Text = "";
      this.OzelOda1_Ekran.UseWaitCursor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(446, 7);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(105, 17);
      this.label4.TabIndex = 8;
      this.label4.Text = "Private Room 1";
      // 
      // BT_Room1_Join
      // 
      this.BT_Room1_Join.Location = new System.Drawing.Point(479, 399);
      this.BT_Room1_Join.Margin = new System.Windows.Forms.Padding(4);
      this.BT_Room1_Join.Name = "BT_Room1_Join";
      this.BT_Room1_Join.Size = new System.Drawing.Size(123, 28);
      this.BT_Room1_Join.TabIndex = 12;
      this.BT_Room1_Join.Text = "Join";
      this.BT_Room1_Join.UseVisualStyleBackColor = true;
      this.BT_Room1_Join.Click += new System.EventHandler(this.JoinRoom1_Click);
      // 
      // BT_Room1_Leave
      // 
      this.BT_Room1_Leave.Enabled = false;
      this.BT_Room1_Leave.Location = new System.Drawing.Point(479, 434);
      this.BT_Room1_Leave.Margin = new System.Windows.Forms.Padding(4);
      this.BT_Room1_Leave.Name = "BT_Room1_Leave";
      this.BT_Room1_Leave.Size = new System.Drawing.Size(123, 30);
      this.BT_Room1_Leave.TabIndex = 13;
      this.BT_Room1_Leave.Text = "Leave";
      this.BT_Room1_Leave.UseVisualStyleBackColor = true;
      this.BT_Room1_Leave.Click += new System.EventHandler(this.LeaveRoom1_Click);
      // 
      // OzelOda2
      // 
      this.OzelOda2.Location = new System.Drawing.Point(656, 28);
      this.OzelOda2.Margin = new System.Windows.Forms.Padding(4);
      this.OzelOda2.Name = "OzelOda2";
      this.OzelOda2.ReadOnly = true;
      this.OzelOda2.Size = new System.Drawing.Size(201, 362);
      this.OzelOda2.TabIndex = 14;
      this.OzelOda2.Text = "";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(662, 7);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(105, 17);
      this.label5.TabIndex = 15;
      this.label5.Text = "Private Room 2";
      // 
      // BT_Room2_Join
      // 
      this.BT_Room2_Join.Location = new System.Drawing.Point(700, 398);
      this.BT_Room2_Join.Margin = new System.Windows.Forms.Padding(4);
      this.BT_Room2_Join.Name = "BT_Room2_Join";
      this.BT_Room2_Join.Size = new System.Drawing.Size(112, 28);
      this.BT_Room2_Join.TabIndex = 16;
      this.BT_Room2_Join.Text = "Join";
      this.BT_Room2_Join.UseVisualStyleBackColor = true;
      this.BT_Room2_Join.Click += new System.EventHandler(this.JoinRoom2_Click);
      // 
      // BT_Room2_Leave
      // 
      this.BT_Room2_Leave.Enabled = false;
      this.BT_Room2_Leave.Location = new System.Drawing.Point(700, 434);
      this.BT_Room2_Leave.Margin = new System.Windows.Forms.Padding(4);
      this.BT_Room2_Leave.Name = "BT_Room2_Leave";
      this.BT_Room2_Leave.Size = new System.Drawing.Size(112, 28);
      this.BT_Room2_Leave.TabIndex = 17;
      this.BT_Room2_Leave.Text = "Leave";
      this.BT_Room2_Leave.UseVisualStyleBackColor = true;
      this.BT_Room2_Leave.Click += new System.EventHandler(this.LeaveRoom2_Click);
      // 
      // cUserBindingSource
      // 
      this.cUserBindingSource.DataSource = typeof(Chat_DDM.CUser);
      // 
      // Form1
      // 
      this.AcceptButton = this.Button_enter;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1148, 548);
      this.Controls.Add(this.BT_Room2_Leave);
      this.Controls.Add(this.BT_Room2_Join);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.OzelOda2);
      this.Controls.Add(this.BT_Room1_Leave);
      this.Controls.Add(this.BT_Room1_Join);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.OzelOda1_Ekran);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TB_RaconMsg);
      this.Controls.Add(this.textBox_send);
      this.Controls.Add(this.button_send);
      this.Controls.Add(this.button_exit);
      this.Controls.Add(this.BT_Copy);
      this.Controls.Add(this.BT_Clear);
      this.Controls.Add(this.Button_enter);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "Extended Chat Federate Application 0.1.2";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cUserBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Button_enter;
    private System.Windows.Forms.Button button_exit;
    private System.Windows.Forms.TextBox textBox_send;
    private System.Windows.Forms.Button button_send;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource cUserBindingSource;
    private System.Windows.Forms.DataGridView dataGridView1;
    public System.Windows.Forms.TextBox TB_RaconMsg;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BT_Clear;
    private System.Windows.Forms.Button BT_Copy;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.RichTextBox OzelOda1_Ekran;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button BT_Room1_Join;
    private System.Windows.Forms.Button BT_Room1_Leave;
    private System.Windows.Forms.RichTextBox OzelOda2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button BT_Room2_Join;
    private System.Windows.Forms.Button BT_Room2_Leave;
  }
}

