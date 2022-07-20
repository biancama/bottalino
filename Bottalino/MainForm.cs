using Bottalino.model;
using Bottalino.service;
using Bottalino.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bottalino
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetUp();
        }

        private Ricetta GetRicetta()
        {

            Ricetta result = new Ricetta(this.maskedTextBoxId.Text);
            result.Speed = Int32.Parse(this.maskedTextBoxSpeed.Text);
            result.Temperature = Int32.Parse(this.maskedTextBoxTemperature.Text);
            result.Hours = Int32.Parse(this.maskedTextBoxHours.Text);
            result.Minutes = Int32.Parse(this.maskedTextBoxMinutes.Text);
            result.Seconds = Int32.Parse(this.maskedTextBoxSeconds.Text);

            result.NumberOfTimeCards = Int32.Parse(this.numericUpDownCards.Text);


            return result;
        }

        private string CreateInputFile(Ricetta ricetta)
        {
            string path = Directory.GetCurrentDirectory();
            string tmpFile = Utils.RandomString(10);

            string absoluteFilename = path + "/" + tmpFile + ".dat";
            InputFile.GenerateInputFile(absoluteFilename, ricetta);
            return absoluteFilename;
        }

        private void UploadInputFileToFtpServer(string localFileName)
        {
            string remoteFolder = Properties.Settings.Default.path;

            //string ftpHost = "ftp://" + Properties.Settings.Default.ftpHost + ":" + Properties.Settings.Default.port;
            string ftpHost = "ftp://" + Properties.Settings.Default.ftpHost;
            FtpClient ftpClient = new FtpClient(ftpHost, Properties.Settings.Default.username, Properties.Settings.Default.password);

            ftpClient.upload(remoteFolder + "ricetta.dat", localFileName);
            File.Delete(localFileName);
        }

        private async Task<bool> CheckStartJob()
        {
            string checkStartFile = "inizio.dat";
            string remoteFolder = Properties.Settings.Default.path;
            string ftpHost = "ftp://" + Properties.Settings.Default.ftpHost;
            FtpClient ftpClient = new FtpClient(ftpHost, Properties.Settings.Default.username, Properties.Settings.Default.password);
            bool isTheJobStarted = await IsRemoteFileCreated(checkStartFile, ftpClient, remoteFolder);
            if (isTheJobStarted)
            {               
                ftpClient.delete(remoteFolder + "/" + checkStartFile);
            }
            return isTheJobStarted;
        }

        private static async Task<bool> IsRemoteFileCreated(string checkStartFile, FtpClient ftpClient, string remoteFolder)
        {
            RemoteOperation remoteOperation = new RemoteOperation(ftpClient, remoteFolder);
            var isTheJobStarted = await remoteOperation.CheckJobStartAsync(checkStartFile);           
            return isTheJobStarted;
        }

        private async Task<bool> CheckEndJob()
        {
            string checkEndFile = "rapporto.dat";
            string remoteFolder = Properties.Settings.Default.path;
            string ftpHost = "ftp://" + Properties.Settings.Default.ftpHost;
            FtpClient ftpClient = new FtpClient(ftpHost, Properties.Settings.Default.username, Properties.Settings.Default.password);
            bool isTheJobStarted = await IsRemoteFileCreated(checkEndFile, ftpClient, remoteFolder);
            if (isTheJobStarted)
            {
                SaveRemoteFileLocally(ftpClient, remoteFolder, checkEndFile);
                ftpClient.delete(remoteFolder + "/" + checkEndFile);
                
                MessageBox messageBox = new MessageBox("Processo Bottalino finito !!!");
                messageBox.ShowDialog();
                
            }
            return isTheJobStarted;
        }

        private void SaveRemoteFileLocally(FtpClient ftpClient, string remoteFolder, string checkEndFile)
        {
            string localFolder = Properties.Settings.Default.serverPath;
            int Timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            string year = Utils.UnixToDate(Timestamp, "yyyy");
            string month = Utils.UnixToDate(Timestamp, "MM");
            string days = Utils.UnixToDate(Timestamp, "dd");
            string hours= Utils.UnixToDate(Timestamp, "HH");
            string minutes = Utils.UnixToDate(Timestamp, "mm");
            string seconds = Utils.UnixToDate(Timestamp, "ss");
            string folderOfToday = year + "\\" + month + "\\" + days;
            string fileName = year + "_" + month + "_" + days + "_" + hours + "_" + minutes + "_" + seconds + "_rapporto.dat";
            Directory.CreateDirectory(localFolder + "\\" + folderOfToday);
            ftpClient.download(remoteFolder + "/" + checkEndFile, localFolder + "\\" + folderOfToday + "\\" + fileName);
        }

        private void SetUp()
        {
            string randomString = Utils.RandomString(10);
            this.maskedTextBoxId.Text = randomString;
        }
           

        private void MainForm_Load(object sender, EventArgs e)
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config configForm = new Config();
            configForm.Show();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            button.Enabled = false;
            Ricetta ricetta = GetRicetta();
            string localFileName = CreateInputFile(ricetta);
            UploadInputFileToFtpServer(localFileName);
            bool isProcessStarted = await CheckStartJob();
            Console.WriteLine($"isProcessStarted: {isProcessStarted}");
            if (isProcessStarted)
            {
                MessageBox messageBox = new MessageBox("Processo Bottalino iniziato !!!");
                messageBox.ShowDialog();
            }
            bool isProcessEnded = await CheckEndJob();
            button.Enabled = true;
        }
    }
}
