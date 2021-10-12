using System.Threading.Tasks;

namespace Alebrije.Abstractions.Communication
{
    public interface IMailingService
    {
        Task SendEmailAsync(EmailContent emailInfo);

        Task SendTemplateEmailAsync(EmailTemplateContent emailInfo);
    }
}