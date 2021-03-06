﻿/*
 * @file:RequestFailedException
 * @brief: Initializes a new instance of the <see cref="RequestFailedException"/> class.
 * @credit:https://github.com/Microsoft/UWPCommunityToolkit 
 */

using System;
using Windows.Web.Http;

namespace Microsoft.Toolkit.Uwp.Services.Exceptions
{
    /// <summary>
    /// Exception for failed requests.
    /// </summary>
    public class RequestFailedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestFailedException"/> class.
        /// Default constructor.
        /// </summary>
        public RequestFailedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestFailedException"/> class.
        /// Constructor with additional message.
        /// </summary>
        /// <param name="message">Additional messsage.</param>
        public RequestFailedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestFailedException"/> class.
        /// Constructor with status code and reason for request failure.
        /// </summary>
        /// <param name="statusCode">Failure status code.</param>
        /// <param name="reason">Failure reason.</param>
        public RequestFailedException(HttpStatusCode statusCode, string reason)
            : base(string.Format("Request failed with status code {0} and reason '{1}'", (int)statusCode, reason))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestFailedException"/> class.
        /// Constructor with additional message and inner exception.
        /// </summary>
        /// <param name="message">Additional message.</param>
        /// <param name="innerException">Reference to inner exception.</param>
        public RequestFailedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
