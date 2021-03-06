/* 
 * madana-api
 *
 * <h1>API Quickstart Guide</h1>        <p>This documentation contains a Quickstart Guide, a few <a href=\"downloads.html\">sample clients</a>  for download and information about the available  <a href=\"resources.html\">endpoints</a>  and  <a href=\"data.html\">DataTypes</a>  </p>     <p>The <a target=\"_blank\" href=\"http://madana-explorer-staging.eu-central-1.elasticbeanstalk.com/login\">  MADANA Explorer</a> can be used to verify the interactions with the API</p>           <p>Internal use only. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a></p>         <br> <br>
 *
 * The version of the OpenAPI document: 0.4.12
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
    /// JsonAnalysisVisualization
    /// </summary>
    [DataContract]
    public partial class JsonAnalysisVisualization :  IEquatable<JsonAnalysisVisualization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonAnalysisVisualization" /> class.
        /// </summary>
        /// <param name="function">function.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="scriptsrc">scriptsrc.</param>
        public JsonAnalysisVisualization(string function = default(string), List<string> parameters = default(List<string>), string scriptsrc = default(string))
        {
            this.Function = function;
            this.Parameters = parameters;
            this.Scriptsrc = scriptsrc;
        }
        
        /// <summary>
        /// Gets or Sets Function
        /// </summary>
        [DataMember(Name="function", EmitDefaultValue=false)]
        public string Function { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Scriptsrc
        /// </summary>
        [DataMember(Name="scriptsrc", EmitDefaultValue=false)]
        public string Scriptsrc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonAnalysisVisualization {\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Scriptsrc: ").Append(Scriptsrc).Append("\n");
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
            return this.Equals(input as JsonAnalysisVisualization);
        }

        /// <summary>
        /// Returns true if JsonAnalysisVisualization instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonAnalysisVisualization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonAnalysisVisualization input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Function == input.Function ||
                    (this.Function != null &&
                    this.Function.Equals(input.Function))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Scriptsrc == input.Scriptsrc ||
                    (this.Scriptsrc != null &&
                    this.Scriptsrc.Equals(input.Scriptsrc))
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
                if (this.Function != null)
                    hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Scriptsrc != null)
                    hashCode = hashCode * 59 + this.Scriptsrc.GetHashCode();
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
