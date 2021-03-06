// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> A web application firewall rule. </summary>
    public partial class ApplicationGatewayFirewallRule
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFirewallRule. </summary>
        /// <param name="ruleId"> The identifier of the web application firewall rule. </param>
        public ApplicationGatewayFirewallRule(int ruleId)
        {
            RuleId = ruleId;
        }

        /// <summary> Initializes a new instance of ApplicationGatewayFirewallRule. </summary>
        /// <param name="ruleId"> The identifier of the web application firewall rule. </param>
        /// <param name="description"> The description of the web application firewall rule. </param>
        internal ApplicationGatewayFirewallRule(int ruleId, string description)
        {
            RuleId = ruleId;
            Description = description;
        }

        /// <summary> The identifier of the web application firewall rule. </summary>
        public int RuleId { get; set; }
        /// <summary> The description of the web application firewall rule. </summary>
        public string Description { get; set; }
    }
}
