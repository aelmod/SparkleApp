namespace p2p_client
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.formSkin1 = new FlatUI.FormSkin();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FileReceiverTextBox = new System.Windows.Forms.TextBox();
            this.TransmitterProgressBar = new FlatUI.FlatProgressBar();
            this.SendFileButton = new FlatUI.FlatButton();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.EnterIPTextBox = new System.Windows.Forms.TextBox();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.ReceiverProgressBar = new FlatUI.FlatProgressBar();
            this.ReceiverTextBox = new FlatUI.FlatTextBox();
            this.YourIPTextBox = new FlatUI.FlatTextBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chat_picture = new System.Windows.Forms.PictureBox();
            this.debug_picture = new System.Windows.Forms.PictureBox();
            this.settings_picture = new System.Windows.Forms.PictureBox();
            this.formSkin1.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chat_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debug_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.panel1);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.button1);
            this.formSkin1.Controls.Add(this.textBox1);
            this.formSkin1.Controls.Add(this.FileReceiverTextBox);
            this.formSkin1.Controls.Add(this.TransmitterProgressBar);
            this.formSkin1.Controls.Add(this.SendFileButton);
            this.formSkin1.Controls.Add(this.flatGroupBox2);
            this.formSkin1.Controls.Add(this.flatGroupBox1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(485, 373);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "p2p_client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // FileReceiverTextBox
            // 
            this.FileReceiverTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FileReceiverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileReceiverTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FileReceiverTextBox.Location = new System.Drawing.Point(3, 62);
            this.FileReceiverTextBox.Multiline = true;
            this.FileReceiverTextBox.Name = "FileReceiverTextBox";
            this.FileReceiverTextBox.ReadOnly = true;
            this.FileReceiverTextBox.Size = new System.Drawing.Size(229, 211);
            this.FileReceiverTextBox.TabIndex = 11;
            this.FileReceiverTextBox.Text = "Click here or Drag\'n\'Drop file here";
            this.FileReceiverTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransmitterProgressBar
            // 
            this.TransmitterProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.TransmitterProgressBar.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.TransmitterProgressBar.Location = new System.Drawing.Point(3, 317);
            this.TransmitterProgressBar.Maximum = 100;
            this.TransmitterProgressBar.Name = "TransmitterProgressBar";
            this.TransmitterProgressBar.Pattern = true;
            this.TransmitterProgressBar.PercentSign = false;
            this.TransmitterProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.TransmitterProgressBar.ShowBalloon = true;
            this.TransmitterProgressBar.Size = new System.Drawing.Size(229, 42);
            this.TransmitterProgressBar.TabIndex = 1;
            this.TransmitterProgressBar.Text = "flatProgressBar1";
            this.TransmitterProgressBar.Value = 0;
            // 
            // SendFileButton
            // 
            this.SendFileButton.BackColor = System.Drawing.Color.Transparent;
            this.SendFileButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.SendFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendFileButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SendFileButton.Location = new System.Drawing.Point(65, 285);
            this.SendFileButton.Name = "SendFileButton";
            this.SendFileButton.Rounded = false;
            this.SendFileButton.Size = new System.Drawing.Size(106, 32);
            this.SendFileButton.TabIndex = 2;
            this.SendFileButton.Text = "Send";
            this.SendFileButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.SendFileButton.Click += new System.EventHandler(this.SendFileButton_Click);
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox2.Controls.Add(this.EnterIPTextBox);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(259, 108);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(163, 76);
            this.flatGroupBox2.TabIndex = 9;
            this.flatGroupBox2.Text = "Enter here encripted IP:";
            // 
            // EnterIPTextBox
            // 
            this.EnterIPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.EnterIPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterIPTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EnterIPTextBox.Location = new System.Drawing.Point(26, 56);
            this.EnterIPTextBox.Name = "EnterIPTextBox";
            this.EnterIPTextBox.Size = new System.Drawing.Size(123, 18);
            this.EnterIPTextBox.TabIndex = 0;
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox1.Controls.Add(this.ReceiverProgressBar);
            this.flatGroupBox1.Controls.Add(this.ReceiverTextBox);
            this.flatGroupBox1.Controls.Add(this.YourIPTextBox);
            this.flatGroupBox1.Controls.Add(this.flatLabel2);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(261, 181);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(163, 181);
            this.flatGroupBox1.TabIndex = 7;
            this.flatGroupBox1.Text = "Receiver zone";
            // 
            // ReceiverProgressBar
            // 
            this.ReceiverProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ReceiverProgressBar.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.ReceiverProgressBar.Location = new System.Drawing.Point(23, 136);
            this.ReceiverProgressBar.Maximum = 100;
            this.ReceiverProgressBar.Name = "ReceiverProgressBar";
            this.ReceiverProgressBar.Pattern = true;
            this.ReceiverProgressBar.PercentSign = false;
            this.ReceiverProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.ReceiverProgressBar.ShowBalloon = true;
            this.ReceiverProgressBar.Size = new System.Drawing.Size(123, 42);
            this.ReceiverProgressBar.TabIndex = 3;
            this.ReceiverProgressBar.Text = "flatProgressBar2";
            this.ReceiverProgressBar.Value = 0;
            // 
            // ReceiverTextBox
            // 
            this.ReceiverTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ReceiverTextBox.FocusOnHover = false;
            this.ReceiverTextBox.Location = new System.Drawing.Point(23, 104);
            this.ReceiverTextBox.MaxLength = 32767;
            this.ReceiverTextBox.Multiline = false;
            this.ReceiverTextBox.Name = "ReceiverTextBox";
            this.ReceiverTextBox.ReadOnly = false;
            this.ReceiverTextBox.Size = new System.Drawing.Size(123, 29);
            this.ReceiverTextBox.TabIndex = 2;
            this.ReceiverTextBox.Text = "flatTextBox4";
            this.ReceiverTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReceiverTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReceiverTextBox.UseSystemPasswordChar = false;
            // 
            // YourIPTextBox
            // 
            this.YourIPTextBox.BackColor = System.Drawing.Color.Transparent;
            this.YourIPTextBox.FocusOnHover = false;
            this.YourIPTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.YourIPTextBox.Location = new System.Drawing.Point(23, 63);
            this.YourIPTextBox.MaxLength = 32767;
            this.YourIPTextBox.Multiline = false;
            this.YourIPTextBox.Name = "YourIPTextBox";
            this.YourIPTextBox.ReadOnly = true;
            this.YourIPTextBox.Size = new System.Drawing.Size(123, 31);
            this.YourIPTextBox.TabIndex = 1;
            this.YourIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YourIPTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.YourIPTextBox.UseSystemPasswordChar = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(35, 47);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(96, 13);
            this.flatLabel2.TabIndex = 0;
            this.flatLabel2.Text = "Your encripted IP:";
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(464, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(440, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(4, 324);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(106, 13);
            this.flatLabel1.TabIndex = 16;
            this.flatLabel1.Text = "Test mode enabled!";
            this.flatLabel1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.settings_picture);
            this.panel1.Controls.Add(this.chat_picture);
            this.panel1.Controls.Add(this.debug_picture);
            this.panel1.Location = new System.Drawing.Point(451, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 323);
            this.panel1.TabIndex = 17;
            // 
            // chat_picture
            // 
            this.chat_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.chat_picture.Image = ((System.Drawing.Image)(resources.GetObject("chat_picture.Image")));
            this.chat_picture.Location = new System.Drawing.Point(1, 3);
            this.chat_picture.Name = "chat_picture";
            this.chat_picture.Size = new System.Drawing.Size(32, 32);
            this.chat_picture.TabIndex = 14;
            this.chat_picture.TabStop = false;
            this.chat_picture.Click += new System.EventHandler(this.chat_picture_Click);
            // 
            // debug_picture
            // 
            this.debug_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.debug_picture.Image = global::p2p_client.Properties.Resources.code;
            this.debug_picture.Location = new System.Drawing.Point(1, 41);
            this.debug_picture.Name = "debug_picture";
            this.debug_picture.Size = new System.Drawing.Size(32, 32);
            this.debug_picture.TabIndex = 15;
            this.debug_picture.TabStop = false;
            this.debug_picture.Click += new System.EventHandler(this.debug_picture_Click);
            // 
            // settings_picture
            // 
            this.settings_picture.Image = global::p2p_client.Properties.Resources.cog_wheel_silhouette;
            this.settings_picture.Location = new System.Drawing.Point(1, 79);
            this.settings_picture.Name = "settings_picture";
            this.settings_picture.Size = new System.Drawing.Size(32, 32);
            this.settings_picture.TabIndex = 16;
            this.settings_picture.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 373);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.flatGroupBox2.ResumeLayout(false);
            this.flatGroupBox2.PerformLayout();
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chat_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debug_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatProgressBar ReceiverProgressBar;
        private FlatUI.FlatTextBox ReceiverTextBox;
        private FlatUI.FlatTextBox YourIPTextBox;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatGroupBox flatGroupBox2;
        public System.Windows.Forms.TextBox EnterIPTextBox;
        private FlatUI.FlatButton SendFileButton;
        private FlatUI.FlatProgressBar TransmitterProgressBar;
        private System.Windows.Forms.TextBox FileReceiverTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.PictureBox chat_picture;
        private System.Windows.Forms.PictureBox debug_picture;
        private FlatUI.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox settings_picture;
    }
}