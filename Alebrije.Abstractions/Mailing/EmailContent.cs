using System.Net.Mail;

namespace Alebrije.Abstractions.Mailing
{
    public class EmailContent : IOutputEmail
    {
        public MailAddress To { get; set; }
        public string Subject { get; set; }
        public string PlainText { get; set; }
        public string HtmlContent { get; set; }
    }
}