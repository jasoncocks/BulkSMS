using System.Collections.Generic;

namespace BulkSMS
{
    public class To
    {
        public string address { get; set; }
        public List<string> fields { get; set; }
    }

    public class TemplateMessage
    {
        // e.g. body = Good morning {F0######}, your balance is {F1######}
        // https://www.bulksms.com/developer/json/v1/#tag/Message%2Fpaths%2F~1messages%2Fpost
        public string body { get; set; }

        public List<To> to { get; set; }
    }
}
