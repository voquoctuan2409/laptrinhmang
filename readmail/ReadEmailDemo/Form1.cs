using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ReadEmailDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string emailContent = email.Text;
            string passwordContent = password.Text;
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            try
            {
                // Tạo client IMAP và kết nối
                using (var client = new ImapClient())
                {
                    // Kết nối đến máy chủ IMAP
                    await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    // Đăng nhập vào tài khoản
                    await client.AuthenticateAsync(emailContent, passwordContent);

                    // Mở thư mục hộp thư đến
                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    // Tìm kiếm email trong khoảng thời gian nhất định
                    var uids = await inbox.SearchAsync(SearchQuery.DeliveredAfter(startDate)
                                                           .And(SearchQuery.DeliveredBefore(endDate)));

                    // Lấy thông tin email
                    List<EmailInfo> emailList = new List<EmailInfo>();
                    foreach (var uid in uids)
                    {
                        var message = await inbox.GetMessageAsync(uid);
                        emailList.Add(new EmailInfo
                        {
                            From = message.From.ToString(),
                            Subject = message.Subject,
                            TimeReceive = message.Date
                        });
                    }

                    // Thiết lập DataGridView
                    this.dataGridView1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    dataGridView1.DataSource = emailList;
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                    dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
                    
                    // Đóng kết nối
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Định nghĩa lớp EmailInfo để sử dụng làm nguồn dữ liệu cho DataGridView
        public class EmailInfo
        {
            public string From { get; set; }
            public string Subject { get; set; }
            public DateTimeOffset TimeReceive { get; set; }
        }

    }
}
