using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Web;
using System.Text;

namespace BulkSMS
{
    public class BulkSMS_API
    {
        private readonly string sAPIBaseURL;
        private readonly string sAPITokenId;
        private readonly string sSecret;
        private readonly string svcCredentials;
        private readonly UnicodeEncoding encoding;
        private readonly JsonSerializerSettings jss;

        public BulkSMS_API(string sBulkSmsBaseUrl, string sBulkSmsAPITokenId, string sBulkSmsSecret)
        {
            sAPIBaseURL = sBulkSmsBaseUrl;
            sAPITokenId = sBulkSmsAPITokenId;
            sSecret = sBulkSmsSecret;

            svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(sAPITokenId + ":" + sSecret));
            encoding = new UnicodeEncoding();

            jss = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
        }

        private WebRequest GetWebRequest(string sURL, string sRequestMethod, string sJSONData = "")
        {
            WebRequest request = WebRequest.Create(sURL);
            request.Headers.Add("Authorization", "Basic " + svcCredentials);
            request.PreAuthenticate = true;
            request.Method = sRequestMethod.ToUpper();
            request.ContentType = "application/json";

            if (sRequestMethod.ToUpper() == "POST" && !string.IsNullOrEmpty(sJSONData))
            {
                // Here we use Unicode encoding, but ASCIIEncoding would also work
                byte[] encodedData = encoding.GetBytes(sJSONData);

                // Write the data to the request stream
                var stream = request.GetRequestStream();
                stream.Write(encodedData, 0, encodedData.Length);
                stream.Close();
            }

            return request;
        }

        public List<MessageDetail> Send(List<Message> messages)
        {
            string sMessagesURI = sAPIBaseURL + "/messages";
            var request =
                GetWebRequest(
                    sMessagesURI,
                    "POST",
                    JsonConvert.SerializeObject(messages)
                );

            // try ... catch to handle errors nicely
            try
            {
                // make the call to the API
                var response = request.GetResponse();

                // read the response and print it to the console
                var reader = new StreamReader(response.GetResponseStream());

                return JsonConvert.DeserializeObject<List<MessageDetail>>(reader.ReadToEnd(), jss);
            }
            catch (WebException ex)
            {
                throw new BulkSMSException(ex.Message, ex);
            }
        }

        public Profile ReadProfile()
        {
            string sProfileURI = sAPIBaseURL + "/profile";
            var request =
                GetWebRequest(
                    sProfileURI,
                    "GET"
                );

            try
            {
                // make the call to the API
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                return JsonConvert.DeserializeObject<Profile>(reader.ReadToEnd(), jss);
            }
            catch (WebException ex)
            {
                throw new BulkSMSException(ex.Message, ex);
            }
        }

        public List<MessageDetail> QueryMessages()
        {
            string sMessagesURI = sAPIBaseURL + "/messages?" + HttpUtility.UrlEncode("filter=submission.date>=2018-01-01T10:00:00+01:00&limit=2&type=RECEIVED");
            var request =
                GetWebRequest(
                    sMessagesURI,
                    "GET"
                );

            try
            {
                // make the call to the API
                var response = request.GetResponse();

                // read the response and print it to the console
                var reader = new StreamReader(response.GetResponseStream());

                return JsonConvert.DeserializeObject<List<MessageDetail>>(reader.ReadToEnd(), jss);
            }
            catch (WebException ex)
            {
                throw new BulkSMSException(ex.Message, ex);
            }
        }

        public List<BlockedNumber> BlockedNumbers()
        {
            string sBlockedNumbersURI = sAPIBaseURL + "/blocked-numbers";
            var request =
                GetWebRequest(
                    sBlockedNumbersURI,
                    "GET"
                );

            try
            {
                // make the call to the API
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                return JsonConvert.DeserializeObject<List<BlockedNumber>>(reader.ReadToEnd(), jss);
            }
            catch (WebException ex)
            {
                throw new BulkSMSException(ex.Message, ex);
            }
        }

        public MessageDetail GetMessage(string id)
        {
            string sMessageURI = sAPIBaseURL + "/messages/" + id;
            var request =
                GetWebRequest(
                    sMessageURI,
                    "GET"
                );

            try
            {
                // make the call to the API
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                return JsonConvert.DeserializeObject<MessageDetail>(reader.ReadToEnd(), jss);
            }
            catch (WebException ex)
            {
                throw new BulkSMSException(ex.Message, ex);
            }
        }

        public List<MessageDetail> GetRelatedMessages(string id)
        {
            string sMessageURI = sAPIBaseURL + "/messages/" + id + "/relatedReceivedMessages";
            var request =
                GetWebRequest(
                    sMessageURI,
                    "GET"
                );

            try
            {
                // make the call to the API
                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());

                return JsonConvert.DeserializeObject<List<MessageDetail>>(reader.ReadToEnd(), jss);
            }
            catch (WebException ex)
            {
                throw new BulkSMSException(ex.Message, ex);
            }
        }
    }
}
