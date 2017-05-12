using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0511bv.Controllers
{
    public class Payload
    {
        public string url { get; set; }
    }

    public class Attachment
    {
        public string type { get; set; }
        public Payload payload { get; set; }
    }

    

    public class Facebook
    {
        public Attachment attachment { get; set; }
        public string text { get; set; }
    }


    public class Data
    {
        public Facebook facebook { get; set; }
    }

    public class ResRootObject
    {
        public string speech { get; set; }
        public string displayText { get; set; }
        public Data data { get; set; }
        public List<object> contextOut { get; set; }
        public string source { get; set; }
    }
}