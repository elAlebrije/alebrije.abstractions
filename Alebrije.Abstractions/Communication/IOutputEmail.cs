using System.Net.Mail;

namespace Alebrije.Abstractions.Communication
{
    public interface IOutputEmail
    {
        MailAddress To { get; set; }
    }
}