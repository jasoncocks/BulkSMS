using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulkSMS;
using System.Configuration;

namespace BULKSMSGUI
{
    public partial class Form1 : Form
    {
        private readonly string sAPIBaseURL;
        private readonly string sAPITokenId;
        private readonly string sSecret;
        private readonly BulkSMS_API api;

        private void UpdateCredits()
        {
            Profile p = api.ReadProfile();

            BulkSMS_UserName_TextBox.Text = p.username;
            BulkSMS_Credit_TextBox.Text = p.credits.balance.ToString("N2");
        }
        public Form1()
        {
            InitializeComponent();

            sAPIBaseURL = ConfigurationManager.AppSettings["BulkSmsBaseUrl"];
            sAPITokenId = ConfigurationManager.AppSettings["BulkSmsApiToken"];
            sSecret = ConfigurationManager.AppSettings["BulkSmsSecret"];

            api = new BulkSMS_API(sAPIBaseURL, sAPITokenId, sSecret);

            UpdateCredits();
        }

        private void BulkSMS_MessagesToSend_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            BulkSMS_Send_Button.Enabled = false;
            if (dgv.Rows.Count > 0)
            {
                BulkSMS_Send_Button.Enabled = true;
            }
        }

        private void BulkSMS_MessagesToSend_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            BulkSMS_Send_Button.Enabled = false;
            if (dgv.Rows.Count > 0)
            {
                BulkSMS_Send_Button.Enabled = true;
            }
        }

        private void BulkSMS_Send(object sender, EventArgs e)
        {
            if (BulkSMS_MessagesToSend.Rows.Count == 0)
            {
                MessageBox.Show("No messages.");
                return;
            }

            List<BulkSMS.Message> MessagesToSend = new List<BulkSMS.Message>();
            foreach (DataGridViewRow dr in BulkSMS_MessagesToSend.Rows)
            {
                if (!String.IsNullOrEmpty((string)dr.Cells["TelephoneNumber"].Value))
                {
                    MessagesToSend.Add(
                        new BulkSMS.Message
                        {
                            to = (string)dr.Cells["TelephoneNumber"].Value,
                            body = (string)dr.Cells["Message"].Value
                        }
                    );
                }
            }

            try
            {
                int i = 0;
                i++;
                api.Send(MessagesToSend);
                UpdateCredits();
            }
            catch (BulkSMSException bx)
            {
                MessageBox.Show(
                    bx.Message +
                    Environment.NewLine +
                    Environment.NewLine +
                    bx.BulkSmsError.title);
            }
        }

        private void RefreshPreviousMessages()
        {
            foreach (BulkSMS.MessageDetail qm in api.QueryMessages())
            {

            }
        }
    }
}
