using System;
using System.IO;
using System.Xml.Linq;

namespace ServiceSaleMachine
{
    public class CheckConfiguration
    {
        private const string RootName = "CheckConfiguration";
        private const string FileName = "CheckConfiguration.cfg";

        public CheckConfigurationProperties Settings { get; private set; }

        public CheckConfiguration()
        {
            Settings = new CheckConfigurationProperties();
        }

        public bool Load()
        {
            try
            {
                string fileName = Globals.GetPath(PathEnum.Bin) + "\\" + FileName;
                if (File.Exists(fileName))
                {
                    XElement root = XElement.Load(fileName);
                    if (root.Name != RootName) return false;

                    XElement xElement;

                    // Настройки драйверов
                    XElement xSettings = root.Element("Settings");

                    if (xSettings != null)
                    {
                        if ((xElement = xSettings.Element("firmsname")) != null) Settings.firmsname = xElement.Value;
                    }

                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        public bool Save()
        {
            try
            {
                XElement root = new XElement(RootName);

                // Настройки
                XElement xSettings = new XElement("Settings");

                xSettings.Add(new XElement("firmsname", Settings.firmsname));

                if (xSettings.HasElements)
                {
                    root.Add(xSettings);
                }

                if (!File.Exists(Globals.GetPath(PathEnum.Bin) + "\\" + FileName))
                {
                    Directory.CreateDirectory(Globals.GetPath(PathEnum.Bin));
                    FileStream fs = File.Create(Globals.GetPath(PathEnum.Bin) + "\\" + FileName);
                    fs.Close();
                }
                root.Save(Globals.GetPath(PathEnum.Bin) + "\\" + FileName);
                return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }
    }
}
