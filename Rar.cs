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
                process.StartInfo.Arguments = @"a " + form.PathTemp + timestamp + @" -r -mx0 -v50m " + form.PathUploadFolder;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = false;

                process.Start();
                form.Logbox += "Creating archive from " + form.PathUploadFolder + " as " + timestamp + "\r\n";
                process.WaitForExit();
                process.Close();

                form.Logbox += "Archiving finished\r\n";
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
