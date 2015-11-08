using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsenetPostHelper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSelectUpload = new FolderBrowserDialog();
            if(folderSelectUpload.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbFolderUpload.Text = folderSelectUpload.SelectedPath;
            }
        }

        private void btnSelectRar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdSelectRar = new OpenFileDialog();
            fdSelectRar.Filter = "Rar Executable|rar.exe";
            fdSelectRar.FilterIndex = 1;
            fdSelectRar.Multiselect = false;

            //fdSelectRar.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Rar rar = new Rar();
            rar.Compressfolder();
            //textBox1.Text = rar.Compressfolder();
        }
    }
}
