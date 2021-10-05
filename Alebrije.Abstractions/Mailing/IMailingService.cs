using System.Threading.Tasks;

namespace Alebrije.Abstractions.Mailing
{
    public interface IMailingService
    {
        Task SendEmailAsync(EmailContent emailInfo);

        Task SendTemplateEmailAsync(EmailTemplateContent emailInfo);
    }
}