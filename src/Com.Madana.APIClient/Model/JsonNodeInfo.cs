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
    /// JsonNodeInfo
    /// </summary>
    [DataContract]
    public partial class JsonNodeInfo :  IEquatable<JsonNodeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonNodeInfo" /> class.
        /// </summary>
        /// <param name="cpuModel">cpuModel.</param>
        /// <param name="hardwareFirmware">hardwareFirmware.</param>
        /// <param name="owner">owner.</param>
        /// <param name="hardwareBaseboard">hardwareBaseboard.</param>
        /// <param name="cpuFamily">cpuFamily.</param>
        /// <param name="operatingSystem">operatingSystem.</param>
        /// <param name="ipfsInfo">ipfsInfo.</param>
        /// <param name="publicKey">publicKey.</param>
        /// <param name="operatingSystemUptime">operatingSystemUptime.</param>
        /// <param name="cpuPhysicalCores">cpuPhysicalCores.</param>
        /// <param name="cpuLogicalCount">cpuLogicalCount.</param>
        /// <param name="memory">memory.</param>
        /// <param name="status">status.</param>
        /// <param name="cpuFrequency">cpuFrequency.</param>
        /// <param name="processors">processors.</param>
        /// <param name="sgxInfo">sgxInfo.</param>
        /// <param name="connectionURL">connectionURL.</param>
        public JsonNodeInfo(string cpuModel = default(string), string hardwareFirmware = default(string), string owner = default(string), string hardwareBaseboard = default(string), string cpuFamily = default(string), string operatingSystem = default(string), JsonIPFSSystemInfo ipfsInfo = default(JsonIPFSSystemInfo), string publicKey = default(string), decimal operatingSystemUptime = default(decimal), int cpuPhysicalCores = default(int), int cpuLogicalCount = default(int), string memory = default(string), string status = default(string), string cpuFrequency = default(string), List<string> processors = default(List<string>), JsonSGXInfo sgxInfo = default(JsonSGXInfo), string connectionURL = default(string))
        {
            this.CpuModel = cpuModel;
            this.HardwareFirmware = hardwareFirmware;
            this.Owner = owner;
            this.HardwareBaseboard = hardwareBaseboard;
            this.CpuFamily = cpuFamily;
            this.OperatingSystem = operatingSystem;
            this.IpfsInfo = ipfsInfo;
            this.PublicKey = publicKey;
            this.OperatingSystemUptime = operatingSystemUptime;
            this.CpuPhysicalCores = cpuPhysicalCores;
            this.CpuLogicalCount = cpuLogicalCount;
            this.Memory = memory;
            this.Status = status;
            this.CpuFrequency = cpuFrequency;
            this.Processors = processors;
            this.SgxInfo = sgxInfo;
            this.ConnectionURL = connectionURL;
        }
        
        /// <summary>
        /// Gets or Sets CpuModel
        /// </summary>
        [DataMember(Name="cpuModel", EmitDefaultValue=false)]
        public string CpuModel { get; set; }

        /// <summary>
        /// Gets or Sets HardwareFirmware
        /// </summary>
        [DataMember(Name="hardwareFirmware", EmitDefaultValue=false)]
        public string HardwareFirmware { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets HardwareBaseboard
        /// </summary>
        [DataMember(Name="hardwareBaseboard", EmitDefaultValue=false)]
        public string HardwareBaseboard { get; set; }

        /// <summary>
        /// Gets or Sets CpuFamily
        /// </summary>
        [DataMember(Name="cpuFamily", EmitDefaultValue=false)]
        public string CpuFamily { get; set; }

        /// <summary>
        /// Gets or Sets OperatingSystem
        /// </summary>
        [DataMember(Name="operatingSystem", EmitDefaultValue=false)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or Sets IpfsInfo
        /// </summary>
        [DataMember(Name="ipfsInfo", EmitDefaultValue=false)]
        public JsonIPFSSystemInfo IpfsInfo { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name="publicKey", EmitDefaultValue=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets OperatingSystemUptime
        /// </summary>
        [DataMember(Name="operatingSystemUptime", EmitDefaultValue=false)]
        public decimal OperatingSystemUptime { get; set; }

        /// <summary>
        /// Gets or Sets CpuPhysicalCores
        /// </summary>
        [DataMember(Name="cpuPhysicalCores", EmitDefaultValue=false)]
        public int CpuPhysicalCores { get; set; }

        /// <summary>
        /// Gets or Sets CpuLogicalCount
        /// </summary>
        [DataMember(Name="cpuLogicalCount", EmitDefaultValue=false)]
        public int CpuLogicalCount { get; set; }

        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name="memory", EmitDefaultValue=false)]
        public string Memory { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CpuFrequency
        /// </summary>
        [DataMember(Name="cpuFrequency", EmitDefaultValue=false)]
        public string CpuFrequency { get; set; }

        /// <summary>
        /// Gets or Sets Processors
        /// </summary>
        [DataMember(Name="processors", EmitDefaultValue=false)]
        public List<string> Processors { get; set; }

        /// <summary>
        /// Gets or Sets SgxInfo
        /// </summary>
        [DataMember(Name="sgxInfo", EmitDefaultValue=false)]
        public JsonSGXInfo SgxInfo { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionURL
        /// </summary>
        [DataMember(Name="connectionURL", EmitDefaultValue=false)]
        public string ConnectionURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonNodeInfo {\n");
            sb.Append("  CpuModel: ").Append(CpuModel).Append("\n");
            sb.Append("  HardwareFirmware: ").Append(HardwareFirmware).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  HardwareBaseboard: ").Append(HardwareBaseboard).Append("\n");
            sb.Append("  CpuFamily: ").Append(CpuFamily).Append("\n");
            sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
            sb.Append("  IpfsInfo: ").Append(IpfsInfo).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  OperatingSystemUptime: ").Append(OperatingSystemUptime).Append("\n");
            sb.Append("  CpuPhysicalCores: ").Append(CpuPhysicalCores).Append("\n");
            sb.Append("  CpuLogicalCount: ").Append(CpuLogicalCount).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CpuFrequency: ").Append(CpuFrequency).Append("\n");
            sb.Append("  Processors: ").Append(Processors).Append("\n");
            sb.Append("  SgxInfo: ").Append(SgxInfo).Append("\n");
            sb.Append("  ConnectionURL: ").Append(ConnectionURL).Append("\n");
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
            return this.Equals(input as JsonNodeInfo);
        }

        /// <summary>
        /// Returns true if JsonNodeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonNodeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonNodeInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CpuModel == input.CpuModel ||
                    (this.CpuModel != null &&
                    this.CpuModel.Equals(input.CpuModel))
                ) && 
                (
                    this.HardwareFirmware == input.HardwareFirmware ||
                    (this.HardwareFirmware != null &&
                    this.HardwareFirmware.Equals(input.HardwareFirmware))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.HardwareBaseboard == input.HardwareBaseboard ||
                    (this.HardwareBaseboard != null &&
                    this.HardwareBaseboard.Equals(input.HardwareBaseboard))
                ) && 
                (
                    this.CpuFamily == input.CpuFamily ||
                    (this.CpuFamily != null &&
                    this.CpuFamily.Equals(input.CpuFamily))
                ) && 
                (
                    this.OperatingSystem == input.OperatingSystem ||
                    (this.OperatingSystem != null &&
                    this.OperatingSystem.Equals(input.OperatingSystem))
                ) && 
                (
                    this.IpfsInfo == input.IpfsInfo ||
                    (this.IpfsInfo != null &&
                    this.IpfsInfo.Equals(input.IpfsInfo))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.OperatingSystemUptime == input.OperatingSystemUptime ||
                    (this.OperatingSystemUptime != null &&
                    this.OperatingSystemUptime.Equals(input.OperatingSystemUptime))
                ) && 
                (
                    this.CpuPhysicalCores == input.CpuPhysicalCores ||
                    (this.CpuPhysicalCores != null &&
                    this.CpuPhysicalCores.Equals(input.CpuPhysicalCores))
                ) && 
                (
                    this.CpuLogicalCount == input.CpuLogicalCount ||
                    (this.CpuLogicalCount != null &&
                    this.CpuLogicalCount.Equals(input.CpuLogicalCount))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CpuFrequency == input.CpuFrequency ||
                    (this.CpuFrequency != null &&
                    this.CpuFrequency.Equals(input.CpuFrequency))
                ) && 
                (
                    this.Processors == input.Processors ||
                    this.Processors != null &&
                    input.Processors != null &&
                    this.Processors.SequenceEqual(input.Processors)
                ) && 
                (
                    this.SgxInfo == input.SgxInfo ||
                    (this.SgxInfo != null &&
                    this.SgxInfo.Equals(input.SgxInfo))
                ) && 
                (
                    this.ConnectionURL == input.ConnectionURL ||
                    (this.ConnectionURL != null &&
                    this.ConnectionURL.Equals(input.ConnectionURL))
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
                if (this.CpuModel != null)
                    hashCode = hashCode * 59 + this.CpuModel.GetHashCode();
                if (this.HardwareFirmware != null)
                    hashCode = hashCode * 59 + this.HardwareFirmware.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.HardwareBaseboard != null)
                    hashCode = hashCode * 59 + this.HardwareBaseboard.GetHashCode();
                if (this.CpuFamily != null)
                    hashCode = hashCode * 59 + this.CpuFamily.GetHashCode();
                if (this.OperatingSystem != null)
                    hashCode = hashCode * 59 + this.OperatingSystem.GetHashCode();
                if (this.IpfsInfo != null)
                    hashCode = hashCode * 59 + this.IpfsInfo.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.OperatingSystemUptime != null)
                    hashCode = hashCode * 59 + this.OperatingSystemUptime.GetHashCode();
                if (this.CpuPhysicalCores != null)
                    hashCode = hashCode * 59 + this.CpuPhysicalCores.GetHashCode();
                if (this.CpuLogicalCount != null)
                    hashCode = hashCode * 59 + this.CpuLogicalCount.GetHashCode();
                if (this.Memory != null)
                    hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CpuFrequency != null)
                    hashCode = hashCode * 59 + this.CpuFrequency.GetHashCode();
                if (this.Processors != null)
                    hashCode = hashCode * 59 + this.Processors.GetHashCode();
                if (this.SgxInfo != null)
                    hashCode = hashCode * 59 + this.SgxInfo.GetHashCode();
                if (this.ConnectionURL != null)
                    hashCode = hashCode * 59 + this.ConnectionURL.GetHashCode();
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
