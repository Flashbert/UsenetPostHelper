using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace UsenetPostHelper
{
    public class Rar
    {
        public string Compressfolder() 
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\WinRAR\rar.exe", @"a D:\TempUploadHelper\test.rar -r -m0 -ep1 -v50m D:\weihnachten2011")
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                RedirectStandardOutput = true,
                CreateNoWindow = false
            };
            //" + GetTimestamp(DateTime.Now) + @"
            return "Rar process finished!";
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssfff");
        }
    }
}
