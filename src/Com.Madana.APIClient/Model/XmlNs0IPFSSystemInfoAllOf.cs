/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.56
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Madana.APIClient.Client.OpenAPIDateConverter;

namespace Com.Madana.APIClient.Model
{
    /// <summary>
    /// XmlNs0IPFSSystemInfoAllOf
    /// </summary>
    [DataContract]
    public partial class XmlNs0IPFSSystemInfoAllOf :  IEquatable<XmlNs0IPFSSystemInfoAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlNs0IPFSSystemInfoAllOf" /> class.
        /// </summary>
        /// <param name="agentVersion">agentVersion.</param>
        /// <param name="id">id.</param>
        /// <param name="protocolVersion">protocolVersion.</param>
        /// <param name="publicKey">publicKey.</param>
        /// <param name="swarmConnection">swarmConnection.</param>
        public XmlNs0IPFSSystemInfoAllOf(string agentVersion = default(string), string id = default(string), string protocolVersion = default(string), string publicKey = default(string), string swarmConnection = default(string))
        {
            this.AgentVersion = agentVersion;
            this.Id = id;
            this.ProtocolVersion = protocolVersion;
            this.PublicKey = publicKey;
            this.SwarmConnection = swarmConnection;
        }
        
        /// <summary>
        /// Gets or Sets AgentVersion
        /// </summary>
        [DataMember(Name="agentVersion", EmitDefaultValue=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolVersion
        /// </summary>
        [DataMember(Name="protocolVersion", EmitDefaultValue=false)]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name="publicKey", EmitDefaultValue=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets SwarmConnection
        /// </summary>
        [DataMember(Name="swarmConnection", EmitDefaultValue=false)]
        public string SwarmConnection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlNs0IPFSSystemInfoAllOf {\n");
            sb.Append("  AgentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProtocolVersion: ").Append(ProtocolVersion).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  SwarmConnection: ").Append(SwarmConnection).Append("\n");
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
            return this.Equals(input as XmlNs0IPFSSystemInfoAllOf);
        }

        /// <summary>
        /// Returns true if XmlNs0IPFSSystemInfoAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of XmlNs0IPFSSystemInfoAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmlNs0IPFSSystemInfoAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentVersion == input.AgentVersion ||
                    (this.AgentVersion != null &&
                    this.AgentVersion.Equals(input.AgentVersion))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ProtocolVersion == input.ProtocolVersion ||
                    (this.ProtocolVersion != null &&
                    this.ProtocolVersion.Equals(input.ProtocolVersion))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.SwarmConnection == input.SwarmConnection ||
                    (this.SwarmConnection != null &&
                    this.SwarmConnection.Equals(input.SwarmConnection))
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
                if (this.AgentVersion != null)
                    hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProtocolVersion != null)
                    hashCode = hashCode * 59 + this.ProtocolVersion.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.SwarmConnection != null)
                    hashCode = hashCode * 59 + this.SwarmConnection.GetHashCode();
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
