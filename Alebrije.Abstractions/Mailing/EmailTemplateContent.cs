using System.Collections.Generic;
using System.Net.Mail;

namespace Alebrije.Abstractions.Mailing
{
    public class EmailTemplateContent : IOutputEmail
    {
        public MailAddress To { get; set; }
        public string TemplateName { get; set; }
        public Dictionary<string, string> InputParams { get; set; } = new();
    }
}