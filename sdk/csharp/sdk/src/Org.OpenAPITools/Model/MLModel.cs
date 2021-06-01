/*
 * Contraxsuite API
 *
 * Contraxsuite API
 *
 * The version of the OpenAPI document: 2.0.0
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MLModel
    /// </summary>
    [DataContract]
    public partial class MLModel :  IEquatable<MLModel>, IValidatableObject
    {
        /// <summary>
        /// Should the model be applied to documents or text units
        /// </summary>
        /// <value>Should the model be applied to documents or text units</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplyToEnum
        {
            /// <summary>
            /// Enum Document for value: document
            /// </summary>
            [EnumMember(Value = "document")]
            Document = 1,

            /// <summary>
            /// Enum Textunit for value: text_unit
            /// </summary>
            [EnumMember(Value = "text_unit")]
            Textunit = 2

        }

        /// <summary>
        /// Should the model be applied to documents or text units
        /// </summary>
        /// <value>Should the model be applied to documents or text units</value>
        [DataMember(Name="apply_to", EmitDefaultValue=true)]
        public ApplyToEnum ApplyTo { get; set; }
        /// <summary>
        /// The model class
        /// </summary>
        /// <value>The model class</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetEntityEnum
        {
            /// <summary>
            /// Enum Transformer for value: transformer
            /// </summary>
            [EnumMember(Value = "transformer")]
            Transformer = 1,

            /// <summary>
            /// Enum Classifier for value: classifier
            /// </summary>
            [EnumMember(Value = "classifier")]
            Classifier = 2,

            /// <summary>
            /// Enum Contracttypeclassifier for value: contract_type_classifier
            /// </summary>
            [EnumMember(Value = "contract_type_classifier")]
            Contracttypeclassifier = 3

        }

        /// <summary>
        /// The model class
        /// </summary>
        /// <value>The model class</value>
        [DataMember(Name="target_entity", EmitDefaultValue=true)]
        public TargetEntityEnum TargetEntity { get; set; }
        /// <summary>
        /// Text unit type: sentence or paragraph
        /// </summary>
        /// <value>Text unit type: sentence or paragraph</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextUnitTypeEnum
        {
            /// <summary>
            /// Enum Sentence for value: sentence
            /// </summary>
            [EnumMember(Value = "sentence")]
            Sentence = 1,

            /// <summary>
            /// Enum Paragraph for value: paragraph
            /// </summary>
            [EnumMember(Value = "paragraph")]
            Paragraph = 2

        }

        /// <summary>
        /// Text unit type: sentence or paragraph
        /// </summary>
        /// <value>Text unit type: sentence or paragraph</value>
        [DataMember(Name="text_unit_type", EmitDefaultValue=true)]
        public TextUnitTypeEnum? TextUnitType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MLModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MLModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MLModel" /> class.
        /// </summary>
        /// <param name="name">Model name, may include module parameters (required).</param>
        /// <param name="version">Model version (required).</param>
        /// <param name="vectorName">vectorName.</param>
        /// <param name="modelPath">Model path, relative to WebDAV root folder (required).</param>
        /// <param name="isActive">Inactive models are ignored.</param>
        /// <param name="_default">The default model is used unless another model is deliberately selected.</param>
        /// <param name="applyTo">Should the model be applied to documents or text units (required).</param>
        /// <param name="targetEntity">The model class (required).</param>
        /// <param name="language">Language (ISO 693-1) code, may be omitted (required).</param>
        /// <param name="textUnitType">Text unit type: sentence or paragraph.</param>
        /// <param name="project">Optional project reference.</param>
        public MLModel(string name = default(string), string version = default(string), string vectorName = default(string), string modelPath = default(string), bool isActive = default(bool), bool _default = default(bool), ApplyToEnum applyTo = default(ApplyToEnum), TargetEntityEnum targetEntity = default(TargetEntityEnum), string language = default(string), TextUnitTypeEnum? textUnitType = default(TextUnitTypeEnum?), int? project = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for MLModel and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for MLModel and cannot be null");
            }
            else
            {
                this.Version = version;
            }

            this.VectorName = vectorName;
            // to ensure "modelPath" is required (not null)
            if (modelPath == null)
            {
                throw new InvalidDataException("modelPath is a required property for MLModel and cannot be null");
            }
            else
            {
                this.ModelPath = modelPath;
            }

            // to ensure "applyTo" is required (not null)
            if (applyTo == null)
            {
                throw new InvalidDataException("applyTo is a required property for MLModel and cannot be null");
            }
            else
            {
                this.ApplyTo = applyTo;
            }

            this.ApplyTo = applyTo;
            // to ensure "targetEntity" is required (not null)
            if (targetEntity == null)
            {
                throw new InvalidDataException("targetEntity is a required property for MLModel and cannot be null");
            }
            else
            {
                this.TargetEntity = targetEntity;
            }

            this.TargetEntity = targetEntity;
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for MLModel and cannot be null");
            }
            else
            {
                this.Language = language;
            }

            this.Language = language;
            this.TextUnitType = textUnitType;
            this.Project = project;
            this.VectorName = vectorName;
            this.IsActive = isActive;
            this.Default = _default;
            this.TextUnitType = textUnitType;
            this.Project = project;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; private set; }

        /// <summary>
        /// Model name, may include module parameters
        /// </summary>
        /// <value>Model name, may include module parameters</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Model version
        /// </summary>
        /// <value>Model version</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets VectorName
        /// </summary>
        [DataMember(Name="vector_name", EmitDefaultValue=true)]
        public string VectorName { get; set; }

        /// <summary>
        /// Model path, relative to WebDAV root folder
        /// </summary>
        /// <value>Model path, relative to WebDAV root folder</value>
        [DataMember(Name="model_path", EmitDefaultValue=true)]
        public string ModelPath { get; set; }

        /// <summary>
        /// Inactive models are ignored
        /// </summary>
        /// <value>Inactive models are ignored</value>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The default model is used unless another model is deliberately selected
        /// </summary>
        /// <value>The default model is used unless another model is deliberately selected</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool Default { get; set; }



        /// <summary>
        /// Language (ISO 693-1) code, may be omitted
        /// </summary>
        /// <value>Language (ISO 693-1) code, may be omitted</value>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }


        /// <summary>
        /// Optional project reference
        /// </summary>
        /// <value>Optional project reference</value>
        [DataMember(Name="project", EmitDefaultValue=true)]
        public int? Project { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MLModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VectorName: ").Append(VectorName).Append("\n");
            sb.Append("  ModelPath: ").Append(ModelPath).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  ApplyTo: ").Append(ApplyTo).Append("\n");
            sb.Append("  TargetEntity: ").Append(TargetEntity).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TextUnitType: ").Append(TextUnitType).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
            return this.Equals(input as MLModel);
        }

        /// <summary>
        /// Returns true if MLModel instances are equal
        /// </summary>
        /// <param name="input">Instance of MLModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MLModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.VectorName == input.VectorName ||
                    (this.VectorName != null &&
                    this.VectorName.Equals(input.VectorName))
                ) && 
                (
                    this.ModelPath == input.ModelPath ||
                    (this.ModelPath != null &&
                    this.ModelPath.Equals(input.ModelPath))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.ApplyTo == input.ApplyTo ||
                    (this.ApplyTo != null &&
                    this.ApplyTo.Equals(input.ApplyTo))
                ) && 
                (
                    this.TargetEntity == input.TargetEntity ||
                    (this.TargetEntity != null &&
                    this.TargetEntity.Equals(input.TargetEntity))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.TextUnitType == input.TextUnitType ||
                    (this.TextUnitType != null &&
                    this.TextUnitType.Equals(input.TextUnitType))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VectorName != null)
                    hashCode = hashCode * 59 + this.VectorName.GetHashCode();
                if (this.ModelPath != null)
                    hashCode = hashCode * 59 + this.ModelPath.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.ApplyTo != null)
                    hashCode = hashCode * 59 + this.ApplyTo.GetHashCode();
                if (this.TargetEntity != null)
                    hashCode = hashCode * 59 + this.TargetEntity.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TextUnitType != null)
                    hashCode = hashCode * 59 + this.TextUnitType.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 1024.", new [] { "Name" });
            }

 
            // Version (string) maxLength
            if(this.Version != null && this.Version.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, length must be less than 1024.", new [] { "Version" });
            }

 
            // VectorName (string) maxLength
            if(this.VectorName != null && this.VectorName.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VectorName, length must be less than 1024.", new [] { "VectorName" });
            }

 
            // ModelPath (string) maxLength
            if(this.ModelPath != null && this.ModelPath.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModelPath, length must be less than 1024.", new [] { "ModelPath" });
            }

 
            // Language (string) maxLength
            if(this.Language != null && this.Language.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be less than 12.", new [] { "Language" });
            }

 
            yield break;
        }
    }

}