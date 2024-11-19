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
            txtSubject = new TextBox();
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
            textBox1.Location = new Point(119, 117);
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
            textBox2.Location = new Point(119, 165);
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
            textBox3.Location = new Point(119, 222);
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
            textBox4.Location = new Point(119, 330);
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
            txtReceiver.Location = new Point(323, 117);
            txtReceiver.Name = "txtReceiver";
            txtReceiver.Size = new Size(688, 36);
            txtReceiver.TabIndex = 4;
            // 
            // txtEmailLog
            // 
            txtEmailLog.BackColor = SystemColors.Control;
            txtEmailLog.Cursor = Cursors.IBeam;
            txtEmailLog.Font = new Font("Times New Roman", 15F);
            txtEmailLog.Location = new Point(323, 165);
            txtEmailLog.Name = "txtEmailLog";
            txtEmailLog.Size = new Size(688, 36);
            txtEmailLog.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Times New Roman", 15F);
            txtPassword.Location = new Point(323, 222);
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
            txtContent.Location = new Point(323, 330);
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
            btnSend.Location = new Point(472, 573);
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
            btnClose.Location = new Point(712, 573);
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
            btnChooseFile.Font = new Font("Times New Roman", 11F);
            btnChooseFile.Location = new Point(785, 518);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(226, 40);
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
            txtSetTime.Location = new Point(119, 395);
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
            // txtSubject
            // 
            txtSubject.BackColor = SystemColors.Control;
            txtSubject.Cursor = Cursors.IBeam;
            txtSubject.Font = new Font("Times New Roman", 15F);
            txtSubject.Location = new Point(323, 277);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(688, 36);
            txtSubject.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Font = new Font("Times New Roman", 15F);
            textBox5.Location = new Point(119, 277);
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
            label2.Location = new Point(486, 42);
            label2.Name = "label2";
            label2.Size = new Size(313, 32);
            label2.TabIndex = 24;
            label2.Text = "MÀN HÌNH GỬI MAIL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Times New Roman", 13F);
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.Font = new Font("Times New Roman", 13F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(57, 430);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 32);
            dateTimePicker1.TabIndex = 25;
            // 
            // cmb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1182, 683);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(txtSubject);
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
        private TextBox txtSubject;
        private TextBox textBox5;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}
