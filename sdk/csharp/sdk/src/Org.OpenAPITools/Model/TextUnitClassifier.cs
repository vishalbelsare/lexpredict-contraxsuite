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
    /// TextUnitClassifier
    /// </summary>
    [DataContract]
    public partial class TextUnitClassifier :  IEquatable<TextUnitClassifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextUnitClassifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextUnitClassifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextUnitClassifier" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="className">className (required).</param>
        /// <param name="isActive">isActive.</param>
        public TextUnitClassifier(string name = default(string), string version = default(string), string className = default(string), bool isActive = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TextUnitClassifier and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for TextUnitClassifier and cannot be null");
            }
            else
            {
                this.Version = version;
            }

            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new InvalidDataException("className is a required property for TextUnitClassifier and cannot be null");
            }
            else
            {
                this.ClassName = className;
            }

            this.IsActive = isActive;
        }

        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name="pk", EmitDefaultValue=false)]
        public int Pk { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name="class_name", EmitDefaultValue=true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Suggestions
        /// </summary>
        [DataMember(Name="suggestions", EmitDefaultValue=false)]
        public int Suggestions { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextUnitClassifier {\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            return this.Equals(input as TextUnitClassifier);
        }

        /// <summary>
        /// Returns true if TextUnitClassifier instances are equal
        /// </summary>
        /// <param name="input">Instance of TextUnitClassifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextUnitClassifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pk == input.Pk ||
                    (this.Pk != null &&
                    this.Pk.Equals(input.Pk))
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
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    (this.Suggestions != null &&
                    this.Suggestions.Equals(input.Suggestions))
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
                if (this.Pk != null)
                    hashCode = hashCode * 59 + this.Pk.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Suggestions != null)
                    hashCode = hashCode * 59 + this.Suggestions.GetHashCode();
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

 
            // ClassName (string) maxLength
            if(this.ClassName != null && this.ClassName.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassName, length must be less than 1024.", new [] { "ClassName" });
            }

 
            yield break;
        }
    }

}
