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

        public static int GetLastYear()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "LastYear")
                    {
                        return Convert.ToInt32(xElement.Value);
                    }
                }
            return 0;
        }

        public static void SetLastYear(string text)
        {
            var xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
            {
                xDocument.Root.Elements().Where(e => e.Name == "LastYear").Remove();
                var elem = new XElement("LastYear");
                elem.Value = text;
                xDocument.Root.Add(elem);
            }
            xDocument.Save(SETTINGS_FILE);
        }

        public static int GetLastMonth()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "LastMonth")
                    {
                        return Convert.ToInt32(xElement.Value);
                    }
                }
            return 0;
        }

        public static void SetLastMonth(string text)
        {
            var xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
            {
                xDocument.Root.Elements().Where(e => e.Name == "LastMonth").Remove();
                var elem = new XElement("LastMonth");
                elem.Value = text;
                xDocument.Root.Add(elem);
            }
            xDocument.Save(SETTINGS_FILE);
        }
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

        public static string GetLastServer()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "LastServer")
                    {
                        return xElement.Value;
                    }
                }
            return "";
        }

        public static string GetLastUserName()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "LastLogin")
                    {
                        return xElement.Value;
                    }
                }
            return "";
        }

        public static string GetLastDataBase()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "LastDataBase")
                    {
                        return xElement.Value;
                    }
                }
            return "";
        }

        public static string GetImportHourPowerShift()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "ImportHourPowerShift")
                    {
                        return xElement.Value;
                    }
                }
            return "0";
        }

        public static void SetLastServer(string text)
        {
            var xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
            {
                xDocument.Root.Elements().Where(e => e.Name == "LastServer").Remove();
                var elem = new XElement("LastServer");
                elem.Value = text;
                xDocument.Root.Add(elem);
            }
            xDocument.Save(SETTINGS_FILE);
        }

        public static void SetLastLogin(string text)
        {
            var xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
            {
                xDocument.Root.Elements().Where(e => e.Name == "LastLogin").Remove();
                var elem = new XElement("LastLogin");
                elem.Value = text;
                xDocument.Root.Add(elem);
            }
            xDocument.Save(SETTINGS_FILE);
        }

        public static void SetLastDataBase(string text)
        {
            var xDocument = XDocument.Load(SETTINGS_FILE);
            if (xDocument.Root != null)
            {
                xDocument.Root.Elements().Where(e => e.Name == "LastDataBase").Remove();
                var elem = new XElement("LastDataBase");
                elem.Value = text;
                xDocument.Root.Add(elem);
            }
            xDocument.Save(SETTINGS_FILE);
        }
    }
}
