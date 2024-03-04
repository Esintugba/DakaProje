using MailKit.Net.Smtp;
using Mekel.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace Mekel.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Mail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Mail(AdminMailViewModel model) // Change the parameter type to AdminMailViewModel
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("MekelAdmin", "esintugbad@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail); // Correct property name
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("esintugbad@gmail.com", "mzcfguvsztagykzh");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
