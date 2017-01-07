using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UsenetPostHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Getter setter
        public string Logbox
        {
            get { return tbLog.Text; }
            set { tbLog.Text = value; }
        }

        public string PathTemp
        {
            get { return tbPathTemp.Text; }
        }

        public string PathRar
        {
            get { return tbPathRar.Text; }
        }

        public string PathUploadFolder
        {
            get { return txbUploadFolder.Text;  }
        }

        public bool RarsettingsNoCompression
        {
            get { return cbRarsettingsNoComp.Checked;  }
        }

        public bool RarsettingsRecursive
        {
            get { return cbRarsettingsRecursive.Checked; }
        }

        public ComboBox RarsettingsSize
        {
            get { return cbRarsettingsSize;  }
        }


        //LISTVIEW
        private void ListviewFill(string rarname)
        {
            lvFiles.Items.Clear();

            string[] files = Directory.GetFiles(tbPathTemp.Text);
            foreach (string file in files)
            {

                string fileName = Path.GetFileName(file);
                if (fileName.StartsWith(rarname))
                {
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = file;

                    lvFiles.Items.Add(item);
                }
            }
        }


        //Buttons
        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSelectUpload = new FolderBrowserDialog();
            if(folderSelectUpload.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbUploadFolder.Text = folderSelectUpload.SelectedPath;
            }
        }

        private void btnSelectRar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdSelectRar = new OpenFileDialog();
            fdSelectRar.Filter = "Rar.exe|rar.exe";
            fdSelectRar.FilterIndex = 1;
            fdSelectRar.Multiselect = false;

            if (fdSelectRar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbPathRar.Text = fdSelectRar.FileName;
            }
        }

        private void btnSelectPar_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectYenc_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectTemp_Click(object sender, EventArgs e)
        {

        }

        private void btnStartPrepare_Click_1(object sender, EventArgs e)
        {
            Rar rar = new Rar(this);
            string rarname = rar.CompressFolder();
            if(rarname != null)
            {
                ListviewFill(rarname);
            }
        }

    }
}
