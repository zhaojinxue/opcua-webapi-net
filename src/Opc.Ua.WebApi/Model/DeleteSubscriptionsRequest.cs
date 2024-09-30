/*
 * OPC UA Web API
 *
 * Provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Opc.Ua.WebApi.Client.OpenAPIDateConverter;

namespace Opc.Ua.WebApi.Model
{
    /// <summary>
    /// DeleteSubscriptionsRequest
    /// </summary>
    [DataContract(Name = "DeleteSubscriptionsRequest")]
    public partial class DeleteSubscriptionsRequest : IEquatable<DeleteSubscriptionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSubscriptionsRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="subscriptionIds">subscriptionIds.</param>
        public DeleteSubscriptionsRequest(RequestHeader requestHeader = default(RequestHeader), List<long> subscriptionIds = default(List<long>))
        {
            this.RequestHeader = requestHeader;
            this.SubscriptionIds = subscriptionIds;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionIds
        /// </summary>
        [DataMember(Name = "SubscriptionIds", EmitDefaultValue = false)]
        public List<long> SubscriptionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteSubscriptionsRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  SubscriptionIds: ").Append(SubscriptionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSubscriptionsRequest);
        }

        /// <summary>
        /// Returns true if DeleteSubscriptionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteSubscriptionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteSubscriptionsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequestHeader == input.RequestHeader ||
                    (this.RequestHeader != null &&
                    this.RequestHeader.Equals(input.RequestHeader))
                ) && 
                (
                    this.SubscriptionIds == input.SubscriptionIds ||
                    this.SubscriptionIds != null &&
                    input.SubscriptionIds != null &&
                    this.SubscriptionIds.SequenceEqual(input.SubscriptionIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RequestHeader != null)
                {
                    hashCode = (hashCode * 59) + this.RequestHeader.GetHashCode();
                }
                if (this.SubscriptionIds != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionIds.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}