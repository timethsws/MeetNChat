using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNChat.Server.Models
{
    /// <summary>
    /// Defines the data contract to attach operation result to a return value.
    /// </summary>
    /// <typeparam name="TOutput">The type of the return value.</typeparam>
    public class OperationOutput<TOutput> : OperationResult
    {
        /// <summary>
        /// Gets or sets the value returns from the operation.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public TOutput Value { get; set; }

        /// <summary>
        /// Create failed result with the specified messageCode.
        /// </summary>
        /// <returns>The failed output.</returns>
        /// <param name="messageCode">Message code.</param>
        public static new OperationOutput<TOutput> Failed(string messageCode, string aditonalInformation = null)
        {
            return new OperationOutput<TOutput>
            {
                MessageCode = messageCode,
                AdditionalInformation = aditonalInformation
            };
        }

        /// <summary>
        /// Success result with the specified result.
        /// </summary>
        /// <returns>The success result.</returns>
        /// <param name="result">The operation result.</param>
        public static OperationOutput<TOutput> Success(TOutput result)
        {
            return new OperationOutput<TOutput>
            {
                Status = true,
                Value = result
            };
        }
    }
}

}
