/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.26
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
    /// JsonProcess
    /// </summary>
    [DataContract]
    public partial class JsonProcess :  IEquatable<JsonProcess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonProcess" /> class.
        /// </summary>
        /// <param name="outputStream">outputStream.</param>
        /// <param name="errorStream">errorStream.</param>
        /// <param name="inputStream">inputStream.</param>
        /// <param name="alive">alive.</param>
        public JsonProcess(Object outputStream = default(Object), Object errorStream = default(Object), Object inputStream = default(Object), bool alive = default(bool))
        {
            this.OutputStream = outputStream;
            this.ErrorStream = errorStream;
            this.InputStream = inputStream;
            this.Alive = alive;
        }
        
        /// <summary>
        /// Gets or Sets OutputStream
        /// </summary>
        [DataMember(Name="outputStream", EmitDefaultValue=false)]
        public Object OutputStream { get; set; }

        /// <summary>
        /// Gets or Sets ErrorStream
        /// </summary>
        [DataMember(Name="errorStream", EmitDefaultValue=false)]
        public Object ErrorStream { get; set; }

        /// <summary>
        /// Gets or Sets InputStream
        /// </summary>
        [DataMember(Name="inputStream", EmitDefaultValue=false)]
        public Object InputStream { get; set; }

        /// <summary>
        /// Gets or Sets Alive
        /// </summary>
        [DataMember(Name="alive", EmitDefaultValue=false)]
        public bool Alive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonProcess {\n");
            sb.Append("  OutputStream: ").Append(OutputStream).Append("\n");
            sb.Append("  ErrorStream: ").Append(ErrorStream).Append("\n");
            sb.Append("  InputStream: ").Append(InputStream).Append("\n");
            sb.Append("  Alive: ").Append(Alive).Append("\n");
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
            return this.Equals(input as JsonProcess);
        }

        /// <summary>
        /// Returns true if JsonProcess instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonProcess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonProcess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputStream == input.OutputStream ||
                    (this.OutputStream != null &&
                    this.OutputStream.Equals(input.OutputStream))
                ) && 
                (
                    this.ErrorStream == input.ErrorStream ||
                    (this.ErrorStream != null &&
                    this.ErrorStream.Equals(input.ErrorStream))
                ) && 
                (
                    this.InputStream == input.InputStream ||
                    (this.InputStream != null &&
                    this.InputStream.Equals(input.InputStream))
                ) && 
                (
                    this.Alive == input.Alive ||
                    (this.Alive != null &&
                    this.Alive.Equals(input.Alive))
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
                if (this.OutputStream != null)
                    hashCode = hashCode * 59 + this.OutputStream.GetHashCode();
                if (this.ErrorStream != null)
                    hashCode = hashCode * 59 + this.ErrorStream.GetHashCode();
                if (this.InputStream != null)
                    hashCode = hashCode * 59 + this.InputStream.GetHashCode();
                if (this.Alive != null)
                    hashCode = hashCode * 59 + this.Alive.GetHashCode();
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
