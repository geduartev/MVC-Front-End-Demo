using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class SendEmailController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Email _objModelMail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();

                mail.To.Add(_objModelMail.To);
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;

                string Body = _objModelMail.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.outlook.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("email@email.com", "password");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                return View("Index", _objModelMail);
            }

            return View("Index");
        }
    }
}
