namespace Send_email
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtReceiver = new TextBox();
            txtSender = new TextBox();
            label2 = new Label();
            txtContent = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            btnSend = new Button();
            btnClose = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(152, 101);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 0;
            label1.Text = "Receiver";
            // 
            // txtReceiver
            // 
            txtReceiver.Location = new Point(261, 97);
            txtReceiver.Name = "txtReceiver";
            txtReceiver.Size = new Size(323, 27);
            txtReceiver.TabIndex = 1;
            // 
            // txtSender
            // 
            txtSender.Location = new Point(261, 130);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(323, 27);
            txtSender.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(152, 134);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "Sender";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(261, 196);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(323, 180);
            txtContent.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(152, 196);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 4;
            label3.Text = "Content";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(261, 163);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(323, 27);
            txtPass.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(152, 163);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSend.Location = new Point(297, 405);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 51);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.Location = new Point(440, 405);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 51);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(323, 21);
            label5.Name = "label5";
            label5.Size = new Size(183, 37);
            label5.TabIndex = 10;
            label5.Text = "SEND EMAIL ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 510);
            Controls.Add(label5);
            Controls.Add(btnClose);
            Controls.Add(btnSend);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtContent);
            Controls.Add(label3);
            Controls.Add(txtSender);
            Controls.Add(label2);
            Controls.Add(txtReceiver);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtReceiver;
        private TextBox txtSender;
        private Label label2;
        private TextBox txtContent;
        private Label label3;
        private TextBox txtPass;
        private Label label4;
        private Button btnSend;
        private Button btnClose;
        private Label label5;
    }
}
