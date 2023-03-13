using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace OpenINI
{
    public class OpenINI:BaseINI
    {
        
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string rel, string fileName);
        [DllImport("kernel32.dll")]
        private static  extern  int GetPrivateProfileString(string section, string key, string def, StringBuilder rel, int size, string fileName);

        public string fileName;
        /// <summary>
        /// 初始化对象，需输入包含文件目录的（.ini）文件名
        /// </summary>
        /// <param name="FileName">文件名</param>
        public OpenINI(string FileName)
        {
            fileName = FileName;
        }
        /// <summary>
        /// 获取一个配置文件下的所有节名
        /// </summary>
        /// <returns>StringCollection对象，用于存储节名转换过来的字符串集合</returns>
        public StringCollection ReadAllSections()
        {
            return ParseValues(null,null,null,fileName);
        }
        /// <summary>
        /// 获取对应的section节下的各个键；
        /// </summary>
        /// <param name="section">节名</param>
        /// <returns>StringCollection对象，用于存储键名转换过来的字符串集合</returns>
        public StringCollection ReadAllKey(string section)
        {
            return ParseValues(section, null, null, fileName);
        }
        /// <summary>
        /// 返回对应节、键对应索引的值
        /// </summary>
        /// <param name="section">节名</param>
        /// <param name="key">键名</param>
        /// <returns>string对象，对应的节、键的值</returns>
        public string ReadIni(string section,string key)
        {
            StringBuilder rel=new StringBuilder(500);
            GetPrivateProfileString(section, key, "", rel, 500, fileName);
            return rel.ToString();
        }
        /// <summary>
        /// 写入.ini文件配置参数
        /// </summary>
        /// <param name="section">节名</param>
        /// <param name="key">键</param>
        /// <param name="rel">键对应的值</param>
        public void WriteINI(string section,string key,string rel)
        {
            WritePrivateProfileString(section, key, rel, fileName);
            UpdateData(fileName);
        }
        /// <summary>
        /// 删除对应的节及其内容
        /// </summary>
        /// <param name="section">节名</param>
        public  void DeleteSection(string section)
        {
            WritePrivateProfileString(section, null, null, fileName);
        }
        /// <summary>
        /// 删除某个节中对应的键及其内容
        /// </summary>
        /// <param name="section">节名</param>
        /// <param name="key">键名</param>
        public  void DeleteKey(string section,string key)
        {
            WritePrivateProfileString(section, key, null, fileName);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ItemExists(string section, string key)
        {
            StringCollection stc = ParseValues(section, key, null, fileName);
            return stc.IndexOf(key) > -1;
        }
    }
}
