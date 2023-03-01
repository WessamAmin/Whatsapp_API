using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Whatsapp_API.Models
{
    public class Class2
    {
        public class Component
        {
            public string type { get; set; }
            public List<Class2.Parameter> parameters { get; set; }
        }

        public class Document
        {
            public string filename { get; set; }
            public string link { get; set; }
        }

        public class Language
        {
            public string policy { get; set; }
            public string code { get; set; }
        }

        public class Parameter
        {
            public string type { get; set; }
            public Document document { get; set; }
            public string text { get; set; }


        }

        public class Root
        {
            public string to { get; set; }
            public string type { get; set; }
            public string messaging_product { get; set; }
            public Template template { get; set; }
        }

        public class Template
        {
            public List<Component> components { get; set; }
            public Language language { get; set; }
            public string name { get; set; }
        }

    }
}