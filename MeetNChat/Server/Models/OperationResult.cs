using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetNChat.Server.Models
{
    /// <summary>
    /// Defines the data contract to hold the result of a service operation.
    /// </summary>
    public class OperationResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether the given operation is a success.
        /// </summary>
        /// <value>
        /// <c>true</c> if the operation is success; otherwise, <c>false</c>.
        /// </value>
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets the error message code in case of an operation error.
        /// </summary>
        /// <value>
        /// The message code.
        /// </value>
        public string MessageCode { get; set; }

        /// <summary>
        /// Gets or sets the additional information related to the operation result.
        /// </summary>
        /// <value>
        /// The additional information related to the operation result.
        /// </value>
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>The count.</value>
        public int TotalCount { get; set; }

        /// <summary>
        /// Create failed result with the specified messageCode.
        /// </summary>
        /// <returns>The failed output.</returns>
        /// <param name="messageCode">Message code.</param>
        public static OperationResult Failed(string messageCode)
        {
            return Failed(messageCode, null);
        }

        /// <summary>
        /// Failed result with the specified messageCode and additionalInfo.
        /// </summary>
        /// <returns>The failed result.</returns>
        /// <param name="messageCode">Message code.</param>
        /// <param name="additionalInfo">Additional info.</param>
        public static OperationResult Failed(string messageCode, string additionalInfo)
        {
            return new OperationResult
            {
                Status = false,
                MessageCode = messageCode,
                AdditionalInformation = additionalInfo
            };
        }

        /// <summary>
        /// Success result with the optional messageCode.
        /// </summary>
        /// <returns>The success result.</returns>
        /// <param name="messageCode">Message code (Optional).</param>
        public static OperationResult Success(string messageCode = null)
        {
            return new OperationResult
            {
                Status = true,
                MessageCode = messageCode
            };
        }
    }

}
