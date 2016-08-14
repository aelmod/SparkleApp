namespace p2p_client
{
    partial class chat
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
            this.ChatSendButton = new FlatUI.FlatButton();
            this.Receiver_TextBox = new System.Windows.Forms.TextBox();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.formSkin1 = new FlatUI.FormSkin();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatSendButton
            // 
            this.ChatSendButton.BackColor = System.Drawing.Color.Transparent;
            this.ChatSendButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.ChatSendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatSendButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChatSendButton.Location = new System.Drawing.Point(220, 289);
            this.ChatSendButton.Name = "ChatSendButton";
            this.ChatSendButton.Rounded = false;
            this.ChatSendButton.Size = new System.Drawing.Size(61, 72);
            this.ChatSendButton.TabIndex = 2;
            this.ChatSendButton.Text = "Send";
            this.ChatSendButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Receiver_TextBox
            // 
            this.Receiver_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Receiver_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Receiver_TextBox.Enabled = false;
            this.Receiver_TextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.Receiver_TextBox.Location = new System.Drawing.Point(3, 54);
            this.Receiver_TextBox.Multiline = true;
            this.Receiver_TextBox.Name = "Receiver_TextBox";
            this.Receiver_TextBox.ReadOnly = true;
            this.Receiver_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Receiver_TextBox.Size = new System.Drawing.Size(278, 229);
            this.Receiver_TextBox.TabIndex = 4;
            this.Receiver_TextBox.TabStop = false;
            this.Receiver_TextBox.TextChanged += new System.EventHandler(this.Receiver_TextBox_TextChanged);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ChatTextBox.Location = new System.Drawing.Point(3, 289);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(211, 71);
            this.ChatTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.textBox1);
            this.formSkin1.Controls.Add(this.button1);
            this.formSkin1.Controls.Add(this.ChatTextBox);
            this.formSkin1.Controls.Add(this.Receiver_TextBox);
            this.formSkin1.Controls.Add(this.ChatSendButton);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(284, 373);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "chat";
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 373);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1135, 353);
            this.Name = "chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "chat";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.chat_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatButton ChatSendButton;
        private System.Windows.Forms.TextBox Receiver_TextBox;
        private System.Windows.Forms.TextBox ChatTextBox;
        private FlatUI.FormSkin formSkin1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
    }
}