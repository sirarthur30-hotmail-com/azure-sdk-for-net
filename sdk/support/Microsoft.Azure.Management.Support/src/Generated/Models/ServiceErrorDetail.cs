// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The error details.
    /// </summary>
    public partial class ServiceErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the ServiceErrorDetail class.
        /// </summary>
        public ServiceErrorDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceErrorDetail class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="target">The target of the error.</param>
        public ServiceErrorDetail(string code = default(string), string message = default(string), string target = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or sets the target of the error.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

    }
}