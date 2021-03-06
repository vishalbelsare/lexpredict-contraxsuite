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
    /// ProjectDocumentSimilarity
    /// </summary>
    [DataContract]
    public partial class ProjectDocumentSimilarity :  IEquatable<ProjectDocumentSimilarity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDocumentSimilarity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectDocumentSimilarity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDocumentSimilarity" /> class.
        /// </summary>
        /// <param name="documentAName">documentAName (required).</param>
        /// <param name="documentBName">documentBName (required).</param>
        /// <param name="documentBText">documentBText (required).</param>
        /// <param name="similarity">similarity (required).</param>
        public ProjectDocumentSimilarity(string documentAName = default(string), string documentBName = default(string), string documentBText = default(string), decimal similarity = default(decimal))
        {
            // to ensure "documentAName" is required (not null)
            if (documentAName == null)
            {
                throw new InvalidDataException("documentAName is a required property for ProjectDocumentSimilarity and cannot be null");
            }
            else
            {
                this.DocumentAName = documentAName;
            }

            // to ensure "documentBName" is required (not null)
            if (documentBName == null)
            {
                throw new InvalidDataException("documentBName is a required property for ProjectDocumentSimilarity and cannot be null");
            }
            else
            {
                this.DocumentBName = documentBName;
            }

            // to ensure "documentBText" is required (not null)
            if (documentBText == null)
            {
                throw new InvalidDataException("documentBText is a required property for ProjectDocumentSimilarity and cannot be null");
            }
            else
            {
                this.DocumentBText = documentBText;
            }

            // to ensure "similarity" is required (not null)
            if (similarity == null)
            {
                throw new InvalidDataException("similarity is a required property for ProjectDocumentSimilarity and cannot be null");
            }
            else
            {
                this.Similarity = similarity;
            }

        }

        /// <summary>
        /// Gets or Sets DocumentAName
        /// </summary>
        [DataMember(Name="document_a_name", EmitDefaultValue=true)]
        public string DocumentAName { get; set; }

        /// <summary>
        /// Gets or Sets DocumentAId
        /// </summary>
        [DataMember(Name="document_a_id", EmitDefaultValue=false)]
        public string DocumentAId { get; private set; }

        /// <summary>
        /// Gets or Sets DocumentBName
        /// </summary>
        [DataMember(Name="document_b_name", EmitDefaultValue=true)]
        public string DocumentBName { get; set; }

        /// <summary>
        /// Gets or Sets DocumentBId
        /// </summary>
        [DataMember(Name="document_b_id", EmitDefaultValue=false)]
        public string DocumentBId { get; private set; }

        /// <summary>
        /// Gets or Sets DocumentBText
        /// </summary>
        [DataMember(Name="document_b_text", EmitDefaultValue=true)]
        public string DocumentBText { get; set; }

        /// <summary>
        /// Gets or Sets Similarity
        /// </summary>
        [DataMember(Name="similarity", EmitDefaultValue=true)]
        public decimal Similarity { get; set; }

        /// <summary>
        /// Gets or Sets RunId
        /// </summary>
        [DataMember(Name="run_id", EmitDefaultValue=false)]
        public string RunId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectDocumentSimilarity {\n");
            sb.Append("  DocumentAName: ").Append(DocumentAName).Append("\n");
            sb.Append("  DocumentAId: ").Append(DocumentAId).Append("\n");
            sb.Append("  DocumentBName: ").Append(DocumentBName).Append("\n");
            sb.Append("  DocumentBId: ").Append(DocumentBId).Append("\n");
            sb.Append("  DocumentBText: ").Append(DocumentBText).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
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
            return this.Equals(input as ProjectDocumentSimilarity);
        }

        /// <summary>
        /// Returns true if ProjectDocumentSimilarity instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectDocumentSimilarity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectDocumentSimilarity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentAName == input.DocumentAName ||
                    (this.DocumentAName != null &&
                    this.DocumentAName.Equals(input.DocumentAName))
                ) && 
                (
                    this.DocumentAId == input.DocumentAId ||
                    (this.DocumentAId != null &&
                    this.DocumentAId.Equals(input.DocumentAId))
                ) && 
                (
                    this.DocumentBName == input.DocumentBName ||
                    (this.DocumentBName != null &&
                    this.DocumentBName.Equals(input.DocumentBName))
                ) && 
                (
                    this.DocumentBId == input.DocumentBId ||
                    (this.DocumentBId != null &&
                    this.DocumentBId.Equals(input.DocumentBId))
                ) && 
                (
                    this.DocumentBText == input.DocumentBText ||
                    (this.DocumentBText != null &&
                    this.DocumentBText.Equals(input.DocumentBText))
                ) && 
                (
                    this.Similarity == input.Similarity ||
                    (this.Similarity != null &&
                    this.Similarity.Equals(input.Similarity))
                ) && 
                (
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
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
                if (this.DocumentAName != null)
                    hashCode = hashCode * 59 + this.DocumentAName.GetHashCode();
                if (this.DocumentAId != null)
                    hashCode = hashCode * 59 + this.DocumentAId.GetHashCode();
                if (this.DocumentBName != null)
                    hashCode = hashCode * 59 + this.DocumentBName.GetHashCode();
                if (this.DocumentBId != null)
                    hashCode = hashCode * 59 + this.DocumentBId.GetHashCode();
                if (this.DocumentBText != null)
                    hashCode = hashCode * 59 + this.DocumentBText.GetHashCode();
                if (this.Similarity != null)
                    hashCode = hashCode * 59 + this.Similarity.GetHashCode();
                if (this.RunId != null)
                    hashCode = hashCode * 59 + this.RunId.GetHashCode();
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
