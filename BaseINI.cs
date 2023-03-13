using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace OpenINI
{
     public abstract  class BaseINI
    {
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string rel, string fileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] rels, int size, string fileName);
        /// <summary>
        /// 解析.ini文件中的节、键、值名对应的编码，转换成对应的字符；
        /// </summary>
        /// <param name="byteRel">GetPrivateProfileString（）方法返回的数值，代表数据段的长度</param>
        /// <param name="rels">存储数据的byte[]数组</param>
        /// <returns>StringCollection对象，用于存储转换过来的字符串集合</returns>
        public StringCollection ParseValues(string section,string key,string def,string fileName)
        {
            byte[] rels = new byte[65536];
            int byteRel = GetPrivateProfileString(section, key, def, rels, rels.GetUpperBound(0), fileName);
            StringCollection Items = new StringCollection();
            if (byteRel != 0)
            {
                int start = 0;//数据段的分隔位数
                for (int lgth = 0; lgth < byteRel; lgth++)
                {
                    if ((rels[lgth] == 0) && ((lgth - start) > 0))//当数据段某一位为0时，即为分隔位！
                    {
                        string str = Encoding.GetEncoding(0).GetString(rels, start, lgth - start);//(lgth-start)为数据段内容
                        Items.Add(str);
                        start = lgth + 1;
                    }
                }
            }
            return Items;
        }
        /// <summary>
        /// 用于写入数据的更新，将缓冲中的数据写入文件
        /// </summary>
        public void UpdateData(string fileName)
        {
            WritePrivateProfileString(null, null, null, fileName);
        }
    }
}
