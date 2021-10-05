using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alebrije.Abstractions.Enums
{
    public class Codes
    {
        [Flags]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceResult
        {
            /// <summary>
            /// 0000
            /// </summary>
            NotSet = 0,

            /// <summary>
            /// 0001
            /// </summary>
            WithData = 1 << 0,

            /// <summary>
            /// 0010
            /// </summary>
            Completed = 1 << 1,

            /// <summary>
            /// 0100
            /// </summary>
            WithErrors = 1 << 2,

            /// <summary>
            /// 1000
            /// </summary>
            Fatal = 1 << 3,

            /// <summary>
            /// 0011
            /// </summary>
            Success = WithData | Completed,

            /// <summary>
            /// 0110
            /// </summary>
            CompletedWithErrors = Completed | WithErrors
        }
    }
}