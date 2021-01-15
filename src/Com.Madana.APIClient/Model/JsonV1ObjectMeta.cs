/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.34
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
    /// JsonV1ObjectMeta
    /// </summary>
    [DataContract]
    public partial class JsonV1ObjectMeta :  IEquatable<JsonV1ObjectMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonV1ObjectMeta" /> class.
        /// </summary>
        /// <param name="labels">labels.</param>
        /// <param name="generation">generation.</param>
        /// <param name="resourceVersion">resourceVersion.</param>
        /// <param name="creationTimestamp">creationTimestamp.</param>
        /// <param name="finalizers">finalizers.</param>
        /// <param name="selfLink">selfLink.</param>
        /// <param name="generateName">generateName.</param>
        /// <param name="clusterName">clusterName.</param>
        /// <param name="managedFields">managedFields.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="uid">uid.</param>
        /// <param name="name">name.</param>
        /// <param name="ownerReferences">ownerReferences.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="deletionGracePeriodSeconds">deletionGracePeriodSeconds.</param>
        /// <param name="deletionTimestamp">deletionTimestamp.</param>
        public JsonV1ObjectMeta(Dictionary<string, string> labels = default(Dictionary<string, string>), decimal generation = default(decimal), string resourceVersion = default(string), decimal creationTimestamp = default(decimal), List<string> finalizers = default(List<string>), string selfLink = default(string), string generateName = default(string), string clusterName = default(string), List<JsonV1ManagedFieldsEntry> managedFields = default(List<JsonV1ManagedFieldsEntry>), string _namespace = default(string), string uid = default(string), string name = default(string), List<JsonV1OwnerReference> ownerReferences = default(List<JsonV1OwnerReference>), Dictionary<string, string> annotations = default(Dictionary<string, string>), decimal deletionGracePeriodSeconds = default(decimal), decimal deletionTimestamp = default(decimal))
        {
            this.Labels = labels;
            this.Generation = generation;
            this.ResourceVersion = resourceVersion;
            this.CreationTimestamp = creationTimestamp;
            this.Finalizers = finalizers;
            this.SelfLink = selfLink;
            this.GenerateName = generateName;
            this.ClusterName = clusterName;
            this.ManagedFields = managedFields;
            this.Namespace = _namespace;
            this.Uid = uid;
            this.Name = name;
            this.OwnerReferences = ownerReferences;
            this.Annotations = annotations;
            this.DeletionGracePeriodSeconds = deletionGracePeriodSeconds;
            this.DeletionTimestamp = deletionTimestamp;
        }
        
        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Gets or Sets Generation
        /// </summary>
        [DataMember(Name="generation", EmitDefaultValue=false)]
        public decimal Generation { get; set; }

        /// <summary>
        /// Gets or Sets ResourceVersion
        /// </summary>
        [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// Gets or Sets CreationTimestamp
        /// </summary>
        [DataMember(Name="creationTimestamp", EmitDefaultValue=false)]
        public decimal CreationTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Finalizers
        /// </summary>
        [DataMember(Name="finalizers", EmitDefaultValue=false)]
        public List<string> Finalizers { get; set; }

        /// <summary>
        /// Gets or Sets SelfLink
        /// </summary>
        [DataMember(Name="selfLink", EmitDefaultValue=false)]
        public string SelfLink { get; set; }

        /// <summary>
        /// Gets or Sets GenerateName
        /// </summary>
        [DataMember(Name="generateName", EmitDefaultValue=false)]
        public string GenerateName { get; set; }

        /// <summary>
        /// Gets or Sets ClusterName
        /// </summary>
        [DataMember(Name="clusterName", EmitDefaultValue=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or Sets ManagedFields
        /// </summary>
        [DataMember(Name="managedFields", EmitDefaultValue=false)]
        public List<JsonV1ManagedFieldsEntry> ManagedFields { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name="uid", EmitDefaultValue=false)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OwnerReferences
        /// </summary>
        [DataMember(Name="ownerReferences", EmitDefaultValue=false)]
        public List<JsonV1OwnerReference> OwnerReferences { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public Dictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// Gets or Sets DeletionGracePeriodSeconds
        /// </summary>
        [DataMember(Name="deletionGracePeriodSeconds", EmitDefaultValue=false)]
        public decimal DeletionGracePeriodSeconds { get; set; }

        /// <summary>
        /// Gets or Sets DeletionTimestamp
        /// </summary>
        [DataMember(Name="deletionTimestamp", EmitDefaultValue=false)]
        public decimal DeletionTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonV1ObjectMeta {\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Generation: ").Append(Generation).Append("\n");
            sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  CreationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  Finalizers: ").Append(Finalizers).Append("\n");
            sb.Append("  SelfLink: ").Append(SelfLink).Append("\n");
            sb.Append("  GenerateName: ").Append(GenerateName).Append("\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  ManagedFields: ").Append(ManagedFields).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerReferences: ").Append(OwnerReferences).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  DeletionGracePeriodSeconds: ").Append(DeletionGracePeriodSeconds).Append("\n");
            sb.Append("  DeletionTimestamp: ").Append(DeletionTimestamp).Append("\n");
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
            return this.Equals(input as JsonV1ObjectMeta);
        }

        /// <summary>
        /// Returns true if JsonV1ObjectMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonV1ObjectMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonV1ObjectMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Generation == input.Generation ||
                    (this.Generation != null &&
                    this.Generation.Equals(input.Generation))
                ) && 
                (
                    this.ResourceVersion == input.ResourceVersion ||
                    (this.ResourceVersion != null &&
                    this.ResourceVersion.Equals(input.ResourceVersion))
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                ) && 
                (
                    this.Finalizers == input.Finalizers ||
                    this.Finalizers != null &&
                    input.Finalizers != null &&
                    this.Finalizers.SequenceEqual(input.Finalizers)
                ) && 
                (
                    this.SelfLink == input.SelfLink ||
                    (this.SelfLink != null &&
                    this.SelfLink.Equals(input.SelfLink))
                ) && 
                (
                    this.GenerateName == input.GenerateName ||
                    (this.GenerateName != null &&
                    this.GenerateName.Equals(input.GenerateName))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.ManagedFields == input.ManagedFields ||
                    this.ManagedFields != null &&
                    input.ManagedFields != null &&
                    this.ManagedFields.SequenceEqual(input.ManagedFields)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerReferences == input.OwnerReferences ||
                    this.OwnerReferences != null &&
                    input.OwnerReferences != null &&
                    this.OwnerReferences.SequenceEqual(input.OwnerReferences)
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    this.Annotations != null &&
                    input.Annotations != null &&
                    this.Annotations.SequenceEqual(input.Annotations)
                ) && 
                (
                    this.DeletionGracePeriodSeconds == input.DeletionGracePeriodSeconds ||
                    (this.DeletionGracePeriodSeconds != null &&
                    this.DeletionGracePeriodSeconds.Equals(input.DeletionGracePeriodSeconds))
                ) && 
                (
                    this.DeletionTimestamp == input.DeletionTimestamp ||
                    (this.DeletionTimestamp != null &&
                    this.DeletionTimestamp.Equals(input.DeletionTimestamp))
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
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Generation != null)
                    hashCode = hashCode * 59 + this.Generation.GetHashCode();
                if (this.ResourceVersion != null)
                    hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.Finalizers != null)
                    hashCode = hashCode * 59 + this.Finalizers.GetHashCode();
                if (this.SelfLink != null)
                    hashCode = hashCode * 59 + this.SelfLink.GetHashCode();
                if (this.GenerateName != null)
                    hashCode = hashCode * 59 + this.GenerateName.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.ManagedFields != null)
                    hashCode = hashCode * 59 + this.ManagedFields.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerReferences != null)
                    hashCode = hashCode * 59 + this.OwnerReferences.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.DeletionGracePeriodSeconds != null)
                    hashCode = hashCode * 59 + this.DeletionGracePeriodSeconds.GetHashCode();
                if (this.DeletionTimestamp != null)
                    hashCode = hashCode * 59 + this.DeletionTimestamp.GetHashCode();
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
