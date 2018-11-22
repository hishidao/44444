using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IPADDemo.Util
{
    public static class Cover
    {
        [DllImport("kernel32.dll")]
        public static extern int MultiByteToWideChar(int CodePage, int dwFlags, string lpMultiByteStr, int cchMultiByte, [MarshalAs(UnmanagedType.LPWStr)]string lpWideCharStr, int cchWideChar);

        /// <summary>
        /// 宽字符集转换
        /// </summary>
        /// <param name="content"></param>
        /// <param name="toEncode"></param>
        /// <returns></returns>
        public static string MByteToWChar(string content, int toEncode)
        {
            //字符编码转换 GB2312:936   UTF-8:65001  BIG5:950  latin1:1252
            int len = Cover.MultiByteToWideChar(toEncode, 0, content, -1, null, 0);
            char[] temp = new char[len];
            string content1 = new string(temp);
            Cover.MultiByteToWideChar(toEncode, 0, content, -1, content1, len);
            return content1.Replace("\0", "");
        }

    }
}
