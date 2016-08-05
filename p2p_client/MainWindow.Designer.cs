﻿namespace p2p_client
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.EnterIPTextBox = new FlatUI.FlatTextBox();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SendFileButton = new FlatUI.FlatButton();
            this.TransmitterProgressBar = new FlatUI.FlatProgressBar();
            this.FileReceiverTextBox = new FlatUI.FlatTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChatSendButton = new FlatUI.FlatButton();
            this.ChatText_TextBox = new FlatUI.FlatTextBox();
            this.ChatTextBox = new FlatUI.FlatTextBox();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.ReceiverProgressBar = new FlatUI.FlatProgressBar();
            this.ReceiverTextBox = new FlatUI.FlatTextBox();
            this.YourIPTextBox = new FlatUI.FlatTextBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.formSkin1.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatGroupBox2);
            this.formSkin1.Controls.Add(this.flatTabControl1);
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
            this.formSkin1.Size = new System.Drawing.Size(768, 380);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "p2p_client";
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox2.Controls.Add(this.EnterIPTextBox);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(602, 62);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(163, 92);
            this.flatGroupBox2.TabIndex = 9;
            this.flatGroupBox2.Text = "Enter here encripted IP:";
            // 
            // EnterIPTextBox
            // 
            this.EnterIPTextBox.BackColor = System.Drawing.Color.Transparent;
            this.EnterIPTextBox.FocusOnHover = false;
            this.EnterIPTextBox.Location = new System.Drawing.Point(22, 60);
            this.EnterIPTextBox.MaxLength = 32767;
            this.EnterIPTextBox.Multiline = false;
            this.EnterIPTextBox.Name = "EnterIPTextBox";
            this.EnterIPTextBox.ReadOnly = false;
            this.EnterIPTextBox.Size = new System.Drawing.Size(123, 29);
            this.EnterIPTextBox.TabIndex = 0;
            this.EnterIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EnterIPTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EnterIPTextBox.UseSystemPasswordChar = false;
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(6, 62);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(593, 304);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.SendFileButton);
            this.tabPage1.Controls.Add(this.TransmitterProgressBar);
            this.tabPage1.Controls.Add(this.FileReceiverTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transmitter";
            // 
            // SendFileButton
            // 
            this.SendFileButton.BackColor = System.Drawing.Color.Transparent;
            this.SendFileButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.SendFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendFileButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SendFileButton.Location = new System.Drawing.Point(238, 139);
            this.SendFileButton.Name = "SendFileButton";
            this.SendFileButton.Rounded = false;
            this.SendFileButton.Size = new System.Drawing.Size(106, 32);
            this.SendFileButton.TabIndex = 2;
            this.SendFileButton.Text = "Send";
            this.SendFileButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.SendFileButton.Click += new System.EventHandler(this.SendFileButton_Click);
            // 
            // TransmitterProgressBar
            // 
            this.TransmitterProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.TransmitterProgressBar.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.TransmitterProgressBar.Location = new System.Drawing.Point(6, 183);
            this.TransmitterProgressBar.Maximum = 100;
            this.TransmitterProgressBar.Name = "TransmitterProgressBar";
            this.TransmitterProgressBar.Pattern = true;
            this.TransmitterProgressBar.PercentSign = false;
            this.TransmitterProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.TransmitterProgressBar.ShowBalloon = true;
            this.TransmitterProgressBar.Size = new System.Drawing.Size(573, 42);
            this.TransmitterProgressBar.TabIndex = 1;
            this.TransmitterProgressBar.Text = "flatProgressBar1";
            this.TransmitterProgressBar.Value = 0;
            // 
            // FileReceiverTextBox
            // 
            this.FileReceiverTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FileReceiverTextBox.FocusOnHover = false;
            this.FileReceiverTextBox.Location = new System.Drawing.Point(6, 79);
            this.FileReceiverTextBox.MaxLength = 32767;
            this.FileReceiverTextBox.Multiline = false;
            this.FileReceiverTextBox.Name = "FileReceiverTextBox";
            this.FileReceiverTextBox.ReadOnly = true;
            this.FileReceiverTextBox.Size = new System.Drawing.Size(573, 29);
            this.FileReceiverTextBox.TabIndex = 0;
            this.FileReceiverTextBox.Text = "Click here or Drag\'n\'Drop file here";
            this.FileReceiverTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileReceiverTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FileReceiverTextBox.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.ChatSendButton);
            this.tabPage2.Controls.Add(this.ChatText_TextBox);
            this.tabPage2.Controls.Add(this.ChatTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chat";
            // 
            // ChatSendButton
            // 
            this.ChatSendButton.BackColor = System.Drawing.Color.Transparent;
            this.ChatSendButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.ChatSendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatSendButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChatSendButton.Location = new System.Drawing.Point(496, 183);
            this.ChatSendButton.Name = "ChatSendButton";
            this.ChatSendButton.Rounded = false;
            this.ChatSendButton.Size = new System.Drawing.Size(83, 67);
            this.ChatSendButton.TabIndex = 2;
            this.ChatSendButton.Text = "Send";
            this.ChatSendButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ChatSendButton.Click += new System.EventHandler(this.ChatSendButton_Click);
            // 
            // ChatText_TextBox
            // 
            this.ChatText_TextBox.BackColor = System.Drawing.Color.Transparent;
            this.ChatText_TextBox.FocusOnHover = false;
            this.ChatText_TextBox.Location = new System.Drawing.Point(6, 183);
            this.ChatText_TextBox.MaxLength = 32767;
            this.ChatText_TextBox.Multiline = true;
            this.ChatText_TextBox.Name = "ChatText_TextBox";
            this.ChatText_TextBox.ReadOnly = false;
            this.ChatText_TextBox.Size = new System.Drawing.Size(484, 67);
            this.ChatText_TextBox.TabIndex = 1;
            this.ChatText_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChatText_TextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChatText_TextBox.UseSystemPasswordChar = false;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ChatTextBox.FocusOnHover = false;
            this.ChatTextBox.Location = new System.Drawing.Point(6, 6);
            this.ChatTextBox.MaxLength = 32767;
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.Size = new System.Drawing.Size(573, 165);
            this.ChatTextBox.TabIndex = 0;
            this.ChatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChatTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ChatTextBox.UseSystemPasswordChar = false;
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
            this.flatGroupBox1.Location = new System.Drawing.Point(601, 185);
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
            this.YourIPTextBox.Location = new System.Drawing.Point(23, 63);
            this.YourIPTextBox.MaxLength = 32767;
            this.YourIPTextBox.Multiline = false;
            this.YourIPTextBox.Name = "YourIPTextBox";
            this.YourIPTextBox.ReadOnly = true;
            this.YourIPTextBox.Size = new System.Drawing.Size(123, 29);
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
            this.flatClose1.Location = new System.Drawing.Point(738, 12);
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
            this.flatMini1.Location = new System.Drawing.Point(714, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 380);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.flatGroupBox2.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatProgressBar ReceiverProgressBar;
        private FlatUI.FlatTextBox ReceiverTextBox;
        private FlatUI.FlatTextBox YourIPTextBox;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatTextBox EnterIPTextBox;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FlatUI.FlatButton SendFileButton;
        private FlatUI.FlatProgressBar TransmitterProgressBar;
        private FlatUI.FlatTextBox FileReceiverTextBox;
        private FlatUI.FlatButton ChatSendButton;
        private FlatUI.FlatTextBox ChatText_TextBox;
        private FlatUI.FlatTextBox ChatTextBox;
    }
}