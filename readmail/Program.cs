using System;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;

class Program
{
    static async Task Main(string[] args)
    {
        
        string email = "";
        string password = "gygd jryq wvgv fjmd";

        using (var client = new ImapClient())
        {
        
            await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);

          
            await client.AuthenticateAsync(email, password);

           
            var inbox = client.Inbox;
            await inbox.OpenAsync(FolderAccess.ReadOnly);

            
            Console.WriteLine($"Total messages: {inbox.Count}");
            Console.WriteLine($"Recent messages: {inbox.Recent}");

            for (int i = 0; i < inbox.Count; i++)
            {
                var message = await inbox.GetMessageAsync(i);
                Console.WriteLine($"Subject: {message.Subject}");
                Console.WriteLine($"From: {message.From}");
                Console.WriteLine($"Date: {message.Date}");
                Console.WriteLine($"Body: {message.TextBody}");
                Console.WriteLine(new string('-', 50));
            }

            // Đăng xuất
            await client.DisconnectAsync(true);
        }
    }
}
