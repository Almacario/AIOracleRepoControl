namespace artInstallation
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.virtualConsole = new System.Windows.Forms.RichTextBox();
            this.listPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textPort = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelConsole = new System.Windows.Forms.Label();
            this.listMusic = new System.Windows.Forms.ListBox();
            this.addMusicBtn = new System.Windows.Forms.Button();
            this.delMusicBtn = new System.Windows.Forms.Button();
            this.lightsBtn = new System.Windows.Forms.Button();
            this.motorBtn = new System.Windows.Forms.Button();
            this.smokeBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnRandom = new System.Windows.Forms.Button();
            this.stateBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSensor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // virtualConsole
            // 
            this.virtualConsole.BackColor = System.Drawing.SystemColors.MenuText;
            this.virtualConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.virtualConsole.Location = new System.Drawing.Point(14, 196);
            this.virtualConsole.Name = "virtualConsole";
            this.virtualConsole.Size = new System.Drawing.Size(356, 251);
            this.virtualConsole.TabIndex = 0;
            this.virtualConsole.Text = "(no input data. select port and connect)";
            this.virtualConsole.TextChanged += new System.EventHandler(this.virtualConsole_TextChanged);
            // 
            // listPorts
            // 
            this.listPorts.FormattingEnabled = true;
            this.listPorts.Location = new System.Drawing.Point(12, 24);
            this.listPorts.Name = "listPorts";
            this.listPorts.Size = new System.Drawing.Size(121, 21);
            this.listPorts.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(139, 24);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textPort
            // 
            this.textPort.AutoSize = true;
            this.textPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPort.Location = new System.Drawing.Point(12, 12);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(78, 9);
            this.textPort.TabIndex = 3;
            this.textPort.Text = "ARDUINO PORT";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(139, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsole.Location = new System.Drawing.Point(14, 184);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(82, 9);
            this.labelConsole.TabIndex = 5;
            this.labelConsole.Text = "USB DATA FLOW";
            // 
            // listMusic
            // 
            this.listMusic.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.listMusic.FormattingEnabled = true;
            this.listMusic.Items.AddRange(new object[] {
            "Track 1",
            "Track 2",
            "Track 3"});
            this.listMusic.Location = new System.Drawing.Point(405, 307);
            this.listMusic.Name = "listMusic";
            this.listMusic.ScrollAlwaysVisible = true;
            this.listMusic.Size = new System.Drawing.Size(333, 121);
            this.listMusic.TabIndex = 6;
            this.listMusic.SelectedIndexChanged += new System.EventHandler(this.listMusic_SelectedIndexChanged);
            this.listMusic.DoubleClick += new System.EventHandler(this.listMusic_DoubleClick);
            // 
            // addMusicBtn
            // 
            this.addMusicBtn.Location = new System.Drawing.Point(405, 430);
            this.addMusicBtn.Name = "addMusicBtn";
            this.addMusicBtn.Size = new System.Drawing.Size(116, 23);
            this.addMusicBtn.TabIndex = 7;
            this.addMusicBtn.Text = "ADD TRACK";
            this.addMusicBtn.UseVisualStyleBackColor = true;
            this.addMusicBtn.Click += new System.EventHandler(this.addMusicBtn_Click);
            // 
            // delMusicBtn
            // 
            this.delMusicBtn.Location = new System.Drawing.Point(621, 430);
            this.delMusicBtn.Name = "delMusicBtn";
            this.delMusicBtn.Size = new System.Drawing.Size(117, 23);
            this.delMusicBtn.TabIndex = 8;
            this.delMusicBtn.Text = "REMOVE TRACK";
            this.delMusicBtn.UseVisualStyleBackColor = true;
            this.delMusicBtn.Click += new System.EventHandler(this.delMusicBtn_Click);
            // 
            // lightsBtn
            // 
            this.lightsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightsBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lightsBtn.Location = new System.Drawing.Point(12, 70);
            this.lightsBtn.Name = "lightsBtn";
            this.lightsBtn.Size = new System.Drawing.Size(139, 43);
            this.lightsBtn.TabIndex = 9;
            this.lightsBtn.Text = "LIGHTS TEST";
            this.lightsBtn.UseVisualStyleBackColor = true;
            this.lightsBtn.Click += new System.EventHandler(this.lightsBtn_Click);
            // 
            // motorBtn
            // 
            this.motorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.motorBtn.Location = new System.Drawing.Point(157, 70);
            this.motorBtn.Name = "motorBtn";
            this.motorBtn.Size = new System.Drawing.Size(142, 43);
            this.motorBtn.TabIndex = 10;
            this.motorBtn.Text = "MOTORS TEST";
            this.motorBtn.UseVisualStyleBackColor = true;
            this.motorBtn.Click += new System.EventHandler(this.motorBtn_Click);
            // 
            // smokeBtn
            // 
            this.smokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smokeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.smokeBtn.Location = new System.Drawing.Point(12, 119);
            this.smokeBtn.Name = "smokeBtn";
            this.smokeBtn.Size = new System.Drawing.Size(139, 42);
            this.smokeBtn.TabIndex = 11;
            this.smokeBtn.Text = "SMOKE TEST";
            this.smokeBtn.UseVisualStyleBackColor = true;
            this.smokeBtn.Click += new System.EventHandler(this.smokeBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startBtn.Location = new System.Drawing.Point(405, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(333, 68);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "START/STOP";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(405, 196);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(333, 105);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(527, 430);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(88, 22);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "SHUFFLE";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // stateBox
            // 
            this.stateBox.BackColor = System.Drawing.SystemColors.Window;
            this.stateBox.ForeColor = System.Drawing.Color.Black;
            this.stateBox.Location = new System.Drawing.Point(405, 93);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(333, 97);
            this.stateBox.TabIndex = 31;
            this.stateBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 9);
            this.label1.TabIndex = 32;
            this.label1.Text = "PROGRAM STATE";
            // 
            // btnSensor
            // 
            this.btnSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSensor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSensor.Location = new System.Drawing.Point(157, 118);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(142, 43);
            this.btnSensor.TabIndex = 33;
            this.btnSensor.Text = "SENSOR TEST";
            this.btnSensor.UseVisualStyleBackColor = true;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 459);
            this.Controls.Add(this.btnSensor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.smokeBtn);
            this.Controls.Add(this.motorBtn);
            this.Controls.Add(this.lightsBtn);
            this.Controls.Add(this.delMusicBtn);
            this.Controls.Add(this.addMusicBtn);
            this.Controls.Add(this.listMusic);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.listPorts);
            this.Controls.Add(this.virtualConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "artisticApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox virtualConsole;
        private System.Windows.Forms.ComboBox listPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label textPort;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.ListBox listMusic;
        private System.Windows.Forms.Button addMusicBtn;
        private System.Windows.Forms.Button delMusicBtn;
        private System.Windows.Forms.Button lightsBtn;
        private System.Windows.Forms.Button motorBtn;
        private System.Windows.Forms.Button smokeBtn;
        private System.Windows.Forms.Button startBtn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.RichTextBox stateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSensor;
    }
}

