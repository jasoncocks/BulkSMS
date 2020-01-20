namespace BULKSMSGUI
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
            this.BulkSMS_UserName_Label = new System.Windows.Forms.Label();
            this.BulkSMS_UserName_TextBox = new System.Windows.Forms.TextBox();
            this.BulkSMS_Credit_TextBox = new System.Windows.Forms.TextBox();
            this.BulkSMS_Credit_Label = new System.Windows.Forms.Label();
            this.BulkSMS_MessagesToSend = new System.Windows.Forms.DataGridView();
            this.TelephoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BulkSMS_Send_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BulkSMS_PreviousMessages_DataGridView = new System.Windows.Forms.DataGridView();
            this.BulkSMS_PreviousMessage_Refresh = new System.Windows.Forms.Button();
            this.MsgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgRecipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BulkSMS_MessagesToSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkSMS_PreviousMessages_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BulkSMS_UserName_Label
            // 
            this.BulkSMS_UserName_Label.AutoSize = true;
            this.BulkSMS_UserName_Label.Location = new System.Drawing.Point(13, 12);
            this.BulkSMS_UserName_Label.Name = "BulkSMS_UserName_Label";
            this.BulkSMS_UserName_Label.Size = new System.Drawing.Size(55, 13);
            this.BulkSMS_UserName_Label.TabIndex = 0;
            this.BulkSMS_UserName_Label.Text = "Username";
            // 
            // BulkSMS_UserName_TextBox
            // 
            this.BulkSMS_UserName_TextBox.Enabled = false;
            this.BulkSMS_UserName_TextBox.Location = new System.Drawing.Point(74, 9);
            this.BulkSMS_UserName_TextBox.Name = "BulkSMS_UserName_TextBox";
            this.BulkSMS_UserName_TextBox.Size = new System.Drawing.Size(232, 20);
            this.BulkSMS_UserName_TextBox.TabIndex = 1;
            // 
            // BulkSMS_Credit_TextBox
            // 
            this.BulkSMS_Credit_TextBox.Enabled = false;
            this.BulkSMS_Credit_TextBox.Location = new System.Drawing.Point(408, 9);
            this.BulkSMS_Credit_TextBox.Name = "BulkSMS_Credit_TextBox";
            this.BulkSMS_Credit_TextBox.Size = new System.Drawing.Size(232, 20);
            this.BulkSMS_Credit_TextBox.TabIndex = 3;
            // 
            // BulkSMS_Credit_Label
            // 
            this.BulkSMS_Credit_Label.AutoSize = true;
            this.BulkSMS_Credit_Label.Enabled = false;
            this.BulkSMS_Credit_Label.Location = new System.Drawing.Point(347, 12);
            this.BulkSMS_Credit_Label.Name = "BulkSMS_Credit_Label";
            this.BulkSMS_Credit_Label.Size = new System.Drawing.Size(39, 13);
            this.BulkSMS_Credit_Label.TabIndex = 2;
            this.BulkSMS_Credit_Label.Text = "Credits";
            // 
            // BulkSMS_MessagesToSend
            // 
            this.BulkSMS_MessagesToSend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BulkSMS_MessagesToSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TelephoneNumber,
            this.Message});
            this.BulkSMS_MessagesToSend.Location = new System.Drawing.Point(16, 60);
            this.BulkSMS_MessagesToSend.Name = "BulkSMS_MessagesToSend";
            this.BulkSMS_MessagesToSend.Size = new System.Drawing.Size(760, 150);
            this.BulkSMS_MessagesToSend.TabIndex = 4;
            this.BulkSMS_MessagesToSend.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.BulkSMS_MessagesToSend_RowsAdded);
            this.BulkSMS_MessagesToSend.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.BulkSMS_MessagesToSend_RowsRemoved);
            // 
            // TelephoneNumber
            // 
            this.TelephoneNumber.HeaderText = "Telephone No";
            this.TelephoneNumber.Name = "TelephoneNumber";
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            // 
            // BulkSMS_Send_Button
            // 
            this.BulkSMS_Send_Button.Enabled = false;
            this.BulkSMS_Send_Button.Location = new System.Drawing.Point(16, 216);
            this.BulkSMS_Send_Button.Name = "BulkSMS_Send_Button";
            this.BulkSMS_Send_Button.Size = new System.Drawing.Size(760, 64);
            this.BulkSMS_Send_Button.TabIndex = 5;
            this.BulkSMS_Send_Button.Text = "Send";
            this.BulkSMS_Send_Button.UseVisualStyleBackColor = true;
            this.BulkSMS_Send_Button.Click += new System.EventHandler(this.BulkSMS_Send);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Previous Messages";
            // 
            // BulkSMS_PreviousMessages_DataGridView
            // 
            this.BulkSMS_PreviousMessages_DataGridView.AllowUserToAddRows = false;
            this.BulkSMS_PreviousMessages_DataGridView.AllowUserToDeleteRows = false;
            this.BulkSMS_PreviousMessages_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BulkSMS_PreviousMessages_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MsgDate,
            this.MsgRecipient,
            this.SenderID,
            this.Status,
            this.MessageText});
            this.BulkSMS_PreviousMessages_DataGridView.Location = new System.Drawing.Point(16, 326);
            this.BulkSMS_PreviousMessages_DataGridView.Name = "BulkSMS_PreviousMessages_DataGridView";
            this.BulkSMS_PreviousMessages_DataGridView.ReadOnly = true;
            this.BulkSMS_PreviousMessages_DataGridView.Size = new System.Drawing.Size(760, 196);
            this.BulkSMS_PreviousMessages_DataGridView.TabIndex = 7;
            // 
            // BulkSMS_PreviousMessage_Refresh
            // 
            this.BulkSMS_PreviousMessage_Refresh.Location = new System.Drawing.Point(16, 529);
            this.BulkSMS_PreviousMessage_Refresh.Name = "BulkSMS_PreviousMessage_Refresh";
            this.BulkSMS_PreviousMessage_Refresh.Size = new System.Drawing.Size(760, 44);
            this.BulkSMS_PreviousMessage_Refresh.TabIndex = 8;
            this.BulkSMS_PreviousMessage_Refresh.Text = "Refresh";
            this.BulkSMS_PreviousMessage_Refresh.UseVisualStyleBackColor = true;
            // 
            // MsgDate
            // 
            this.MsgDate.HeaderText = "Date";
            this.MsgDate.Name = "MsgDate";
            this.MsgDate.ReadOnly = true;
            // 
            // MsgRecipient
            // 
            this.MsgRecipient.HeaderText = "Recipient";
            this.MsgRecipient.Name = "MsgRecipient";
            this.MsgRecipient.ReadOnly = true;
            // 
            // SenderID
            // 
            this.SenderID.HeaderText = "Sender ID";
            this.SenderID.Name = "SenderID";
            this.SenderID.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // MessageText
            // 
            this.MessageText.HeaderText = "Message";
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 571);
            this.Controls.Add(this.BulkSMS_PreviousMessage_Refresh);
            this.Controls.Add(this.BulkSMS_PreviousMessages_DataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BulkSMS_Send_Button);
            this.Controls.Add(this.BulkSMS_MessagesToSend);
            this.Controls.Add(this.BulkSMS_Credit_TextBox);
            this.Controls.Add(this.BulkSMS_Credit_Label);
            this.Controls.Add(this.BulkSMS_UserName_TextBox);
            this.Controls.Add(this.BulkSMS_UserName_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BulkSMS_MessagesToSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkSMS_PreviousMessages_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BulkSMS_UserName_Label;
        private System.Windows.Forms.TextBox BulkSMS_UserName_TextBox;
        private System.Windows.Forms.TextBox BulkSMS_Credit_TextBox;
        private System.Windows.Forms.Label BulkSMS_Credit_Label;
        private System.Windows.Forms.DataGridView BulkSMS_MessagesToSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.Button BulkSMS_Send_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BulkSMS_PreviousMessages_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgRecipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageText;
        private System.Windows.Forms.Button BulkSMS_PreviousMessage_Refresh;
    }
}

