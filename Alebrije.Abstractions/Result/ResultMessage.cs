using Alebrije.Abstractions.Enums;

namespace Alebrije.Abstractions.Result
{
    public struct ResultMessage
    {
        public Types.Message Type { get; set; }
        public string Content { get; set; }
    }
}