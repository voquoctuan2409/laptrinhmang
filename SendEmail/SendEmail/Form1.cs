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
        private int countdownTime; // Thời gian đếm ngược tính bằng giây

        public cmb()
        {
            InitializeComponent();
            lstPathFile = new List<string>();

            // Khởi tạo Timer
            emailTimer = new System.Windows.Forms.Timer();
            emailTimer.Interval = 1000; // 1 giây
            emailTimer.Tick += EmailTimer_Tick;

            SetTimeControlsVisibility(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSetTime.Checked)
            {
                // Kiểm tra và lấy giá trị thời gian từ các ô giờ, phút, giây
                int hours = 0, minutes = 0, seconds = 0;

                // Nếu ô giờ không trống, lấy giá trị, nếu không mặc định là 0
                if (!string.IsNullOrWhiteSpace(txtHours.Text) && int.TryParse(txtHours.Text, out int parsedHours) && parsedHours >= 0 && parsedHours <= 23)
                {
                    hours = parsedHours;
                }

                // Nếu ô phút không trống, lấy giá trị, nếu không mặc định là 0
                if (!string.IsNullOrWhiteSpace(txtMinutes.Text) && int.TryParse(txtMinutes.Text, out int parsedMinutes) && parsedMinutes >= 0 && parsedMinutes <= 59)
                {
                    minutes = parsedMinutes;
                }

                // Kiểm tra ô giây và đảm bảo người dùng nhập giá trị hợp lệ
                if (int.TryParse(txtSeconds.Text, out int parsedSeconds) && parsedSeconds >= 0 && parsedSeconds <= 59)
                {
                    seconds = parsedSeconds;
                }
                else
                {
                    MessageBox.Show("Hãy nhập giá trị hợp lệ cho giây.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                // Tính tổng thời gian đếm ngược tính bằng giây
                countdownTime = hours * 3600 + minutes * 60 + seconds;

                if (countdownTime > 0)
                {
                    emailTimer.Start(); // Bắt đầu đếm ngược
                    MessageBox.Show($"Đếm ngược {countdownTime} giây bắt đầu. Email sẽ được gửi sau khi thời gian đếm ngược kết thúc.", "Hẹn giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thời gian hợp lệ lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Nếu không bật hẹn giờ, gửi email ngay lập tức
                SendEmailAsync();
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

        private async void EmailTimer_Tick(object sender, EventArgs e)
        {
            countdownTime--; // Giảm thời gian đếm ngược mỗi giây
            if (countdownTime <= 0)
            {
                emailTimer.Stop(); // Dừng timer khi đếm ngược kết thúc
                await SendEmailAsync(); // Gửi email khi hết thời gian đếm ngược
            }
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
            txtHours.Visible = isVisible;
            txtMinutes.Visible = isVisible;
            txtSeconds.Visible = isVisible;
            lblHours.Visible = isVisible;
            lblMinutes.Visible = isVisible;
            lblSeconds.Visible = isVisible;
        }
    }
}
