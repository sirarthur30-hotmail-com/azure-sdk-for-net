// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A database query.
    /// </summary>
    public partial class QueryStatistic
    {
        /// <summary>
        /// Initializes a new instance of the QueryStatistic class.
        /// </summary>
        public QueryStatistic()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryStatistic class.
        /// </summary>
        /// <param name="queryId">The id of the query</param>
        /// <param name="intervals">The list of query intervals.</param>
        public QueryStatistic(string queryId = default(string), IList<QueryInterval> intervals = default(IList<QueryInterval>))
        {
            QueryId = queryId;
            Intervals = intervals;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of the query
        /// </summary>
        [JsonProperty(PropertyName = "queryId")]
        public string QueryId { get; private set; }

        /// <summary>
        /// Gets the list of query intervals.
        /// </summary>
        [JsonProperty(PropertyName = "intervals")]
        public IList<QueryInterval> Intervals { get; private set; }

    }
}