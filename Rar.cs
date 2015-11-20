using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace UsenetPostHelper
{
    public class Rar
    {
        //Constructor
        private readonly Main form;
        public Rar(Main form)
        {
            this.form = form;
        }

       /* public string Compressfolder() 
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files\WinRAR\rar.exe", @"a D:\TempUploadHelper\" + GetTimestamp(DateTime.Now) + @" -r -m0 -ep1 -v50m D:\weihnachten2011")
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = false,
                CreateNoWindow = false
            };
            var process = Process.Start(startInfo);
            process.WaitForExit(1000);
            return "Rar process finished!";
        }
        */
        //TEST

        //private static int lineCount = 0;
        //private static StringBuilder output = new StringBuilder();

        public string CompressFolder()
        {
            string timestamp = GetTimestamp(DateTime.Now);
            Process process = new Process();

            try
            {
                if (!File.Exists(form.PathRar))
                {
                    throw new FileNotFoundException("Rar.exe not found. Please check if path is set correctly and it exists!");
                }
                if (!Directory.Exists(form.PathTemp))
                {
                    throw new DirectoryNotFoundException("Temporary folder does not exist. Please check if path is set correctly and it exists!");
                }

                process.StartInfo.FileName = form.PathRar;
                process.StartInfo.Arguments = @"a " + form.PathTemp + timestamp + @" -r -m0 -ep1 -v50m D:\Wallpapers";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.RedirectStandardOutput = false;

                process.Start();
                process.WaitForExit();
                process.Close();

                form.Logbox += "RAR finished";
                return timestamp;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssfff");
        }
    }
}
