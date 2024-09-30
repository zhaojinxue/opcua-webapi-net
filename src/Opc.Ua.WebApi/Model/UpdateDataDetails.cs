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
    /// UpdateDataDetails
    /// </summary>
    [DataContract(Name = "UpdateDataDetails")]
    public partial class UpdateDataDetails : IEquatable<UpdateDataDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDataDetails" /> class.
        /// </summary>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="performInsertReplace">performInsertReplace.</param>
        /// <param name="updateValues">updateValues.</param>
        public UpdateDataDetails(string nodeId = default(string), int performInsertReplace = default(int), List<DataValue> updateValues = default(List<DataValue>))
        {
            this.NodeId = nodeId;
            this.PerformInsertReplace = performInsertReplace;
            this.UpdateValues = updateValues;
        }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "NodeId", EmitDefaultValue = false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets PerformInsertReplace
        /// </summary>
        [DataMember(Name = "PerformInsertReplace", EmitDefaultValue = false)]
        public int PerformInsertReplace { get; set; }

        /// <summary>
        /// Gets or Sets UpdateValues
        /// </summary>
        [DataMember(Name = "UpdateValues", EmitDefaultValue = false)]
        public List<DataValue> UpdateValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateDataDetails {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  PerformInsertReplace: ").Append(PerformInsertReplace).Append("\n");
            sb.Append("  UpdateValues: ").Append(UpdateValues).Append("\n");
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
            return this.Equals(input as UpdateDataDetails);
        }

        /// <summary>
        /// Returns true if UpdateDataDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateDataDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDataDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.PerformInsertReplace == input.PerformInsertReplace ||
                    this.PerformInsertReplace.Equals(input.PerformInsertReplace)
                ) && 
                (
                    this.UpdateValues == input.UpdateValues ||
                    this.UpdateValues != null &&
                    input.UpdateValues != null &&
                    this.UpdateValues.SequenceEqual(input.UpdateValues)
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
                if (this.NodeId != null)
                {
                    hashCode = (hashCode * 59) + this.NodeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PerformInsertReplace.GetHashCode();
                if (this.UpdateValues != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateValues.GetHashCode();
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