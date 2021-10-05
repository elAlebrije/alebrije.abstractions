using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alebrije.Abstractions.Enums
{
    public class Types
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public enum Error
        {
            /// <summary>
            /// Intended as System Errors, such as an exception.
            /// </summary>
            System,

            /// <summary>
            /// Intended as User Friendly/Handled Errors
            /// </summary>
            UserFriendly
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum Message
        {
            /// <summary>
            /// Developer messages
            /// </summary>
            Application,

            /// <summary>
            /// Represents an error, but not something that prevented the execution.
            /// </summary>
            Warning,

            /// <summary>
            /// Expected and handled error thrown by the execution.
            /// i.e. empty result list, duplicated record
            /// </summary>
            Error,

            /// <summary>
            /// Message that can be viewed by the User
            /// </summary>
            Result
        }
    }
}