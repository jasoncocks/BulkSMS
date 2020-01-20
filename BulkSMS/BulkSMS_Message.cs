using System;

namespace BulkSMS
{
    public class Message
    {
        public string to { get; set; }
        public string body { get; set; }
    }

    public class Submission
    {
        public string id { get; set; }
        public DateTime date { get; set; }
    }

    public class Status
    {
        public string id { get; set; }
        public string type { get; set; }
        public object subtype { get; set; }
    }

    public class MessageDetail
    {
        public string id { get; set; }
        public string type { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string body { get; set; }
        public string encoding { get; set; }
        public int protocolId { get; set; }
        public int messageClass { get; set; }
        public Submission submission { get; set; }
        public Status status { get; set; }
        public string relatedSentMessageId { get; set; }
        public string userSuppliedId { get; set; }
        public string numberOfParts { get; set; }
        public string creditCost { get; set; }
    }
}
