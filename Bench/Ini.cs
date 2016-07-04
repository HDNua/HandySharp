using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Handy.Ini;
using System.IO;

namespace Bench
{
    public static class Ini
    {
        readonly static string dir = Environment.CurrentDirectory;

        public static void IniManagerTest1()
        {
            string section = "Test Section";
            string key = "Test Key";
            string value = "Test Value";
            string path = dir + @"\Bench\setting.ini";

            IniManager.Write(section, key, value, path);

            value = string.Empty;
            Console.WriteLine("before: [{0}]", value);

            value = IniManager.Read(section, key, path);
            Console.WriteLine("after: [{0}]", value);

            value = string.Empty;
            IniManager.Write(section, key, value, path);
        }
        public static void IniManagerTest2()
        {
            string ini_path = dir + @"\Bench\GameSetting.ini";
            IniManager.Write("Sound", "Volume", "100", ini_path);

            string value = IniManager.Read("Sound", "Volume", ini_path);
            Console.WriteLine(value);
        }

        public static void IniFileTest()
        {
            string path = dir + @"\Bench\setting.ini";
            IniFile iniFile = new IniFile(path);

            iniFile.Set("section1", "key1", "value111");
            iniFile.Write();

            iniFile.Set("section2", "key1", "value221");
            iniFile.Update();

            iniFile.Set("section1", "key1", "value112");
            iniFile.Set("section2", "key2", "value221");
            iniFile.Update();

            string value = iniFile.Get("section1", "key2");
            Console.WriteLine(value);
        }
    }
}
