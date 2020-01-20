using System;
using System.Collections.Generic;
using System.Text;

namespace BulkSMS
{
    public class BulkSMS_Error
    {
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string detail { get; set; }
    }
}
