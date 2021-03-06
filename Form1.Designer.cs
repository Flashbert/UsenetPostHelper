﻿namespace UsenetPostHelper
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSplit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFolderUpload = new System.Windows.Forms.TextBox();
            this.btnFolderSelect = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabPath = new System.Windows.Forms.TabPage();
            this.cbRarsettingsSize = new System.Windows.Forms.ComboBox();
            this.cbRarsettingsNoBasedir = new System.Windows.Forms.CheckBox();
            this.cbRarsettingsNoComp = new System.Windows.Forms.CheckBox();
            this.cbRarsettingsRecursive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectTemp = new System.Windows.Forms.Button();
            this.tbPathTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectYenc = new System.Windows.Forms.Button();
            this.tbPathYenc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectPar = new System.Windows.Forms.Button();
            this.tbPathPar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectRar = new System.Windows.Forms.Button();
            this.tbPathRar = new System.Windows.Forms.TextBox();
            this.lblRar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabPath);
            this.tabControl1.Location = new System.Drawing.Point(1, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.textBox1);
            this.tabMain.Controls.Add(this.button1);
            this.tabMain.Controls.Add(this.listViewFiles);
            this.tabMain.Controls.Add(this.cbSplit);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.txbFolderUpload);
            this.tabMain.Controls.Add(this.btnFolderSelect);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(696, 514);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFile,
            this.columnStatus});
            this.listViewFiles.Location = new System.Drawing.Point(7, 123);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(683, 77);
            this.listViewFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewFiles.TabIndex = 4;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // columnFile
            // 
            this.columnFile.Text = "File";
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            // 
            // cbSplit
            // 
            this.cbSplit.AutoSize = true;
            this.cbSplit.Location = new System.Drawing.Point(10, 100);
            this.cbSplit.Name = "cbSplit";
            this.cbSplit.Size = new System.Drawing.Size(52, 17);
            this.cbSplit.TabIndex = 3;
            this.cbSplit.Text = "Split?";
            this.cbSplit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the folder you want to post:";
            // 
            // txbFolderUpload
            // 
            this.txbFolderUpload.Location = new System.Drawing.Point(7, 65);
            this.txbFolderUpload.Name = "txbFolderUpload";
            this.txbFolderUpload.Size = new System.Drawing.Size(540, 20);
            this.txbFolderUpload.TabIndex = 1;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Location = new System.Drawing.Point(553, 63);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(75, 23);
            this.btnFolderSelect.TabIndex = 0;
            this.btnFolderSelect.Text = "Select...";
            this.btnFolderSelect.UseVisualStyleBackColor = true;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(696, 514);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabPath
            // 
            this.tabPath.Controls.Add(this.cbRarsettingsSize);
            this.tabPath.Controls.Add(this.cbRarsettingsNoBasedir);
            this.tabPath.Controls.Add(this.cbRarsettingsNoComp);
            this.tabPath.Controls.Add(this.cbRarsettingsRecursive);
            this.tabPath.Controls.Add(this.label5);
            this.tabPath.Controls.Add(this.btnSelectTemp);
            this.tabPath.Controls.Add(this.tbPathTemp);
            this.tabPath.Controls.Add(this.label2);
            this.tabPath.Controls.Add(this.btnSelectYenc);
            this.tabPath.Controls.Add(this.tbPathYenc);
            this.tabPath.Controls.Add(this.label4);
            this.tabPath.Controls.Add(this.btnSelectPar);
            this.tabPath.Controls.Add(this.tbPathPar);
            this.tabPath.Controls.Add(this.label3);
            this.tabPath.Controls.Add(this.btnSelectRar);
            this.tabPath.Controls.Add(this.tbPathRar);
            this.tabPath.Controls.Add(this.lblRar);
            this.tabPath.Location = new System.Drawing.Point(4, 22);
            this.tabPath.Name = "tabPath";
            this.tabPath.Size = new System.Drawing.Size(696, 514);
            this.tabPath.TabIndex = 2;
            this.tabPath.Text = "Path";
            this.tabPath.UseVisualStyleBackColor = true;
            // 
            // cbRarsettingsSize
            // 
            this.cbRarsettingsSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRarsettingsSize.Items.AddRange(new object[] {
            "10m",
            "20m",
            "50m",
            "100m"});
            this.cbRarsettingsSize.Location = new System.Drawing.Point(428, 78);
            this.cbRarsettingsSize.Name = "cbRarsettingsSize";
            this.cbRarsettingsSize.Size = new System.Drawing.Size(121, 21);
            this.cbRarsettingsSize.TabIndex = 17;
            // 
            // cbRarsettingsNoBasedir
            // 
            this.cbRarsettingsNoBasedir.AutoSize = true;
            this.cbRarsettingsNoBasedir.Checked = true;
            this.cbRarsettingsNoBasedir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRarsettingsNoBasedir.Location = new System.Drawing.Point(196, 80);
            this.cbRarsettingsNoBasedir.Name = "cbRarsettingsNoBasedir";
            this.cbRarsettingsNoBasedir.Size = new System.Drawing.Size(161, 17);
            this.cbRarsettingsNoBasedir.TabIndex = 16;
            this.cbRarsettingsNoBasedir.Text = "Exclude base dir from names";
            this.cbRarsettingsNoBasedir.UseVisualStyleBackColor = true;
            // 
            // cbRarsettingsNoComp
            // 
            this.cbRarsettingsNoComp.AutoSize = true;
            this.cbRarsettingsNoComp.Checked = true;
            this.cbRarsettingsNoComp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRarsettingsNoComp.Location = new System.Drawing.Point(87, 80);
            this.cbRarsettingsNoComp.Name = "cbRarsettingsNoComp";
            this.cbRarsettingsNoComp.Size = new System.Drawing.Size(103, 17);
            this.cbRarsettingsNoComp.TabIndex = 15;
            this.cbRarsettingsNoComp.Text = "No Compression";
            this.cbRarsettingsNoComp.UseVisualStyleBackColor = true;
            // 
            // cbRarsettingsRecursive
            // 
            this.cbRarsettingsRecursive.AutoSize = true;
            this.cbRarsettingsRecursive.Checked = true;
            this.cbRarsettingsRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRarsettingsRecursive.Location = new System.Drawing.Point(7, 80);
            this.cbRarsettingsRecursive.Name = "cbRarsettingsRecursive";
            this.cbRarsettingsRecursive.Size = new System.Drawing.Size(74, 17);
            this.cbRarsettingsRecursive.TabIndex = 14;
            this.cbRarsettingsRecursive.Text = "Recursive";
            this.cbRarsettingsRecursive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rar settings";
            // 
            // btnSelectTemp
            // 
            this.btnSelectTemp.Location = new System.Drawing.Point(558, 273);
            this.btnSelectTemp.Name = "btnSelectTemp";
            this.btnSelectTemp.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTemp.TabIndex = 11;
            this.btnSelectTemp.Text = "Select";
            this.btnSelectTemp.UseVisualStyleBackColor = true;
            this.btnSelectTemp.Click += new System.EventHandler(this.btnSelectTemp_Click);
            // 
            // tbPathTemp
            // 
            this.tbPathTemp.Location = new System.Drawing.Point(7, 275);
            this.tbPathTemp.Name = "tbPathTemp";
            this.tbPathTemp.Size = new System.Drawing.Size(542, 20);
            this.tbPathTemp.TabIndex = 10;
            this.tbPathTemp.Text = "D:\\TempUploadHelper\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Temporary Folder (Make sure there are no files/folders below!)";
            // 
            // btnSelectYenc
            // 
            this.btnSelectYenc.Location = new System.Drawing.Point(558, 220);
            this.btnSelectYenc.Name = "btnSelectYenc";
            this.btnSelectYenc.Size = new System.Drawing.Size(75, 23);
            this.btnSelectYenc.TabIndex = 8;
            this.btnSelectYenc.Text = "Select";
            this.btnSelectYenc.UseVisualStyleBackColor = true;
            this.btnSelectYenc.Click += new System.EventHandler(this.btnSelectYenc_Click);
            // 
            // tbPathYenc
            // 
            this.tbPathYenc.Location = new System.Drawing.Point(7, 222);
            this.tbPathYenc.Name = "tbPathYenc";
            this.tbPathYenc.Size = new System.Drawing.Size(542, 20);
            this.tbPathYenc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select location of yenc";
            // 
            // btnSelectPar
            // 
            this.btnSelectPar.Location = new System.Drawing.Point(558, 165);
            this.btnSelectPar.Name = "btnSelectPar";
            this.btnSelectPar.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPar.TabIndex = 5;
            this.btnSelectPar.Text = "Select";
            this.btnSelectPar.UseVisualStyleBackColor = true;
            this.btnSelectPar.Click += new System.EventHandler(this.btnSelectPar_Click);
            // 
            // tbPathPar
            // 
            this.tbPathPar.Location = new System.Drawing.Point(7, 167);
            this.tbPathPar.Name = "tbPathPar";
            this.tbPathPar.Size = new System.Drawing.Size(542, 20);
            this.tbPathPar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select location of par.exe";
            // 
            // btnSelectRar
            // 
            this.btnSelectRar.Location = new System.Drawing.Point(558, 35);
            this.btnSelectRar.Name = "btnSelectRar";
            this.btnSelectRar.Size = new System.Drawing.Size(75, 23);
            this.btnSelectRar.TabIndex = 2;
            this.btnSelectRar.Text = "Select";
            this.btnSelectRar.UseVisualStyleBackColor = true;
            this.btnSelectRar.Click += new System.EventHandler(this.btnSelectRar_Click);
            // 
            // tbPathRar
            // 
            this.tbPathRar.Location = new System.Drawing.Point(7, 37);
            this.tbPathRar.Name = "tbPathRar";
            this.tbPathRar.Size = new System.Drawing.Size(542, 20);
            this.tbPathRar.TabIndex = 1;
            this.tbPathRar.Text = "C:\\Program Files\\WinRAR\\rar.exe";
            // 
            // lblRar
            // 
            this.lblRar.AutoSize = true;
            this.lblRar.Location = new System.Drawing.Point(7, 21);
            this.lblRar.Name = "lblRar";
            this.lblRar.Size = new System.Drawing.Size(124, 13);
            this.lblRar.TabIndex = 0;
            this.lblRar.Text = "Select location of rar.exe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 232);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 189);
            this.textBox1.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 571);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "UsenetUploadHelper";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabPath.ResumeLayout(false);
            this.tabPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabPath;
        private System.Windows.Forms.Button btnFolderSelect;
        private System.Windows.Forms.TextBox txbFolderUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSplit;
        private System.Windows.Forms.Button btnSelectRar;
        private System.Windows.Forms.TextBox tbPathRar;
        private System.Windows.Forms.Label lblRar;
        private System.Windows.Forms.Button btnSelectYenc;
        private System.Windows.Forms.TextBox tbPathYenc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectPar;
        private System.Windows.Forms.TextBox tbPathPar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnFile;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.Button btnSelectTemp;
        private System.Windows.Forms.TextBox tbPathTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRarsettingsSize;
        private System.Windows.Forms.CheckBox cbRarsettingsNoBasedir;
        private System.Windows.Forms.CheckBox cbRarsettingsNoComp;
        private System.Windows.Forms.CheckBox cbRarsettingsRecursive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

