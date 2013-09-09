using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TM_2
{
    public class XmlWorker
    {
        private const string SETTINGS_FILE = "Settings.Xml";

        public static string GetTimeShift()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "TimeShift")
                    {
                            return xElement.Value;
                    }
                }
            return "0";
        }
    }
}
