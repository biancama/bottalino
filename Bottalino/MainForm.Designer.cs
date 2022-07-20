namespace Bottalino
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelId = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.maskedTextBoxId = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSpeed = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTemperature = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHours = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMinutes = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSeconds = new System.Windows.Forms.MaskedTextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCards = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCards)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(125, 79);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(79, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID Lavorazione";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(125, 122);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(45, 13);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "Velocita";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(125, 172);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(67, 13);
            this.labelTemperature.TabIndex = 5;
            this.labelTemperature.Text = "Temperatura";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(125, 222);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(39, 13);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Durata";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(296, 222);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(15, 13);
            this.labelH.TabIndex = 9;
            this.labelH.Text = "H";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(422, 222);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(16, 13);
            this.labelM.TabIndex = 11;
            this.labelM.Text = "M";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(531, 222);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(14, 13);
            this.labelSecond.TabIndex = 12;
            this.labelSecond.Text = "S";
            // 
            // maskedTextBoxId
            // 
            this.maskedTextBoxId.Location = new System.Drawing.Point(250, 76);
            this.maskedTextBoxId.Mask = "AAAAAAAAAA";
            this.maskedTextBoxId.Name = "maskedTextBoxId";
            this.maskedTextBoxId.Size = new System.Drawing.Size(114, 20);
            this.maskedTextBoxId.TabIndex = 2;
            // 
            // maskedTextBoxSpeed
            // 
            this.maskedTextBoxSpeed.Location = new System.Drawing.Point(250, 119);
            this.maskedTextBoxSpeed.Mask = "00";
            this.maskedTextBoxSpeed.Name = "maskedTextBoxSpeed";
            this.maskedTextBoxSpeed.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxSpeed.TabIndex = 4;
            this.maskedTextBoxSpeed.ValidatingType = typeof(int);
            // 
            // maskedTextBoxTemperature
            // 
            this.maskedTextBoxTemperature.Location = new System.Drawing.Point(250, 169);
            this.maskedTextBoxTemperature.Mask = "00";
            this.maskedTextBoxTemperature.Name = "maskedTextBoxTemperature";
            this.maskedTextBoxTemperature.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxTemperature.TabIndex = 6;
            this.maskedTextBoxTemperature.ValidatingType = typeof(int);
            // 
            // maskedTextBoxHours
            // 
            this.maskedTextBoxHours.Location = new System.Drawing.Point(248, 219);
            this.maskedTextBoxHours.Mask = "00";
            this.maskedTextBoxHours.Name = "maskedTextBoxHours";
            this.maskedTextBoxHours.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxHours.TabIndex = 8;
            this.maskedTextBoxHours.ValidatingType = typeof(int);
            // 
            // maskedTextBoxMinutes
            // 
            this.maskedTextBoxMinutes.Location = new System.Drawing.Point(377, 219);
            this.maskedTextBoxMinutes.Mask = "00";
            this.maskedTextBoxMinutes.Name = "maskedTextBoxMinutes";
            this.maskedTextBoxMinutes.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxMinutes.TabIndex = 10;
            this.maskedTextBoxMinutes.ValidatingType = typeof(int);
            // 
            // maskedTextBoxSeconds
            // 
            this.maskedTextBoxSeconds.Location = new System.Drawing.Point(481, 219);
            this.maskedTextBoxSeconds.Mask = "00";
            this.maskedTextBoxSeconds.Name = "maskedTextBoxSeconds";
            this.maskedTextBoxSeconds.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxSeconds.TabIndex = 11;
            this.maskedTextBoxSeconds.ValidatingType = typeof(int);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(295, 356);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.Text = "Invio";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero Cartellini";
            // 
            // numericUpDownCards
            // 
            this.numericUpDownCards.Location = new System.Drawing.Point(250, 278);
            this.numericUpDownCards.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCards.Name = "numericUpDownCards";
            this.numericUpDownCards.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCards.TabIndex = 14;
            this.numericUpDownCards.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(128, 405);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(494, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDownCards);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.maskedTextBoxSeconds);
            this.Controls.Add(this.maskedTextBoxMinutes);
            this.Controls.Add(this.maskedTextBoxHours);
            this.Controls.Add(this.maskedTextBoxTemperature);
            this.Controls.Add(this.maskedTextBoxSpeed);
            this.Controls.Add(this.maskedTextBoxId);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Global kem Bottalino";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSpeed;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTemperature;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHours;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMinutes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSeconds;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCards;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

