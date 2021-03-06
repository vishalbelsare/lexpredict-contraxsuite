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
    /// ProjectCreate
    /// </summary>
    [DataContract]
    public partial class ProjectCreate :  IEquatable<ProjectCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreate" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="sendEmailNotification">sendEmailNotification.</param>
        /// <param name="termTags">termTags.</param>
        /// <param name="companytypeTags">companytypeTags.</param>
        public ProjectCreate(string name = default(string), string description = default(string), string type = default(string), bool sendEmailNotification = default(bool), List<int> termTags = default(List<int>), List<int> companytypeTags = default(List<int>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProjectCreate and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Description = description;
            this.Type = type;
            this.Description = description;
            this.Type = type;
            this.SendEmailNotification = sendEmailNotification;
            this.TermTags = termTags;
            this.CompanytypeTags = companytypeTags;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SendEmailNotification
        /// </summary>
        [DataMember(Name="send_email_notification", EmitDefaultValue=false)]
        public bool SendEmailNotification { get; set; }

        /// <summary>
        /// Gets or Sets TermTags
        /// </summary>
        [DataMember(Name="term_tags", EmitDefaultValue=false)]
        public List<int> TermTags { get; set; }

        /// <summary>
        /// Gets or Sets CompanytypeTags
        /// </summary>
        [DataMember(Name="companytype_tags", EmitDefaultValue=false)]
        public List<int> CompanytypeTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectCreate {\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SendEmailNotification: ").Append(SendEmailNotification).Append("\n");
            sb.Append("  TermTags: ").Append(TermTags).Append("\n");
            sb.Append("  CompanytypeTags: ").Append(CompanytypeTags).Append("\n");
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
            return this.Equals(input as ProjectCreate);
        }

        /// <summary>
        /// Returns true if ProjectCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectCreate input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SendEmailNotification == input.SendEmailNotification ||
                    (this.SendEmailNotification != null &&
                    this.SendEmailNotification.Equals(input.SendEmailNotification))
                ) && 
                (
                    this.TermTags == input.TermTags ||
                    this.TermTags != null &&
                    input.TermTags != null &&
                    this.TermTags.SequenceEqual(input.TermTags)
                ) && 
                (
                    this.CompanytypeTags == input.CompanytypeTags ||
                    this.CompanytypeTags != null &&
                    input.CompanytypeTags != null &&
                    this.CompanytypeTags.SequenceEqual(input.CompanytypeTags)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SendEmailNotification != null)
                    hashCode = hashCode * 59 + this.SendEmailNotification.GetHashCode();
                if (this.TermTags != null)
                    hashCode = hashCode * 59 + this.TermTags.GetHashCode();
                if (this.CompanytypeTags != null)
                    hashCode = hashCode * 59 + this.CompanytypeTags.GetHashCode();
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
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

 
            yield break;
        }
    }

}
