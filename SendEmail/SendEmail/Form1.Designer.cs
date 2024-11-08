namespace SendEmail
{
    partial class cmb
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            txtReceiver = new TextBox();
            txtEmailLog = new TextBox();
            txtPassword = new TextBox();
            txtContent = new TextBox();
            btnSend = new Button();
            btnClose = new Button();
            btnChooseFile = new Button();
            txtSetTime = new CheckBox();
            label1 = new Label();
            lblHours = new Label();
            lblSeconds = new Label();
            lblMinutes = new Label();
            txtSubject = new TextBox();
            txtHours = new TextBox();
            txtMinutes = new TextBox();
            txtSeconds = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Times New Roman", 15F);
            textBox1.Location = new Point(72, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 36);
            textBox1.TabIndex = 0;
            textBox1.Text = "Gửi đến:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 15F);
            textBox2.Location = new Point(72, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 36);
            textBox2.TabIndex = 1;
            textBox2.Text = "Email:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Times New Roman", 15F);
            textBox3.Location = new Point(72, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 36);
            textBox3.TabIndex = 2;
            textBox3.Text = "Mật khẩu:";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Times New Roman", 15F);
            textBox4.Location = new Point(72, 330);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 36);
            textBox4.TabIndex = 3;
            textBox4.Text = "Nội dung:";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtReceiver
            // 
            txtReceiver.BackColor = SystemColors.Control;
            txtReceiver.Cursor = Cursors.IBeam;
            txtReceiver.Font = new Font("Times New Roman", 15F);
            txtReceiver.Location = new Point(233, 114);
            txtReceiver.Name = "txtReceiver";
            txtReceiver.Size = new Size(688, 36);
            txtReceiver.TabIndex = 4;
            // 
            // txtEmailLog
            // 
            txtEmailLog.BackColor = SystemColors.Control;
            txtEmailLog.Cursor = Cursors.IBeam;
            txtEmailLog.Font = new Font("Times New Roman", 15F);
            txtEmailLog.Location = new Point(233, 165);
            txtEmailLog.Name = "txtEmailLog";
            txtEmailLog.Size = new Size(688, 36);
            txtEmailLog.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Times New Roman", 15F);
            txtPassword.Location = new Point(233, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(688, 36);
            txtPassword.TabIndex = 6;
            // 
            // txtContent
            // 
            txtContent.BackColor = SystemColors.Control;
            txtContent.Cursor = Cursors.IBeam;
            txtContent.Font = new Font("Times New Roman", 15F);
            txtContent.Location = new Point(233, 330);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(688, 182);
            txtContent.TabIndex = 8;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(192, 255, 192);
            btnSend.Cursor = Cursors.Hand;
            btnSend.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnSend.Location = new Point(357, 580);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(106, 60);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 255, 192);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            btnClose.Location = new Point(609, 580);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 60);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Cursor = Cursors.Hand;
            btnChooseFile.Font = new Font("Times New Roman", 10F);
            btnChooseFile.Location = new Point(729, 519);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(192, 34);
            btnChooseFile.TabIndex = 10;
            btnChooseFile.Text = "File đính kèm";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // txtSetTime
            // 
            txtSetTime.AutoSize = true;
            txtSetTime.Cursor = Cursors.Hand;
            txtSetTime.Font = new Font("Times New Roman", 13F);
            txtSetTime.Location = new Point(72, 395);
            txtSetTime.Name = "txtSetTime";
            txtSetTime.Size = new Size(103, 29);
            txtSetTime.TabIndex = 11;
            txtSetTime.Text = "Hẹn giờ";
            txtSetTime.UseVisualStyleBackColor = true;
            txtSetTime.CheckedChanged += txtSetTime_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Font = new Font("Times New Roman", 10F);
            lblHours.Location = new Point(149, 441);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(35, 19);
            lblHours.TabIndex = 15;
            lblHours.Text = "Giờ";
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.Font = new Font("Times New Roman", 10F);
            lblSeconds.Location = new Point(150, 517);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(41, 19);
            lblSeconds.TabIndex = 17;
            lblSeconds.Text = "Giây";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Font = new Font("Times New Roman", 10F);
            lblMinutes.Location = new Point(150, 478);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(40, 19);
            lblMinutes.TabIndex = 18;
            lblMinutes.Text = "Phút";
            // 
            // txtSubject
            // 
            txtSubject.BackColor = SystemColors.Control;
            txtSubject.Cursor = Cursors.IBeam;
            txtSubject.Font = new Font("Times New Roman", 15F);
            txtSubject.Location = new Point(233, 277);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(688, 36);
            txtSubject.TabIndex = 7;
            // 
            // txtHours
            // 
            txtHours.BackColor = SystemColors.Control;
            txtHours.BorderStyle = BorderStyle.FixedSingle;
            txtHours.Font = new Font("Times New Roman", 10F);
            txtHours.Location = new Point(72, 439);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(71, 27);
            txtHours.TabIndex = 20;
            txtHours.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMinutes
            // 
            txtMinutes.BackColor = SystemColors.Control;
            txtMinutes.BorderStyle = BorderStyle.FixedSingle;
            txtMinutes.Font = new Font("Times New Roman", 10F);
            txtMinutes.Location = new Point(72, 476);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(71, 27);
            txtMinutes.TabIndex = 21;
            txtMinutes.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSeconds
            // 
            txtSeconds.BackColor = SystemColors.Control;
            txtSeconds.BorderStyle = BorderStyle.FixedSingle;
            txtSeconds.Font = new Font("Times New Roman", 10F);
            txtSeconds.Location = new Point(72, 512);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(71, 27);
            txtSeconds.TabIndex = 22;
            txtSeconds.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Font = new Font("Times New Roman", 15F);
            textBox5.Location = new Point(72, 277);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 36);
            textBox5.TabIndex = 23;
            textBox5.Text = "Chủ đề:";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 17F, FontStyle.Bold);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(357, 33);
            label2.Name = "label2";
            label2.Size = new Size(313, 32);
            label2.TabIndex = 24;
            label2.Text = "MÀN HÌNH GỬI MAIL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 559);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // cmb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(982, 683);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(txtSeconds);
            Controls.Add(txtMinutes);
            Controls.Add(txtHours);
            Controls.Add(txtSubject);
            Controls.Add(lblMinutes);
            Controls.Add(lblSeconds);
            Controls.Add(lblHours);
            Controls.Add(txtSetTime);
            Controls.Add(btnChooseFile);
            Controls.Add(btnClose);
            Controls.Add(btnSend);
            Controls.Add(txtContent);
            Controls.Add(txtPassword);
            Controls.Add(txtEmailLog);
            Controls.Add(txtReceiver);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "cmb";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtReceiver;
        private TextBox txtEmailLog;
        private TextBox txtPassword;
        private TextBox txtContent;
        private Button btnSend;
        private Button btnClose;
        public Button btnChooseFile;
        private CheckBox txtSetTime;
        private Label label1;
        private Label lblHours;
        private Label lblSeconds;
        private Label lblMinutes;
        private TextBox txtSubject;
        private TextBox txtHours;
        private TextBox txtMinutes;
        private TextBox txtSeconds;
        private TextBox textBox5;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}
