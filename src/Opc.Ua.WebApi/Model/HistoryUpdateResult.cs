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
    /// HistoryUpdateResult
    /// </summary>
    [DataContract(Name = "HistoryUpdateResult")]
    public partial class HistoryUpdateResult : IEquatable<HistoryUpdateResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryUpdateResult" /> class.
        /// </summary>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="operationResults">operationResults.</param>
        /// <param name="diagnosticInfos">diagnosticInfos.</param>
        public HistoryUpdateResult(long statusCode = default(long), List<long> operationResults = default(List<long>), List<DiagnosticInfo> diagnosticInfos = default(List<DiagnosticInfo>))
        {
            this.StatusCode = statusCode;
            this.OperationResults = operationResults;
            this.DiagnosticInfos = diagnosticInfos;
        }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public long StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets OperationResults
        /// </summary>
        [DataMember(Name = "OperationResults", EmitDefaultValue = false)]
        public List<long> OperationResults { get; set; }

        /// <summary>
        /// Gets or Sets DiagnosticInfos
        /// </summary>
        [DataMember(Name = "DiagnosticInfos", EmitDefaultValue = false)]
        public List<DiagnosticInfo> DiagnosticInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoryUpdateResult {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  OperationResults: ").Append(OperationResults).Append("\n");
            sb.Append("  DiagnosticInfos: ").Append(DiagnosticInfos).Append("\n");
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
            return this.Equals(input as HistoryUpdateResult);
        }

        /// <summary>
        /// Returns true if HistoryUpdateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryUpdateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryUpdateResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.OperationResults == input.OperationResults ||
                    this.OperationResults != null &&
                    input.OperationResults != null &&
                    this.OperationResults.SequenceEqual(input.OperationResults)
                ) && 
                (
                    this.DiagnosticInfos == input.DiagnosticInfos ||
                    this.DiagnosticInfos != null &&
                    input.DiagnosticInfos != null &&
                    this.DiagnosticInfos.SequenceEqual(input.DiagnosticInfos)
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
                hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                if (this.OperationResults != null)
                {
                    hashCode = (hashCode * 59) + this.OperationResults.GetHashCode();
                }
                if (this.DiagnosticInfos != null)
                {
                    hashCode = (hashCode * 59) + this.DiagnosticInfos.GetHashCode();
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
            // StatusCode (long) maximum
            if (this.StatusCode > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusCode, must be a value less than or equal to 4294967295.", new [] { "StatusCode" });
            }

            // StatusCode (long) minimum
            if (this.StatusCode < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StatusCode, must be a value greater than or equal to 0.", new [] { "StatusCode" });
            }

            yield break;
        }
    }

}