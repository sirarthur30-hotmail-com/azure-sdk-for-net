// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesConfiguration.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for EnableHelmOperator.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(EnableHelmOperatorConverter))]
    public struct EnableHelmOperator : System.IEquatable<EnableHelmOperator>
    {
        private EnableHelmOperator(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly EnableHelmOperator True = "true";

        public static readonly EnableHelmOperator False = "false";


        /// <summary>
        /// Underlying value of enum EnableHelmOperator
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for EnableHelmOperator
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type EnableHelmOperator
        /// </summary>
        public bool Equals(EnableHelmOperator e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to EnableHelmOperator
        /// </summary>
        public static implicit operator EnableHelmOperator(string value)
        {
            return new EnableHelmOperator(value);
        }

        /// <summary>
        /// Implicit operator to convert EnableHelmOperator to string
        /// </summary>
        public static implicit operator string(EnableHelmOperator e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum EnableHelmOperator
        /// </summary>
        public static bool operator == (EnableHelmOperator e1, EnableHelmOperator e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum EnableHelmOperator
        /// </summary>
        public static bool operator != (EnableHelmOperator e1, EnableHelmOperator e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for EnableHelmOperator
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is EnableHelmOperator && Equals((EnableHelmOperator)obj);
        }

        /// <summary>
        /// Returns for hashCode EnableHelmOperator
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
