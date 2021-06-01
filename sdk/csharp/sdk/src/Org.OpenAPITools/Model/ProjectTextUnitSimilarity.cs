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
    /// ProjectTextUnitSimilarity
    /// </summary>
    [DataContract]
    public partial class ProjectTextUnitSimilarity :  IEquatable<ProjectTextUnitSimilarity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTextUnitSimilarity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectTextUnitSimilarity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTextUnitSimilarity" /> class.
        /// </summary>
        /// <param name="documentAName">documentAName (required).</param>
        /// <param name="textUnitAText">textUnitAText (required).</param>
        /// <param name="documentBName">documentBName (required).</param>
        /// <param name="textUnitBText">textUnitBText (required).</param>
        /// <param name="similarity">similarity (required).</param>
        public ProjectTextUnitSimilarity(string documentAName = default(string), string textUnitAText = default(string), string documentBName = default(string), string textUnitBText = default(string), decimal similarity = default(decimal))
        {
            // to ensure "documentAName" is required (not null)
            if (documentAName == null)
            {
                throw new InvalidDataException("documentAName is a required property for ProjectTextUnitSimilarity and cannot be null");
            }
            else
            {
                this.DocumentAName = documentAName;
            }

            // to ensure "textUnitAText" is required (not null)
            if (textUnitAText == null)
            {
                throw new InvalidDataException("textUnitAText is a required property for ProjectTextUnitSimilarity and cannot be null");
            }
            else
            {
                this.TextUnitAText = textUnitAText;
            }

            // to ensure "documentBName" is required (not null)
            if (documentBName == null)
            {
                throw new InvalidDataException("documentBName is a required property for ProjectTextUnitSimilarity and cannot be null");
            }
            else
            {
                this.DocumentBName = documentBName;
            }

            // to ensure "textUnitBText" is required (not null)
            if (textUnitBText == null)
            {
                throw new InvalidDataException("textUnitBText is a required property for ProjectTextUnitSimilarity and cannot be null");
            }
            else
            {
                this.TextUnitBText = textUnitBText;
            }

            // to ensure "similarity" is required (not null)
            if (similarity == null)
            {
                throw new InvalidDataException("similarity is a required property for ProjectTextUnitSimilarity and cannot be null");
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
        /// Gets or Sets TextUnitAId
        /// </summary>
        [DataMember(Name="text_unit_a_id", EmitDefaultValue=false)]
        public string TextUnitAId { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitAText
        /// </summary>
        [DataMember(Name="text_unit_a_text", EmitDefaultValue=true)]
        public string TextUnitAText { get; set; }

        /// <summary>
        /// Gets or Sets TextUnitAUnitType
        /// </summary>
        [DataMember(Name="text_unit_a__unit_type", EmitDefaultValue=false)]
        public string TextUnitAUnitType { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitALocationStart
        /// </summary>
        [DataMember(Name="text_unit_a__location_start", EmitDefaultValue=false)]
        public string TextUnitALocationStart { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitALocationEnd
        /// </summary>
        [DataMember(Name="text_unit_a__location_end", EmitDefaultValue=false)]
        public string TextUnitALocationEnd { get; private set; }

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
        /// Gets or Sets TextUnitBId
        /// </summary>
        [DataMember(Name="text_unit_b_id", EmitDefaultValue=false)]
        public string TextUnitBId { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitBText
        /// </summary>
        [DataMember(Name="text_unit_b_text", EmitDefaultValue=true)]
        public string TextUnitBText { get; set; }

        /// <summary>
        /// Gets or Sets TextUnitBLocationStart
        /// </summary>
        [DataMember(Name="text_unit_b__location_start", EmitDefaultValue=false)]
        public string TextUnitBLocationStart { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitBLocationEnd
        /// </summary>
        [DataMember(Name="text_unit_b__location_end", EmitDefaultValue=false)]
        public string TextUnitBLocationEnd { get; private set; }

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
            sb.Append("class ProjectTextUnitSimilarity {\n");
            sb.Append("  DocumentAName: ").Append(DocumentAName).Append("\n");
            sb.Append("  DocumentAId: ").Append(DocumentAId).Append("\n");
            sb.Append("  TextUnitAId: ").Append(TextUnitAId).Append("\n");
            sb.Append("  TextUnitAText: ").Append(TextUnitAText).Append("\n");
            sb.Append("  TextUnitAUnitType: ").Append(TextUnitAUnitType).Append("\n");
            sb.Append("  TextUnitALocationStart: ").Append(TextUnitALocationStart).Append("\n");
            sb.Append("  TextUnitALocationEnd: ").Append(TextUnitALocationEnd).Append("\n");
            sb.Append("  DocumentBName: ").Append(DocumentBName).Append("\n");
            sb.Append("  DocumentBId: ").Append(DocumentBId).Append("\n");
            sb.Append("  TextUnitBId: ").Append(TextUnitBId).Append("\n");
            sb.Append("  TextUnitBText: ").Append(TextUnitBText).Append("\n");
            sb.Append("  TextUnitBLocationStart: ").Append(TextUnitBLocationStart).Append("\n");
            sb.Append("  TextUnitBLocationEnd: ").Append(TextUnitBLocationEnd).Append("\n");
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
            return this.Equals(input as ProjectTextUnitSimilarity);
        }

        /// <summary>
        /// Returns true if ProjectTextUnitSimilarity instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectTextUnitSimilarity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectTextUnitSimilarity input)
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
                    this.TextUnitAId == input.TextUnitAId ||
                    (this.TextUnitAId != null &&
                    this.TextUnitAId.Equals(input.TextUnitAId))
                ) && 
                (
                    this.TextUnitAText == input.TextUnitAText ||
                    (this.TextUnitAText != null &&
                    this.TextUnitAText.Equals(input.TextUnitAText))
                ) && 
                (
                    this.TextUnitAUnitType == input.TextUnitAUnitType ||
                    (this.TextUnitAUnitType != null &&
                    this.TextUnitAUnitType.Equals(input.TextUnitAUnitType))
                ) && 
                (
                    this.TextUnitALocationStart == input.TextUnitALocationStart ||
                    (this.TextUnitALocationStart != null &&
                    this.TextUnitALocationStart.Equals(input.TextUnitALocationStart))
                ) && 
                (
                    this.TextUnitALocationEnd == input.TextUnitALocationEnd ||
                    (this.TextUnitALocationEnd != null &&
                    this.TextUnitALocationEnd.Equals(input.TextUnitALocationEnd))
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
                    this.TextUnitBId == input.TextUnitBId ||
                    (this.TextUnitBId != null &&
                    this.TextUnitBId.Equals(input.TextUnitBId))
                ) && 
                (
                    this.TextUnitBText == input.TextUnitBText ||
                    (this.TextUnitBText != null &&
                    this.TextUnitBText.Equals(input.TextUnitBText))
                ) && 
                (
                    this.TextUnitBLocationStart == input.TextUnitBLocationStart ||
                    (this.TextUnitBLocationStart != null &&
                    this.TextUnitBLocationStart.Equals(input.TextUnitBLocationStart))
                ) && 
                (
                    this.TextUnitBLocationEnd == input.TextUnitBLocationEnd ||
                    (this.TextUnitBLocationEnd != null &&
                    this.TextUnitBLocationEnd.Equals(input.TextUnitBLocationEnd))
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
                if (this.TextUnitAId != null)
                    hashCode = hashCode * 59 + this.TextUnitAId.GetHashCode();
                if (this.TextUnitAText != null)
                    hashCode = hashCode * 59 + this.TextUnitAText.GetHashCode();
                if (this.TextUnitAUnitType != null)
                    hashCode = hashCode * 59 + this.TextUnitAUnitType.GetHashCode();
                if (this.TextUnitALocationStart != null)
                    hashCode = hashCode * 59 + this.TextUnitALocationStart.GetHashCode();
                if (this.TextUnitALocationEnd != null)
                    hashCode = hashCode * 59 + this.TextUnitALocationEnd.GetHashCode();
                if (this.DocumentBName != null)
                    hashCode = hashCode * 59 + this.DocumentBName.GetHashCode();
                if (this.DocumentBId != null)
                    hashCode = hashCode * 59 + this.DocumentBId.GetHashCode();
                if (this.TextUnitBId != null)
                    hashCode = hashCode * 59 + this.TextUnitBId.GetHashCode();
                if (this.TextUnitBText != null)
                    hashCode = hashCode * 59 + this.TextUnitBText.GetHashCode();
                if (this.TextUnitBLocationStart != null)
                    hashCode = hashCode * 59 + this.TextUnitBLocationStart.GetHashCode();
                if (this.TextUnitBLocationEnd != null)
                    hashCode = hashCode * 59 + this.TextUnitBLocationEnd.GetHashCode();
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