using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Alebrije.Abstractions.Enums;

namespace Alebrije.Abstractions.Result
{
    // Moved near its interface to simplify casting
    /// <summary>
    /// IService Result Implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseServiceResult<T>
    {
        private T _data;
        public virtual T Data
        {
            get => _data;
            set
            {
                _data = value;
                if (_data != null)
                {
                    Code = Codes.ServiceResult.WithData;
                }
            }
        }

        private Codes.ServiceResult _code;
        public Codes.ServiceResult Code
        {
            get
            {
                if (Messages.Any(m => m.Type == Types.Message.Error))
                {
                    _code &= Codes.ServiceResult.WithErrors;
                }

                return _code;
            }
            set => _code = value;
        }

        private readonly List<ResultMessage> _messages = new();
        public ReadOnlyCollection<ResultMessage> Messages => _messages.AsReadOnly();

        public virtual void AddResultMessage(string message, Types.Message type = Types.Message.Result)
        {
            var msg = new ResultMessage
            {
                Type = type,
                Content = message
            };
            _messages.Add(msg);
        }

        public virtual void AddResultMessageCollection(IEnumerable<string> messages, Types.Message type = Types.Message.Result)
        {
            foreach (var message in messages)
            {
                var msg = new ResultMessage
                {
                    Type = type,
                    Content = message
                };
                _messages.Add(msg);
            }

        }
    }
}