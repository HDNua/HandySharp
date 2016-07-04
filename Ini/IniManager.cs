using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

namespace Handy.Ini
{
    /// <summary>
    /// 환경 정보를 담고 있는 ini 파일에 대한 싱글톤 객체입니다.
    /// </summary>
    public static class IniManager
    {
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString
            (string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string val, string path);

        // public IniManager class methods
        /// <summary>
        /// 프로필 파일에서 해당 섹션의 키에 대한 값을 가져옵니다.
        /// </summary>
        /// <param name="path">ini 파일의 경로입니다.</param>
        /// <param name="section">키에 대한 값을 가져올 섹션 이름입니다.</param>
        /// <param name="key">값을 가져오기 위해 사용할 키입니다.</param>
        /// <param name="def">키가 없거나 키에 대해 대해 값이 없을 경우 반환할 기본 값입니다.</param>
        /// <returns>섹션에 속하는 키에 대한 값을 반환합니다.</returns>
        public static string Read(string path, string section, string key, string def = "")
        {
            StringBuilder retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, def, retVal, retVal.Capacity, path);
            return retVal.ToString();
        }
        /// <summary>
        /// 프로필 파일에 해당 섹션의 키에 대한 값을 설정합니다.
        /// </summary>
        /// <param name="path">ini 파일의 경로입니다.</param>
        /// <param name="section">키에 대해 값을 설정할 섹션 이름입니다.</param>
        /// <param name="key">값을 설정하기 위해 사용할 키입니다.</param>
        /// <param name="value">키에 대해 설정할 값입니다.</param>
        public static void Write(string path, string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, path);
        }
    }
}
