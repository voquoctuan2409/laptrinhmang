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

        public cmb()
        {
            InitializeComponent();
            lstPathFile = new List<string>();

            // Khởi tạo Timer
            emailTimer = new System.Windows.Forms.Timer();
            emailTimer.Interval = 1000; // Kiểm tra mỗi giây
            emailTimer.Tick += EmailTimer_Tick;

            // Thiết lập DateTimePicker để chọn ngày
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.ShowUpDown = true;

            SetTimeControlsVisibility(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSetTime.Checked)
            {
                // Lấy giá trị ngày từ DateTimePicker và giờ, phút, giây từ TextBox
                DateTime selectedDate = dateTimePicker1.Value.Date;

                // Kiểm tra và gán giá trị mặc định nếu giờ, phút, giây bị bỏ trống
                int hours = string.IsNullOrWhiteSpace(txtHours.Text) ? 0 : int.Parse(txtHours.Text);
                int minutes = string.IsNullOrWhiteSpace(txtMinutes.Text) ? 0 : int.Parse(txtMinutes.Text);
                int seconds = string.IsNullOrWhiteSpace(txtSeconds.Text) ? 0 : int.Parse(txtSeconds.Text);

                try
                {
                    // Thiết lập thời gian gửi với ngày, giờ, phút, giây đã chọn
                    sendTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hours, minutes, seconds);

                    if (sendTime <= DateTime.Now)
                    {
                        MessageBox.Show("Thời gian đã chọn đã qua. Vui lòng chọn một thời gian trong tương lai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    emailTimer.Start();
                    MessageBox.Show($"Email sẽ được gửi vào lúc {sendTime:dd/MM/yyyy HH:mm:ss}.", "Hẹn giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập giờ, phút và giây hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                SendEmailAsync();
            }
        }

        private async void EmailTimer_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now >= sendTime)
    {
                emailTimer.Stop(); // Dừng timer trước khi gửi email để tránh gửi nhiều lần
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            bool isChecked = txtSetTime.Checked;
            SetTimeControlsVisibility(isChecked);

            if (!isChecked)
            {
                emailTimer.Stop();
                MessageBox.Show("Hẹn giờ đã tắt.", "Hẹn giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetTimeControlsVisibility(bool isVisible)
        {
            dateTimePicker1.Visible = isVisible;
            txtHours.Visible = isVisible;
            txtMinutes.Visible = isVisible;
            txtSeconds.Visible = isVisible;
            lblHours.Visible = isVisible;
            lblMinutes.Visible = isVisible;
            lblSeconds.Visible = isVisible;
        }
    }
}
