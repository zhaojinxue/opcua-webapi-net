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
    /// ActivateSessionRequest
    /// </summary>
    [DataContract(Name = "ActivateSessionRequest")]
    public partial class ActivateSessionRequest : IEquatable<ActivateSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateSessionRequest" /> class.
        /// </summary>
        /// <param name="requestHeader">requestHeader.</param>
        /// <param name="clientSignature">clientSignature.</param>
        /// <param name="clientSoftwareCertificates">clientSoftwareCertificates.</param>
        /// <param name="localeIds">localeIds.</param>
        /// <param name="userIdentityToken">userIdentityToken.</param>
        /// <param name="userTokenSignature">userTokenSignature.</param>
        public ActivateSessionRequest(RequestHeader requestHeader = default(RequestHeader), SignatureData clientSignature = default(SignatureData), List<SignedSoftwareCertificate> clientSoftwareCertificates = default(List<SignedSoftwareCertificate>), List<string> localeIds = default(List<string>), ExtensionObject userIdentityToken = default(ExtensionObject), SignatureData userTokenSignature = default(SignatureData))
        {
            this.RequestHeader = requestHeader;
            this.ClientSignature = clientSignature;
            this.ClientSoftwareCertificates = clientSoftwareCertificates;
            this.LocaleIds = localeIds;
            this.UserIdentityToken = userIdentityToken;
            this.UserTokenSignature = userTokenSignature;
        }

        /// <summary>
        /// Gets or Sets RequestHeader
        /// </summary>
        [DataMember(Name = "RequestHeader", EmitDefaultValue = false)]
        public RequestHeader RequestHeader { get; set; }

        /// <summary>
        /// Gets or Sets ClientSignature
        /// </summary>
        [DataMember(Name = "ClientSignature", EmitDefaultValue = false)]
        public SignatureData ClientSignature { get; set; }

        /// <summary>
        /// Gets or Sets ClientSoftwareCertificates
        /// </summary>
        [DataMember(Name = "ClientSoftwareCertificates", EmitDefaultValue = false)]
        public List<SignedSoftwareCertificate> ClientSoftwareCertificates { get; set; }

        /// <summary>
        /// Gets or Sets LocaleIds
        /// </summary>
        [DataMember(Name = "LocaleIds", EmitDefaultValue = false)]
        public List<string> LocaleIds { get; set; }

        /// <summary>
        /// Gets or Sets UserIdentityToken
        /// </summary>
        [DataMember(Name = "UserIdentityToken", EmitDefaultValue = false)]
        public ExtensionObject UserIdentityToken { get; set; }

        /// <summary>
        /// Gets or Sets UserTokenSignature
        /// </summary>
        [DataMember(Name = "UserTokenSignature", EmitDefaultValue = false)]
        public SignatureData UserTokenSignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivateSessionRequest {\n");
            sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
            sb.Append("  ClientSignature: ").Append(ClientSignature).Append("\n");
            sb.Append("  ClientSoftwareCertificates: ").Append(ClientSoftwareCertificates).Append("\n");
            sb.Append("  LocaleIds: ").Append(LocaleIds).Append("\n");
            sb.Append("  UserIdentityToken: ").Append(UserIdentityToken).Append("\n");
            sb.Append("  UserTokenSignature: ").Append(UserTokenSignature).Append("\n");
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
            return this.Equals(input as ActivateSessionRequest);
        }

        /// <summary>
        /// Returns true if ActivateSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivateSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivateSessionRequest input)
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
                    this.ClientSignature == input.ClientSignature ||
                    (this.ClientSignature != null &&
                    this.ClientSignature.Equals(input.ClientSignature))
                ) && 
                (
                    this.ClientSoftwareCertificates == input.ClientSoftwareCertificates ||
                    this.ClientSoftwareCertificates != null &&
                    input.ClientSoftwareCertificates != null &&
                    this.ClientSoftwareCertificates.SequenceEqual(input.ClientSoftwareCertificates)
                ) && 
                (
                    this.LocaleIds == input.LocaleIds ||
                    this.LocaleIds != null &&
                    input.LocaleIds != null &&
                    this.LocaleIds.SequenceEqual(input.LocaleIds)
                ) && 
                (
                    this.UserIdentityToken == input.UserIdentityToken ||
                    (this.UserIdentityToken != null &&
                    this.UserIdentityToken.Equals(input.UserIdentityToken))
                ) && 
                (
                    this.UserTokenSignature == input.UserTokenSignature ||
                    (this.UserTokenSignature != null &&
                    this.UserTokenSignature.Equals(input.UserTokenSignature))
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
                if (this.ClientSignature != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSignature.GetHashCode();
                }
                if (this.ClientSoftwareCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSoftwareCertificates.GetHashCode();
                }
                if (this.LocaleIds != null)
                {
                    hashCode = (hashCode * 59) + this.LocaleIds.GetHashCode();
                }
                if (this.UserIdentityToken != null)
                {
                    hashCode = (hashCode * 59) + this.UserIdentityToken.GetHashCode();
                }
                if (this.UserTokenSignature != null)
                {
                    hashCode = (hashCode * 59) + this.UserTokenSignature.GetHashCode();
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