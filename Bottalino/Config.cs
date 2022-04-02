using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bottalino
{
    public partial class Config : Form
    {
        private string sIpAddress;
        private int port;
        private string username;
        private string password;
        private string path;
        private string serverPath;


        public Config()
        {
            InitializeComponent();
            LoadFromAppConfig();
        }

        private void LoadFromAppConfig()
        {
            sIpAddress = Properties.Settings.Default.ftpHost;
            this.ipAddressControl1.Text = sIpAddress;
            port = Properties.Settings.Default.port;
            this.textBoxPort.Text = port.ToString();
            username = Properties.Settings.Default.username;
            this.textBoxUsername.Text = username;
            password = Properties.Settings.Default.password;
            this.textBoxPassword.Text = password;
            path = Properties.Settings.Default.path;
            this.textBoxPath.Text = path;
            serverPath = Properties.Settings.Default.serverPath;
            this.textBoxPathServer.Text = serverPath;
        }

        private void SaveToAppConfig()
        {          
            sIpAddress = this.ipAddressControl1.Text;
            Properties.Settings.Default.ftpHost = sIpAddress;
            port = Int32.Parse(this.textBoxPort.Text);
            Properties.Settings.Default.port = port;
            username = this.textBoxUsername.Text;
            Properties.Settings.Default.username = username;
            password = this.textBoxPassword.Text;
            Properties.Settings.Default.password = password;
            path = this.textBoxPath.Text;
            Properties.Settings.Default.path = path;
            serverPath = this.textBoxPathServer.Text;
            Properties.Settings.Default.serverPath = serverPath;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {
            UpdateTextPosition();
        }


        private void UpdateTextPosition()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveToAppConfig();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void buttonPathServer_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialogPathServer.ShowDialog() == DialogResult.OK)
            {
                this.textBoxPathServer.Text = this.folderBrowserDialogPathServer.SelectedPath;
            }
        }
    }
}
