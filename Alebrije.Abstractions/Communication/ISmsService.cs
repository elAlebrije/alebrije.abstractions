using System.Threading.Tasks;

namespace Alebrije.Abstractions.Communication
{
    public interface ISmsService
    {
        Task SendSimpleSmsAsync(string toPhoneNumber, string content);
    }
}