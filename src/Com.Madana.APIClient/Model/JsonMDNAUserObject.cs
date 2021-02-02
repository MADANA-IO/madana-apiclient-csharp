/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.46
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
    /// JsonMDNAUserObject
    /// </summary>
    [DataContract]
    public partial class JsonMDNAUserObject :  IEquatable<JsonMDNAUserObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonMDNAUserObject" /> class.
        /// </summary>
        /// <param name="image">image.</param>
        /// <param name="created">created.</param>
        /// <param name="lastActive">lastActive.</param>
        /// <param name="activated">activated.</param>
        /// <param name="userName">userName.</param>
        public JsonMDNAUserObject(string image = default(string), string created = default(string), string lastActive = default(string), string activated = default(string), string userName = default(string))
        {
            this.Image = image;
            this.Created = created;
            this.LastActive = lastActive;
            this.Activated = activated;
            this.UserName = userName;
        }
        
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets LastActive
        /// </summary>
        [DataMember(Name="lastActive", EmitDefaultValue=false)]
        public string LastActive { get; set; }

        /// <summary>
        /// Gets or Sets Activated
        /// </summary>
        [DataMember(Name="activated", EmitDefaultValue=false)]
        public string Activated { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonMDNAUserObject {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastActive: ").Append(LastActive).Append("\n");
            sb.Append("  Activated: ").Append(Activated).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as JsonMDNAUserObject);
        }

        /// <summary>
        /// Returns true if JsonMDNAUserObject instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonMDNAUserObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonMDNAUserObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.LastActive == input.LastActive ||
                    (this.LastActive != null &&
                    this.LastActive.Equals(input.LastActive))
                ) && 
                (
                    this.Activated == input.Activated ||
                    (this.Activated != null &&
                    this.Activated.Equals(input.Activated))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.LastActive != null)
                    hashCode = hashCode * 59 + this.LastActive.GetHashCode();
                if (this.Activated != null)
                    hashCode = hashCode * 59 + this.Activated.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
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
