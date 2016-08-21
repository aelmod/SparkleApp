namespace p2p_client
{
    partial class chat2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatClose1 = new FlatUI.FlatClose();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatMini1 = new FlatUI.FlatMini();
            this.Receiver_TextBox = new System.Windows.Forms.TextBox();
            this.ChatSendButton = new System.Windows.Forms.Button();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.flatClose1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flatMini1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 38);
            this.panel1.TabIndex = 0;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(254, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 4;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sparkle Chat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SparkleApp.Properties.Resources.comments_24;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(230, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Receiver_TextBox
            // 
            this.Receiver_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Receiver_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Receiver_TextBox.Enabled = false;
            this.Receiver_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Receiver_TextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Receiver_TextBox.Location = new System.Drawing.Point(4, 42);
            this.Receiver_TextBox.Multiline = true;
            this.Receiver_TextBox.Name = "Receiver_TextBox";
            this.Receiver_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Receiver_TextBox.Size = new System.Drawing.Size(277, 243);
            this.Receiver_TextBox.TabIndex = 4;
            // 
            // ChatSendButton
            // 
            this.ChatSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ChatSendButton.FlatAppearance.BorderSize = 0;
            this.ChatSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatSendButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatSendButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChatSendButton.Location = new System.Drawing.Point(231, 290);
            this.ChatSendButton.Name = "ChatSendButton";
            this.ChatSendButton.Size = new System.Drawing.Size(50, 71);
            this.ChatSendButton.TabIndex = 5;
            this.ChatSendButton.Text = "SEND";
            this.ChatSendButton.UseVisualStyleBackColor = false;
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatTextBox.Location = new System.Drawing.Point(4, 290);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(221, 71);
            this.ChatTextBox.TabIndex = 6;
            // 
            // chat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(284, 366);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.ChatSendButton);
            this.Controls.Add(this.Receiver_TextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chat2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "chat2";
            this.Load += new System.EventHandler(this.chat2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatMini flatMini1;
        private System.Windows.Forms.TextBox Receiver_TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ChatSendButton;
        private System.Windows.Forms.Label label1;
        private FlatUI.FlatClose flatClose1;
        private System.Windows.Forms.TextBox ChatTextBox;
    }
}