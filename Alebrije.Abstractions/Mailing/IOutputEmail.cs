using System.Net.Mail;

namespace Alebrije.Abstractions.Mailing
{
    public interface IOutputEmail
    {
        MailAddress To { get; set; }
    }
}