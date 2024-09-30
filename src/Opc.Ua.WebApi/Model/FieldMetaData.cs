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
    /// FieldMetaData
    /// </summary>
    [DataContract(Name = "FieldMetaData")]
    public partial class FieldMetaData : IEquatable<FieldMetaData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldMetaData" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="fieldFlags">fieldFlags.</param>
        /// <param name="builtInType">builtInType.</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="valueRank">valueRank.</param>
        /// <param name="arrayDimensions">arrayDimensions.</param>
        /// <param name="maxStringLength">maxStringLength.</param>
        /// <param name="dataSetFieldId">dataSetFieldId.</param>
        /// <param name="properties">properties.</param>
        public FieldMetaData(string name = default(string), LocalizedText description = default(LocalizedText), int fieldFlags = default(int), int builtInType = default(int), string dataType = default(string), int valueRank = default(int), List<long> arrayDimensions = default(List<long>), long maxStringLength = default(long), Guid dataSetFieldId = default(Guid), List<KeyValuePair> properties = default(List<KeyValuePair>))
        {
            this.Name = name;
            this.Description = description;
            this.FieldFlags = fieldFlags;
            this.BuiltInType = builtInType;
            this.DataType = dataType;
            this.ValueRank = valueRank;
            this.ArrayDimensions = arrayDimensions;
            this.MaxStringLength = maxStringLength;
            this.DataSetFieldId = dataSetFieldId;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public LocalizedText Description { get; set; }

        /// <summary>
        /// Gets or Sets FieldFlags
        /// </summary>
        [DataMember(Name = "FieldFlags", EmitDefaultValue = false)]
        public int FieldFlags { get; set; }

        /// <summary>
        /// Gets or Sets BuiltInType
        /// </summary>
        [DataMember(Name = "BuiltInType", EmitDefaultValue = false)]
        public int BuiltInType { get; set; }

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "DataType", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets ValueRank
        /// </summary>
        [DataMember(Name = "ValueRank", EmitDefaultValue = false)]
        public int ValueRank { get; set; }

        /// <summary>
        /// Gets or Sets ArrayDimensions
        /// </summary>
        [DataMember(Name = "ArrayDimensions", EmitDefaultValue = false)]
        public List<long> ArrayDimensions { get; set; }

        /// <summary>
        /// Gets or Sets MaxStringLength
        /// </summary>
        [DataMember(Name = "MaxStringLength", EmitDefaultValue = false)]
        public long MaxStringLength { get; set; }

        /// <summary>
        /// Gets or Sets DataSetFieldId
        /// </summary>
        [DataMember(Name = "DataSetFieldId", EmitDefaultValue = false)]
        public Guid DataSetFieldId { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "Properties", EmitDefaultValue = false)]
        public List<KeyValuePair> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldMetaData {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FieldFlags: ").Append(FieldFlags).Append("\n");
            sb.Append("  BuiltInType: ").Append(BuiltInType).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  ValueRank: ").Append(ValueRank).Append("\n");
            sb.Append("  ArrayDimensions: ").Append(ArrayDimensions).Append("\n");
            sb.Append("  MaxStringLength: ").Append(MaxStringLength).Append("\n");
            sb.Append("  DataSetFieldId: ").Append(DataSetFieldId).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as FieldMetaData);
        }

        /// <summary>
        /// Returns true if FieldMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldMetaData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FieldFlags == input.FieldFlags ||
                    this.FieldFlags.Equals(input.FieldFlags)
                ) && 
                (
                    this.BuiltInType == input.BuiltInType ||
                    this.BuiltInType.Equals(input.BuiltInType)
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.ValueRank == input.ValueRank ||
                    this.ValueRank.Equals(input.ValueRank)
                ) && 
                (
                    this.ArrayDimensions == input.ArrayDimensions ||
                    this.ArrayDimensions != null &&
                    input.ArrayDimensions != null &&
                    this.ArrayDimensions.SequenceEqual(input.ArrayDimensions)
                ) && 
                (
                    this.MaxStringLength == input.MaxStringLength ||
                    this.MaxStringLength.Equals(input.MaxStringLength)
                ) && 
                (
                    this.DataSetFieldId == input.DataSetFieldId ||
                    (this.DataSetFieldId != null &&
                    this.DataSetFieldId.Equals(input.DataSetFieldId))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FieldFlags.GetHashCode();
                hashCode = (hashCode * 59) + this.BuiltInType.GetHashCode();
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueRank.GetHashCode();
                if (this.ArrayDimensions != null)
                {
                    hashCode = (hashCode * 59) + this.ArrayDimensions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxStringLength.GetHashCode();
                if (this.DataSetFieldId != null)
                {
                    hashCode = (hashCode * 59) + this.DataSetFieldId.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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
            // FieldFlags (int) maximum
            if (this.FieldFlags > (int)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FieldFlags, must be a value less than or equal to 65535.", new [] { "FieldFlags" });
            }

            // FieldFlags (int) minimum
            if (this.FieldFlags < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FieldFlags, must be a value greater than or equal to 0.", new [] { "FieldFlags" });
            }

            // BuiltInType (int) maximum
            if (this.BuiltInType > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuiltInType, must be a value less than or equal to 255.", new [] { "BuiltInType" });
            }

            // BuiltInType (int) minimum
            if (this.BuiltInType < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuiltInType, must be a value greater than or equal to 0.", new [] { "BuiltInType" });
            }

            // MaxStringLength (long) maximum
            if (this.MaxStringLength > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxStringLength, must be a value less than or equal to 4294967295.", new [] { "MaxStringLength" });
            }

            // MaxStringLength (long) minimum
            if (this.MaxStringLength < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxStringLength, must be a value greater than or equal to 0.", new [] { "MaxStringLength" });
            }

            yield break;
        }
    }

}