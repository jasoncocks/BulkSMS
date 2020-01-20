using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Newtonsoft.Json;

namespace BulkSMS
{
    // [Serializable]
    public class BulkSMSException : Exception
    {
        // [NonSerialized]
        public BulkSMS_Error BulkSmsError;

        public string ResourceReferenceProperty { get; set; }

        public BulkSMSException()
        {
        }

        public BulkSMSException(string message)
            : base(message)
        {
        }

        public BulkSMSException(string message, Exception inner)
            : base(message, inner)
        {
            if (inner.GetType() == typeof(WebException))
            {
                WebException ex = (WebException)inner;
                var reader = new StreamReader(ex.Response.GetResponseStream());
                BulkSmsError =
                    JsonConvert.DeserializeObject<BulkSMS_Error>(
                            reader.ReadToEnd(),
                            new JsonSerializerSettings {
                                MissingMemberHandling = MissingMemberHandling.Ignore }
                    );
            }
        }

        protected BulkSMSException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ResourceReferenceProperty = info.GetString("ResourceReferenceProperty");
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");
            info.AddValue("ResourceReferenceProperty", ResourceReferenceProperty);
            base.GetObjectData(info, context);
        }

    }
}
