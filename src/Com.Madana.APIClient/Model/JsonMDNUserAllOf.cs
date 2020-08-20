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
    /// JsonMDNUserAllOf
    /// </summary>
    [DataContract]
    public partial class JsonMDNUserAllOf :  IEquatable<JsonMDNUserAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonMDNUserAllOf" /> class.
        /// </summary>
        /// <param name="mail">mail.</param>
        /// <param name="guid">guid.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="socialAccounts">socialAccounts.</param>
        /// <param name="settings">settings.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="credentials">credentials.</param>
        public JsonMDNUserAllOf(string mail = default(string), string guid = default(string), string lastName = default(string), List<JsonMDNSocialUserObject> socialAccounts = default(List<JsonMDNSocialUserObject>), List<JsonMDNUserSetting> settings = default(List<JsonMDNUserSetting>), string firstName = default(string), JsonMDNUserCredentials credentials = default(JsonMDNUserCredentials))
        {
            this.Mail = mail;
            this.Guid = guid;
            this.LastName = lastName;
            this.SocialAccounts = socialAccounts;
            this.Settings = settings;
            this.FirstName = firstName;
            this.Credentials = credentials;
        }
        
        /// <summary>
        /// Gets or Sets Mail
        /// </summary>
        [DataMember(Name="mail", EmitDefaultValue=false)]
        public string Mail { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets SocialAccounts
        /// </summary>
        [DataMember(Name="socialAccounts", EmitDefaultValue=false)]
        public List<JsonMDNSocialUserObject> SocialAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<JsonMDNUserSetting> Settings { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public JsonMDNUserCredentials Credentials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonMDNUserAllOf {\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  SocialAccounts: ").Append(SocialAccounts).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
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
            return this.Equals(input as JsonMDNUserAllOf);
        }

        /// <summary>
        /// Returns true if JsonMDNUserAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonMDNUserAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonMDNUserAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.SocialAccounts == input.SocialAccounts ||
                    this.SocialAccounts != null &&
                    input.SocialAccounts != null &&
                    this.SocialAccounts.SequenceEqual(input.SocialAccounts)
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
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
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.SocialAccounts != null)
                    hashCode = hashCode * 59 + this.SocialAccounts.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
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