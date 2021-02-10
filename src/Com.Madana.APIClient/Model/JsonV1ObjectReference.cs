/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.54
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
    /// JsonV1ObjectReference
    /// </summary>
    [DataContract]
    public partial class JsonV1ObjectReference :  IEquatable<JsonV1ObjectReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonV1ObjectReference" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="resourceVersion">resourceVersion.</param>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="uid">uid.</param>
        /// <param name="fieldPath">fieldPath.</param>
        /// <param name="kind">kind.</param>
        public JsonV1ObjectReference(string name = default(string), string _namespace = default(string), string resourceVersion = default(string), string apiVersion = default(string), string uid = default(string), string fieldPath = default(string), string kind = default(string))
        {
            this.Name = name;
            this.Namespace = _namespace;
            this.ResourceVersion = resourceVersion;
            this.ApiVersion = apiVersion;
            this.Uid = uid;
            this.FieldPath = fieldPath;
            this.Kind = kind;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets ResourceVersion
        /// </summary>
        [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or Sets FieldPath
        /// </summary>
        [DataMember(Name="fieldPath", EmitDefaultValue=false)]
        public string FieldPath { get; set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonV1ObjectReference {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  FieldPath: ").Append(FieldPath).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
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
            return this.Equals(input as JsonV1ObjectReference);
        }

        /// <summary>
        /// Returns true if JsonV1ObjectReference instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonV1ObjectReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonV1ObjectReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.ResourceVersion == input.ResourceVersion ||
                    (this.ResourceVersion != null &&
                    this.ResourceVersion.Equals(input.ResourceVersion))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.FieldPath == input.FieldPath ||
                    (this.FieldPath != null &&
                    this.FieldPath.Equals(input.FieldPath))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
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
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ResourceVersion != null)
                    hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.FieldPath != null)
                    hashCode = hashCode * 59 + this.FieldPath.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
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
