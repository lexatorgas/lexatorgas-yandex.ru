using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;

namespace Millenium.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Vacancies()
        {
            return View();
        }
        public IActionResult Objects()
        {
            return View();
        }

        public IActionResult Price()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string phoneNumber, string name)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("lexatorgas@gmail.com");
            message.To.Add(new MailAddress("rsk.millenium@gmail.com"));
            message.Subject = "Test";
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = $"Пришла заявка с сайта номер = {phoneNumber}, имя = {name}";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("lexatorgas@gmail.com", "1234usehon");
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Send(message);
            return View("Index");
        }
    }
}