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
    /// ReadRawModifiedDetails
    /// </summary>
    [DataContract(Name = "ReadRawModifiedDetails")]
    public partial class ReadRawModifiedDetails : IEquatable<ReadRawModifiedDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadRawModifiedDetails" /> class.
        /// </summary>
        /// <param name="isReadModified">isReadModified.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="numValuesPerNode">numValuesPerNode.</param>
        /// <param name="returnBounds">returnBounds.</param>
        public ReadRawModifiedDetails(bool isReadModified = default(bool), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), long numValuesPerNode = default(long), bool returnBounds = default(bool))
        {
            this.IsReadModified = isReadModified;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.NumValuesPerNode = numValuesPerNode;
            this.ReturnBounds = returnBounds;
        }

        /// <summary>
        /// Gets or Sets IsReadModified
        /// </summary>
        [DataMember(Name = "IsReadModified", EmitDefaultValue = true)]
        public bool IsReadModified { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "StartTime", EmitDefaultValue = false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "EndTime", EmitDefaultValue = false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or Sets NumValuesPerNode
        /// </summary>
        [DataMember(Name = "NumValuesPerNode", EmitDefaultValue = false)]
        public long NumValuesPerNode { get; set; }

        /// <summary>
        /// Gets or Sets ReturnBounds
        /// </summary>
        [DataMember(Name = "ReturnBounds", EmitDefaultValue = true)]
        public bool ReturnBounds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadRawModifiedDetails {\n");
            sb.Append("  IsReadModified: ").Append(IsReadModified).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  NumValuesPerNode: ").Append(NumValuesPerNode).Append("\n");
            sb.Append("  ReturnBounds: ").Append(ReturnBounds).Append("\n");
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
            return this.Equals(input as ReadRawModifiedDetails);
        }

        /// <summary>
        /// Returns true if ReadRawModifiedDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadRawModifiedDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadRawModifiedDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsReadModified == input.IsReadModified ||
                    this.IsReadModified.Equals(input.IsReadModified)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.NumValuesPerNode == input.NumValuesPerNode ||
                    this.NumValuesPerNode.Equals(input.NumValuesPerNode)
                ) && 
                (
                    this.ReturnBounds == input.ReturnBounds ||
                    this.ReturnBounds.Equals(input.ReturnBounds)
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
                hashCode = (hashCode * 59) + this.IsReadModified.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NumValuesPerNode.GetHashCode();
                hashCode = (hashCode * 59) + this.ReturnBounds.GetHashCode();
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
            // NumValuesPerNode (long) maximum
            if (this.NumValuesPerNode > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumValuesPerNode, must be a value less than or equal to 4294967295.", new [] { "NumValuesPerNode" });
            }

            // NumValuesPerNode (long) minimum
            if (this.NumValuesPerNode < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NumValuesPerNode, must be a value greater than or equal to 0.", new [] { "NumValuesPerNode" });
            }

            yield break;
        }
    }

}