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
    /// JsonEnvironment
    /// </summary>
    [DataContract]
    public partial class JsonEnvironment :  IEquatable<JsonEnvironment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonEnvironment" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="description">description.</param>
        /// <param name="size">size.</param>
        /// <param name="rootHashOffset">rootHashOffset.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="packages">packages.</param>
        /// <param name="published">published.</param>
        /// <param name="name">name.</param>
        /// <param name="ipfsHash">ipfsHash.</param>
        /// <param name="roothash">roothash.</param>
        /// <param name="defaultRunConfiguration">defaultRunConfiguration.</param>
        public JsonEnvironment(List<string> content = default(List<string>), string description = default(string), string size = default(string), string rootHashOffset = default(string), string uuid = default(string), List<string> packages = default(List<string>), bool published = default(bool), string name = default(string), string ipfsHash = default(string), string roothash = default(string), JsonRunConfig defaultRunConfiguration = default(JsonRunConfig))
        {
            this.Content = content;
            this.Description = description;
            this.Size = size;
            this.RootHashOffset = rootHashOffset;
            this.Uuid = uuid;
            this.Packages = packages;
            this.Published = published;
            this.Name = name;
            this.IpfsHash = ipfsHash;
            this.Roothash = roothash;
            this.DefaultRunConfiguration = defaultRunConfiguration;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<string> Content { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets RootHashOffset
        /// </summary>
        [DataMember(Name="rootHashOffset", EmitDefaultValue=false)]
        public string RootHashOffset { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Packages
        /// </summary>
        [DataMember(Name="packages", EmitDefaultValue=false)]
        public List<string> Packages { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool Published { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IpfsHash
        /// </summary>
        [DataMember(Name="ipfsHash", EmitDefaultValue=false)]
        public string IpfsHash { get; set; }

        /// <summary>
        /// Gets or Sets Roothash
        /// </summary>
        [DataMember(Name="roothash", EmitDefaultValue=false)]
        public string Roothash { get; set; }

        /// <summary>
        /// Gets or Sets DefaultRunConfiguration
        /// </summary>
        [DataMember(Name="defaultRunConfiguration", EmitDefaultValue=false)]
        public JsonRunConfig DefaultRunConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonEnvironment {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  RootHashOffset: ").Append(RootHashOffset).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IpfsHash: ").Append(IpfsHash).Append("\n");
            sb.Append("  Roothash: ").Append(Roothash).Append("\n");
            sb.Append("  DefaultRunConfiguration: ").Append(DefaultRunConfiguration).Append("\n");
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
            return this.Equals(input as JsonEnvironment);
        }

        /// <summary>
        /// Returns true if JsonEnvironment instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonEnvironment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonEnvironment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    input.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.RootHashOffset == input.RootHashOffset ||
                    (this.RootHashOffset != null &&
                    this.RootHashOffset.Equals(input.RootHashOffset))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Packages == input.Packages ||
                    this.Packages != null &&
                    input.Packages != null &&
                    this.Packages.SequenceEqual(input.Packages)
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IpfsHash == input.IpfsHash ||
                    (this.IpfsHash != null &&
                    this.IpfsHash.Equals(input.IpfsHash))
                ) && 
                (
                    this.Roothash == input.Roothash ||
                    (this.Roothash != null &&
                    this.Roothash.Equals(input.Roothash))
                ) && 
                (
                    this.DefaultRunConfiguration == input.DefaultRunConfiguration ||
                    (this.DefaultRunConfiguration != null &&
                    this.DefaultRunConfiguration.Equals(input.DefaultRunConfiguration))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.RootHashOffset != null)
                    hashCode = hashCode * 59 + this.RootHashOffset.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Packages != null)
                    hashCode = hashCode * 59 + this.Packages.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IpfsHash != null)
                    hashCode = hashCode * 59 + this.IpfsHash.GetHashCode();
                if (this.Roothash != null)
                    hashCode = hashCode * 59 + this.Roothash.GetHashCode();
                if (this.DefaultRunConfiguration != null)
                    hashCode = hashCode * 59 + this.DefaultRunConfiguration.GetHashCode();
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
