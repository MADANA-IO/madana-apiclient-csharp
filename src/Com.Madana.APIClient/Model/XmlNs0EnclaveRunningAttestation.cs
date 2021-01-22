/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.44
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
    /// XmlNs0EnclaveRunningAttestation
    /// </summary>
    [DataContract]
    public partial class XmlNs0EnclaveRunningAttestation :  IEquatable<XmlNs0EnclaveRunningAttestation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlNs0EnclaveRunningAttestation" /> class.
        /// </summary>
        /// <param name="enclaveProcess">enclaveProcess.</param>
        /// <param name="nodeInfo">nodeInfo.</param>
        public XmlNs0EnclaveRunningAttestation(XmlNs0EnclaveProcess enclaveProcess = default(XmlNs0EnclaveProcess), XmlNs0NodeInfo nodeInfo = default(XmlNs0NodeInfo))
        {
            this.EnclaveProcess = enclaveProcess;
            this.NodeInfo = nodeInfo;
        }
        
        /// <summary>
        /// Gets or Sets EnclaveProcess
        /// </summary>
        [DataMember(Name="enclaveProcess", EmitDefaultValue=false)]
        public XmlNs0EnclaveProcess EnclaveProcess { get; set; }

        /// <summary>
        /// Gets or Sets NodeInfo
        /// </summary>
        [DataMember(Name="nodeInfo", EmitDefaultValue=false)]
        public XmlNs0NodeInfo NodeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlNs0EnclaveRunningAttestation {\n");
            sb.Append("  EnclaveProcess: ").Append(EnclaveProcess).Append("\n");
            sb.Append("  NodeInfo: ").Append(NodeInfo).Append("\n");
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
            return this.Equals(input as XmlNs0EnclaveRunningAttestation);
        }

        /// <summary>
        /// Returns true if XmlNs0EnclaveRunningAttestation instances are equal
        /// </summary>
        /// <param name="input">Instance of XmlNs0EnclaveRunningAttestation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmlNs0EnclaveRunningAttestation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnclaveProcess == input.EnclaveProcess ||
                    (this.EnclaveProcess != null &&
                    this.EnclaveProcess.Equals(input.EnclaveProcess))
                ) && 
                (
                    this.NodeInfo == input.NodeInfo ||
                    (this.NodeInfo != null &&
                    this.NodeInfo.Equals(input.NodeInfo))
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
                if (this.EnclaveProcess != null)
                    hashCode = hashCode * 59 + this.EnclaveProcess.GetHashCode();
                if (this.NodeInfo != null)
                    hashCode = hashCode * 59 + this.NodeInfo.GetHashCode();
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
