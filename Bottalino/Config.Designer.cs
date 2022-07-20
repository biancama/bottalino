namespace Bottalino
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.labelIpAddressControl = new System.Windows.Forms.Label();
            this.ipAddressControl1 = new IPAddressControlLib.IPAddressControl();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelServerPath = new System.Windows.Forms.Label();
            this.folderBrowserDialogPathServer = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxPathServer = new System.Windows.Forms.TextBox();
            this.buttonPathServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIpAddressControl
            // 
            this.labelIpAddressControl.AutoSize = true;
            this.labelIpAddressControl.Location = new System.Drawing.Point(86, 71);
            this.labelIpAddressControl.Name = "labelIpAddressControl";
            this.labelIpAddressControl.Size = new System.Drawing.Size(68, 13);
            this.labelIpAddressControl.TabIndex = 0;
            this.labelIpAddressControl.Text = "Indirizzo FTP";
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.AllowInternalTab = false;
            this.ipAddressControl1.AutoHeight = true;
            this.ipAddressControl1.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl1.Location = new System.Drawing.Point(204, 68);
            this.ipAddressControl1.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.ReadOnly = false;
            this.ipAddressControl1.Size = new System.Drawing.Size(179, 20);
            this.ipAddressControl1.TabIndex = 1;
            this.ipAddressControl1.Text = "...";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(204, 368);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Salva";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(86, 122);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(32, 13);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Porta";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(86, 168);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(86, 214);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(86, 260);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(49, 13);
            this.labelPath.TabIndex = 6;
            this.labelPath.Text = "Percorso";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(204, 114);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(204, 161);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(204, 211);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(204, 260);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(179, 20);
            this.textBoxPath.TabIndex = 10;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(308, 368);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Chiudi";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelServerPath
            // 
            this.labelServerPath.AutoSize = true;
            this.labelServerPath.Location = new System.Drawing.Point(86, 301);
            this.labelServerPath.Name = "labelServerPath";
            this.labelServerPath.Size = new System.Drawing.Size(106, 13);
            this.labelServerPath.TabIndex = 12;
            this.labelServerPath.Text = "Percorso Savataggio";
            // 
            // folderBrowserDialogPathServer
            // 
            this.folderBrowserDialogPathServer.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // textBoxPathServer
            // 
            this.textBoxPathServer.Location = new System.Drawing.Point(204, 298);
            this.textBoxPathServer.Name = "textBoxPathServer";
            this.textBoxPathServer.Size = new System.Drawing.Size(254, 20);
            this.textBoxPathServer.TabIndex = 13;
            // 
            // buttonPathServer
            // 
            this.buttonPathServer.Location = new System.Drawing.Point(464, 296);
            this.buttonPathServer.Name = "buttonPathServer";
            this.buttonPathServer.Size = new System.Drawing.Size(75, 23);
            this.buttonPathServer.TabIndex = 14;
            this.buttonPathServer.Text = "Browse...";
            this.buttonPathServer.UseVisualStyleBackColor = true;
            this.buttonPathServer.Click += new System.EventHandler(this.buttonPathServer_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.buttonPathServer);
            this.Controls.Add(this.textBoxPathServer);
            this.Controls.Add(this.labelServerPath);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.ipAddressControl1);
            this.Controls.Add(this.labelIpAddressControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIpAddressControl;
        private IPAddressControlLib.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelServerPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPathServer;
        private System.Windows.Forms.TextBox textBoxPathServer;
        private System.Windows.Forms.Button buttonPathServer;
    }
}