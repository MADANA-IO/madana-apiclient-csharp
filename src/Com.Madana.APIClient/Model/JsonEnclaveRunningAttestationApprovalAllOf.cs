/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.4.14-master.20
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
    /// JsonEnclaveRunningAttestationApprovalAllOf
    /// </summary>
    [DataContract]
    public partial class JsonEnclaveRunningAttestationApprovalAllOf :  IEquatable<JsonEnclaveRunningAttestationApprovalAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonEnclaveRunningAttestationApprovalAllOf" /> class.
        /// </summary>
        /// <param name="approved">approved.</param>
        public JsonEnclaveRunningAttestationApprovalAllOf(string approved = default(string))
        {
            this.Approved = approved;
        }
        
        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public string Approved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonEnclaveRunningAttestationApprovalAllOf {\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as JsonEnclaveRunningAttestationApprovalAllOf);
        }

        /// <summary>
        /// Returns true if JsonEnclaveRunningAttestationApprovalAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonEnclaveRunningAttestationApprovalAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonEnclaveRunningAttestationApprovalAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Approved == input.Approved ||
                    (this.Approved != null &&
                    this.Approved.Equals(input.Approved))
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
                if (this.Approved != null)
                    hashCode = hashCode * 59 + this.Approved.GetHashCode();
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