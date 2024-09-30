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
    /// CreateSessionResponse
    /// </summary>
    [DataContract(Name = "CreateSessionResponse")]
    public partial class CreateSessionResponse : IEquatable<CreateSessionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionResponse" /> class.
        /// </summary>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="authenticationToken">authenticationToken.</param>
        /// <param name="revisedSessionTimeout">revisedSessionTimeout.</param>
        /// <param name="serverNonce">serverNonce.</param>
        /// <param name="serverCertificate">serverCertificate.</param>
        /// <param name="serverEndpoints">serverEndpoints.</param>
        /// <param name="serverSoftwareCertificates">serverSoftwareCertificates.</param>
        /// <param name="serverSignature">serverSignature.</param>
        /// <param name="maxRequestMessageSize">maxRequestMessageSize.</param>
        public CreateSessionResponse(ResponseHeader responseHeader = default(ResponseHeader), string sessionId = default(string), string authenticationToken = default(string), double revisedSessionTimeout = default(double), byte[] serverNonce = default(byte[]), byte[] serverCertificate = default(byte[]), List<EndpointDescription> serverEndpoints = default(List<EndpointDescription>), List<SignedSoftwareCertificate> serverSoftwareCertificates = default(List<SignedSoftwareCertificate>), SignatureData serverSignature = default(SignatureData), long maxRequestMessageSize = default(long))
        {
            this.ResponseHeader = responseHeader;
            this.SessionId = sessionId;
            this.AuthenticationToken = authenticationToken;
            this.RevisedSessionTimeout = revisedSessionTimeout;
            this.ServerNonce = serverNonce;
            this.ServerCertificate = serverCertificate;
            this.ServerEndpoints = serverEndpoints;
            this.ServerSoftwareCertificates = serverSoftwareCertificates;
            this.ServerSignature = serverSignature;
            this.MaxRequestMessageSize = maxRequestMessageSize;
        }

        /// <summary>
        /// Gets or Sets ResponseHeader
        /// </summary>
        [DataMember(Name = "ResponseHeader", EmitDefaultValue = false)]
        public ResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name = "SessionId", EmitDefaultValue = false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationToken
        /// </summary>
        [DataMember(Name = "AuthenticationToken", EmitDefaultValue = false)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Gets or Sets RevisedSessionTimeout
        /// </summary>
        [DataMember(Name = "RevisedSessionTimeout", EmitDefaultValue = false)]
        public double RevisedSessionTimeout { get; set; }

        /// <summary>
        /// Gets or Sets ServerNonce
        /// </summary>
        [DataMember(Name = "ServerNonce", EmitDefaultValue = false)]
        public byte[] ServerNonce { get; set; }

        /// <summary>
        /// Gets or Sets ServerCertificate
        /// </summary>
        [DataMember(Name = "ServerCertificate", EmitDefaultValue = false)]
        public byte[] ServerCertificate { get; set; }

        /// <summary>
        /// Gets or Sets ServerEndpoints
        /// </summary>
        [DataMember(Name = "ServerEndpoints", EmitDefaultValue = false)]
        public List<EndpointDescription> ServerEndpoints { get; set; }

        /// <summary>
        /// Gets or Sets ServerSoftwareCertificates
        /// </summary>
        [DataMember(Name = "ServerSoftwareCertificates", EmitDefaultValue = false)]
        public List<SignedSoftwareCertificate> ServerSoftwareCertificates { get; set; }

        /// <summary>
        /// Gets or Sets ServerSignature
        /// </summary>
        [DataMember(Name = "ServerSignature", EmitDefaultValue = false)]
        public SignatureData ServerSignature { get; set; }

        /// <summary>
        /// Gets or Sets MaxRequestMessageSize
        /// </summary>
        [DataMember(Name = "MaxRequestMessageSize", EmitDefaultValue = false)]
        public long MaxRequestMessageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSessionResponse {\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  AuthenticationToken: ").Append(AuthenticationToken).Append("\n");
            sb.Append("  RevisedSessionTimeout: ").Append(RevisedSessionTimeout).Append("\n");
            sb.Append("  ServerNonce: ").Append(ServerNonce).Append("\n");
            sb.Append("  ServerCertificate: ").Append(ServerCertificate).Append("\n");
            sb.Append("  ServerEndpoints: ").Append(ServerEndpoints).Append("\n");
            sb.Append("  ServerSoftwareCertificates: ").Append(ServerSoftwareCertificates).Append("\n");
            sb.Append("  ServerSignature: ").Append(ServerSignature).Append("\n");
            sb.Append("  MaxRequestMessageSize: ").Append(MaxRequestMessageSize).Append("\n");
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
            return this.Equals(input as CreateSessionResponse);
        }

        /// <summary>
        /// Returns true if CreateSessionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSessionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSessionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResponseHeader == input.ResponseHeader ||
                    (this.ResponseHeader != null &&
                    this.ResponseHeader.Equals(input.ResponseHeader))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.AuthenticationToken == input.AuthenticationToken ||
                    (this.AuthenticationToken != null &&
                    this.AuthenticationToken.Equals(input.AuthenticationToken))
                ) && 
                (
                    this.RevisedSessionTimeout == input.RevisedSessionTimeout ||
                    this.RevisedSessionTimeout.Equals(input.RevisedSessionTimeout)
                ) && 
                (
                    this.ServerNonce == input.ServerNonce ||
                    (this.ServerNonce != null &&
                    this.ServerNonce.Equals(input.ServerNonce))
                ) && 
                (
                    this.ServerCertificate == input.ServerCertificate ||
                    (this.ServerCertificate != null &&
                    this.ServerCertificate.Equals(input.ServerCertificate))
                ) && 
                (
                    this.ServerEndpoints == input.ServerEndpoints ||
                    this.ServerEndpoints != null &&
                    input.ServerEndpoints != null &&
                    this.ServerEndpoints.SequenceEqual(input.ServerEndpoints)
                ) && 
                (
                    this.ServerSoftwareCertificates == input.ServerSoftwareCertificates ||
                    this.ServerSoftwareCertificates != null &&
                    input.ServerSoftwareCertificates != null &&
                    this.ServerSoftwareCertificates.SequenceEqual(input.ServerSoftwareCertificates)
                ) && 
                (
                    this.ServerSignature == input.ServerSignature ||
                    (this.ServerSignature != null &&
                    this.ServerSignature.Equals(input.ServerSignature))
                ) && 
                (
                    this.MaxRequestMessageSize == input.MaxRequestMessageSize ||
                    this.MaxRequestMessageSize.Equals(input.MaxRequestMessageSize)
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
                if (this.ResponseHeader != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseHeader.GetHashCode();
                }
                if (this.SessionId != null)
                {
                    hashCode = (hashCode * 59) + this.SessionId.GetHashCode();
                }
                if (this.AuthenticationToken != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RevisedSessionTimeout.GetHashCode();
                if (this.ServerNonce != null)
                {
                    hashCode = (hashCode * 59) + this.ServerNonce.GetHashCode();
                }
                if (this.ServerCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.ServerCertificate.GetHashCode();
                }
                if (this.ServerEndpoints != null)
                {
                    hashCode = (hashCode * 59) + this.ServerEndpoints.GetHashCode();
                }
                if (this.ServerSoftwareCertificates != null)
                {
                    hashCode = (hashCode * 59) + this.ServerSoftwareCertificates.GetHashCode();
                }
                if (this.ServerSignature != null)
                {
                    hashCode = (hashCode * 59) + this.ServerSignature.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxRequestMessageSize.GetHashCode();
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
            // MaxRequestMessageSize (long) maximum
            if (this.MaxRequestMessageSize > (long)4294967295)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxRequestMessageSize, must be a value less than or equal to 4294967295.", new [] { "MaxRequestMessageSize" });
            }

            // MaxRequestMessageSize (long) minimum
            if (this.MaxRequestMessageSize < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxRequestMessageSize, must be a value greater than or equal to 0.", new [] { "MaxRequestMessageSize" });
            }

            yield break;
        }
    }

}