using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationConfig
{
    public class GeneralConfig
    {
        int Interval = 0;
        List<string> configList;
        List<string> configListValues;
        readonly string ConfigFileName = "GeneralConfig.cfg";

        public bool SetConfig(int IntervalValue)
        {
            Interval = IntervalValue * 60000;
            string result = $"WORD_INTERVAL={Interval}";

            return WriteConfigToFile(result);
        }
        protected bool WriteConfigToFile(string ConfigText)
        {
            try
            {
                if (!File.Exists(ConfigFileName))
                {
                    File.Create(ConfigFileName);
                }
                else if (File.Exists(ConfigFileName))
                {
                    try
                    {
                        using (StreamWriter writetext = new StreamWriter(ConfigFileName))
                        {
                            writetext.WriteLine(ConfigText);
                        }
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public ConfigProperties ReadConfigFromFile()
        {
            string line;
            string[] eachLine = new string[2];
            configList = new List<string>();
            configListValues = new List<string>();
            ConfigProperties properties = new ConfigProperties();
            using (StreamReader sr = new StreamReader(ConfigFileName))
            {
                while ((line = sr.ReadLine()) != null)
                    configList.Add(line);
            }
            foreach (var item in configList)
            {
                eachLine = item.Split('=');
                configListValues.Add(eachLine[1]);
            }

            properties.WordInterval = int.Parse(configListValues[0]);
            return properties;
        }
    }

    public class ConfigProperties
    {
        public int WordInterval { get; set; }
    }
}
