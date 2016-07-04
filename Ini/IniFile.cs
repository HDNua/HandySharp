using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.InteropServices;

namespace Handy.Ini
{
    /// <summary>
    /// 환경 정보를 담고 있는 ini 파일에 대한 객체입니다.
    /// </summary>
    public class IniFile
    {
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString
            (string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string val, string path);

        // common inner member
        class Section
        {
            public string Name { get; set; }
            public Dictionary<string, string> Table { get; set; }
            public Section(string name)
            {
                this.Name = name;
                this.Table = new Dictionary<string, string>();
            }
        }

        // constructor
        FileInfo ini_info = null;
        Dictionary<string, Section> sections;

        /// <summary>
        /// 환경 정보를 담고 있는 ini 파일에 대한 객체를 생성합니다. 파일이 없으면 생성합니다.
        /// </summary>
        /// <param name="path">ini 파일의 경로입니다.</param>
        public IniFile(string path)
        {
            ini_info = new FileInfo(path);
            sections = new Dictionary<string, Section>();
        }

        // instance method
        /// <summary>
        /// 키에 대한 값을 지정한 섹션에 설정합니다.
        /// </summary>
        /// <param name="section">키에 대해 값을 설정할 섹션 이름입니다.</param>
        /// <param name="key">값을 설정하기 위해 사용할 키입니다.</param>
        /// <param name="value">키에 대해 설정할 값입니다.</param>
        public void Set(string section, string key, string value)
        {
            Section sectionObject;
            if (this.sections.ContainsKey(section))
            {
                sectionObject = this.sections[section];
            }
            else
            {
                sectionObject = new Section(section);
                this.sections.Add(section, sectionObject);
            }

            Dictionary<string, string> table = sectionObject.Table;
            if (table.ContainsKey(key))
            {
                table[key] = value;
            }
            else
            {
                table.Add(key, value);
            }
        }
        /// <summary>
        /// 섹션에서 키를 제거합니다.
        /// </summary>
        /// <param name="section">키를 제거할 섹션입니다.</param>
        /// <param name="key">제거할 키입니다.</param>
        public void Remove(string section, string key)
        {
            Section sectionObject = this.sections[section];
            sectionObject.Table.Remove(key);
        }
        /// <summary>
        /// 프로필 파일에서 해당 섹션의 키에 대한 값을 가져옵니다.
        /// </summary>
        /// <param name="section">키에 대한 값을 가져올 섹션 이름입니다.</param>
        /// <param name="key">값을 가져오기 위해 사용할 키입니다.</param>
        /// <param name="def">키가 없거나 키에 대해 대해 값이 없을 경우 반환할 기본 값입니다.</param>
        /// <returns>섹션에 속하는 키에 대한 값을 반환합니다.</returns>
        public string Get(string section, string key, string def = "")
        {
            StringBuilder retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, def, retVal, 255, ini_info.FullName);
            return retVal.ToString();
        }
        /// <summary>
        /// 인스턴스가 저장하고 있는 설정 정보로 기존 설정 파일을 대체합니다.
        /// </summary>
        public void Write()
        {
            ini_info.Delete();
            string path = ini_info.FullName;
            foreach (string section in sections.Keys)
            {
                Section sectionObject = sections[section];
                Dictionary<string, string> table = sectionObject.Table;
                foreach (string key in table.Keys)
                {
                    string value = table[key];
                    WritePrivateProfileString(section, key, value, path);
                }
            }
        }
        /// <summary>
        /// 인스턴스가 저장하고 있는 설정 정보를 파일에 추가합니다.
        /// </summary>
        public void Update()
        {
            string path = ini_info.FullName;
            foreach (string section in sections.Keys)
            {
                Section sectionObject = sections[section];
                Dictionary<string, string> table = sectionObject.Table;
                foreach (string key in table.Keys)
                {
                    string value = table[key];
                    WritePrivateProfileString(section, key, value, path);
                }
            }
        }
    }
}
