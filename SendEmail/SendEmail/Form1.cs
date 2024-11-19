using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmail
{
    public partial class cmb : Form
    {
        private List<string> lstPathFile;
        private System.Windows.Forms.Timer emailTimer;
        private DateTime sendTime;
        private bool isTimerActive; 

        public cmb()
        {
            InitializeComponent();
            lstPathFile = new List<string>();

            emailTimer = new System.Windows.Forms.Timer();
            emailTimer.Interval = 1000; 
            emailTimer.Tick += EmailTimer_Tick;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Visible = false; 

            txtSetTime.CheckedChanged += txtSetTime_CheckedChanged;

            isTimerActive = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSetTime.Checked)
            {
                sendTime = dateTimePicker1.Value;

                if (sendTime <= DateTime.Now)
                {
                    MessageBox.Show("Thời gian đã chọn đã qua. Vui lòng chọn một thời gian trong tương lai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                emailTimer.Start();
                isTimerActive = true; 
                MessageBox.Show($"Email sẽ được gửi vào lúc {sendTime:dd/MM/yyyy HH:mm:ss}.", "Hẹn giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SendEmailAsync();
            }
        }

        private async void EmailTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= sendTime)
            {
                emailTimer.Stop();
                isTimerActive = false; 
                await SendEmailAsync();
            }
        }

        private async Task SendEmailAsync()
        {
            string from = txtEmailLog.Text.Trim();
            string to = txtReceiver.Text.Trim();
            string appPassword = txtPassword.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string content = txtContent.Text;

            if (string.IsNullOrWhiteSpace(from) || string.IsNullOrWhiteSpace(to) || string.IsNullOrWhiteSpace(appPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin email, mật khẩu, và người nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(from, appPassword);
                smtp.Timeout = 5000; 

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(from);
                    mail.To.Add(to);
                    mail.Subject = string.IsNullOrWhiteSpace(subject) ? "(Không có chủ đề)" : subject;
                    mail.Body = string.IsNullOrWhiteSpace(content) ? "(Không có nội dung)" : content;

                    if (!AddAttachments(mail)) return;

                    try
                    {
                        await smtp.SendMailAsync(mail);
                        MessageBox.Show("Email đã gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gửi email thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool AddAttachments(MailMessage mail)
        {
            long totalAttachmentSize = 0;
            foreach (string filePath in lstPathFile)
            {
                if (File.Exists(filePath))
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    totalAttachmentSize += fileInfo.Length;

                    if (totalAttachmentSize > 25 * 1024 * 1024)
                    {
                        MessageBox.Show("Tổng kích thước file đính kèm vượt quá giới hạn 25 MB.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    mail.Attachments.Add(new Attachment(filePath));
                }
                else
                {
                    MessageBox.Show($"File không tồn tại: {filePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Chọn file đính kèm",
                Filter = "All Files (*.*)|*.*",
                Multiselect = true,
                RestoreDirectory = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                lstPathFile.Clear();
                lstPathFile.AddRange(fileDialog.FileNames);
                btnChooseFile.Text = lstPathFile.Count == 1
                    ? Path.GetFileName(lstPathFile[0])
                    : $"{lstPathFile.Count} files selected";
            }
        }

        private void txtSetTime_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSetTime.Checked)
            {
                dateTimePicker1.Visible = true; 
                if (!isTimerActive)
                {
                    MessageBox.Show("Hẹn giờ đã bật. Email sẽ chỉ được gửi đúng giờ bạn đã chọn.", "Hẹn giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isTimerActive = true; 
                }
            }
            else
            {
                dateTimePicker1.Visible = false; 
                if (isTimerActive)
                {
                    emailTimer.Stop(); 
                    MessageBox.Show("Hẹn giờ đã tắt. Email sẽ gửi ngay lập tức khi bạn nhấn gửi.", "Hẹn giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isTimerActive = false; 
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
