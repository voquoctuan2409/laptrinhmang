using System.Net;
using System.Net.Mail;

namespace Send_email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, to, pass, content;
            from = txtSender.Text.Trim();
            to = txtReceiver.Text.Trim();
            pass = txtPass.Text.Trim();
            content = txtContent.Text;
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From=new MailAddress(from);
            mail.Subject = "Test send email";
            mail.Body=txtContent.Text;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod= SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Email send successfully","Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
