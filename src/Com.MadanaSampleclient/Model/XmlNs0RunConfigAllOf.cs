/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.4.14-master.16
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
using OpenAPIDateConverter = Com.MadanaSampleclient.Client.OpenAPIDateConverter;

namespace Com.MadanaSampleclient.Model
{
    /// <summary>
    /// XmlNs0RunConfigAllOf
    /// </summary>
    [DataContract]
    public partial class XmlNs0RunConfigAllOf :  IEquatable<XmlNs0RunConfigAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlNs0RunConfigAllOf" /> class.
        /// </summary>
        /// <param name="args">args.</param>
        /// <param name="diskConfig">diskConfig.</param>
        /// <param name="environment">environment.</param>
        /// <param name="run">run.</param>
        public XmlNs0RunConfigAllOf(List<string> args = default(List<string>), List<XmlNs0DiskConfig> diskConfig = default(List<XmlNs0DiskConfig>), Object environment = default(Object), string run = default(string))
        {
            this.Args = args;
            this.DiskConfig = diskConfig;
            this.Environment = environment;
            this.Run = run;
        }
        
        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// Gets or Sets DiskConfig
        /// </summary>
        [DataMember(Name="disk_config", EmitDefaultValue=false)]
        public List<XmlNs0DiskConfig> DiskConfig { get; set; }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Object Environment { get; set; }

        /// <summary>
        /// Gets or Sets Run
        /// </summary>
        [DataMember(Name="run", EmitDefaultValue=false)]
        public string Run { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlNs0RunConfigAllOf {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  DiskConfig: ").Append(DiskConfig).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Run: ").Append(Run).Append("\n");
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
            return this.Equals(input as XmlNs0RunConfigAllOf);
        }

        /// <summary>
        /// Returns true if XmlNs0RunConfigAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of XmlNs0RunConfigAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmlNs0RunConfigAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) && 
                (
                    this.DiskConfig == input.DiskConfig ||
                    this.DiskConfig != null &&
                    input.DiskConfig != null &&
                    this.DiskConfig.SequenceEqual(input.DiskConfig)
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.Run == input.Run ||
                    (this.Run != null &&
                    this.Run.Equals(input.Run))
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
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.DiskConfig != null)
                    hashCode = hashCode * 59 + this.DiskConfig.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.Run != null)
                    hashCode = hashCode * 59 + this.Run.GetHashCode();
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