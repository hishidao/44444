using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IPADDemo.Util
{
    public class Convert62
    {
        [DllImport("EUtils.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr EStrToHex(string context);

        [DllImport("EUtils.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr EHexToStr(string context);

        /// <summary>
        /// 16进制转字符串
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string eStrToHex(string context) {
            IntPtr intptr = EStrToHex(context);
            string str = "" + Marshal.PtrToStringAnsi(intptr).Substring(0,344);
            return str;
        }

        /// <summary>
        /// 字符串转16进制
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string eHexToStr(string context)
        {
            IntPtr intptr = EHexToStr(context);
            string str = "" + Marshal.PtrToStringAnsi(intptr).Substring(0,232);
            return str;
        }
    }
}
