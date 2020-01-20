using System;
using System.Collections.Generic;
using BulkSMS;
using System.Configuration;

namespace BulkSMSCMD
{
    class MainClass
    {
        // App.config variables - or .... Job Description config...
        static readonly string sAPIBaseURL = ConfigurationManager.AppSettings["BulkSmsBaseUrl"];
        static readonly string sAPITokenId = ConfigurationManager.AppSettings["BulkSmsApiToken"];
        static readonly string sSecret = ConfigurationManager.AppSettings["BulkSmsSecret"];

        private static void SendMessages()
        {
            BulkSMS_API api = new BulkSMS_API(sAPIBaseURL, sAPITokenId, sSecret);

            List<Message> messages = new List<Message>
            {
                new Message { to = "+440123456789", body = "Just testing 1" },
                new Message { to = "+440123456789", body = "Just testing 2" }
            };

            api.Send(messages);
        }

        public static void Main()
        {
            try
            {
                BulkSMS_API api = new BulkSMS_API(sAPIBaseURL, sAPITokenId, sSecret);

                Console.WriteLine("==[ ReadProfile() ]==========================================================");
                Profile p = api.ReadProfile();
                Console.WriteLine("First Name: " + p.firstName);

                Console.WriteLine("==[ QueryMessages(...) ]=====================================================");
                var qm = api.QueryMessages();
                if (qm != null)
                {
                    foreach (MessageDetail qm_md in qm)
                    {
                        Console.WriteLine(qm_md.id);
                    }
                }

                Console.WriteLine("==[ BlockedNumbers(...) ]====================================================");
                var bns = api.BlockedNumbers();
                if (bns != null)
                {
                    foreach (BlockedNumber bn in bns)
                    {
                        Console.WriteLine("Blocked Number: " + bn.phoneNumber);
                    }
                }

                Console.WriteLine("==[ GetMessage(...) ]========================================================");
                MessageDetail md = api.GetMessage("799777944003158017");
                Console.WriteLine("GetMessage: " + md.id);

                Console.WriteLine("==[ GetRelatedMessages(...) ]================================================");
                var rm = api.GetRelatedMessages("799777944003158017");
                if (rm != null)
                {
                    foreach (MessageDetail rm_md in rm)
                    {
                        Console.WriteLine(rm_md.id);
                    }
                }

                SendMessages();
            }
            catch (BulkSMSException bx)
            {
                Console.WriteLine("BulkSms error occurred.");

                Console.WriteLine(bx.Message);
                Console.WriteLine(bx.BulkSmsError.title);
                Console.WriteLine(bx.BulkSmsError.status);
                Console.WriteLine(bx.BulkSmsError.type);
                Console.WriteLine(bx.BulkSmsError.detail);

            }

            Console.Write("Press <ENTER>.");
            Console.ReadLine();
        }
    }
}