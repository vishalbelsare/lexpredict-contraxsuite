/* 
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// GeoEntityUsage
    /// </summary>
    [DataContract]
    public partial class GeoEntityUsage :  IEquatable<GeoEntityUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoEntityUsage" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        public GeoEntityUsage(int count = default(int))
        {
            this.Count = count;
        }
        
        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name="entity__name", EmitDefaultValue=false)]
        public string EntityName { get; private set; }

        /// <summary>
        /// Gets or Sets EntityCategory
        /// </summary>
        [DataMember(Name="entity__category", EmitDefaultValue=false)]
        public string EntityCategory { get; private set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name="pk", EmitDefaultValue=false)]
        public int Pk { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitPk
        /// </summary>
        [DataMember(Name="text_unit__pk", EmitDefaultValue=false)]
        public string TextUnitPk { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitUnitType
        /// </summary>
        [DataMember(Name="text_unit__unit_type", EmitDefaultValue=false)]
        public string TextUnitUnitType { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitLocationStart
        /// </summary>
        [DataMember(Name="text_unit__location_start", EmitDefaultValue=false)]
        public string TextUnitLocationStart { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitLocationEnd
        /// </summary>
        [DataMember(Name="text_unit__location_end", EmitDefaultValue=false)]
        public string TextUnitLocationEnd { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitDocumentPk
        /// </summary>
        [DataMember(Name="text_unit__document__pk", EmitDefaultValue=false)]
        public string TextUnitDocumentPk { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitDocumentName
        /// </summary>
        [DataMember(Name="text_unit__document__name", EmitDefaultValue=false)]
        public string TextUnitDocumentName { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitDocumentDescription
        /// </summary>
        [DataMember(Name="text_unit__document__description", EmitDefaultValue=false)]
        public string TextUnitDocumentDescription { get; private set; }

        /// <summary>
        /// Gets or Sets TextUnitDocumentDocumentType
        /// </summary>
        [DataMember(Name="text_unit__document__document_type", EmitDefaultValue=false)]
        public string TextUnitDocumentDocumentType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoEntityUsage {\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  EntityCategory: ").Append(EntityCategory).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  TextUnitPk: ").Append(TextUnitPk).Append("\n");
            sb.Append("  TextUnitUnitType: ").Append(TextUnitUnitType).Append("\n");
            sb.Append("  TextUnitLocationStart: ").Append(TextUnitLocationStart).Append("\n");
            sb.Append("  TextUnitLocationEnd: ").Append(TextUnitLocationEnd).Append("\n");
            sb.Append("  TextUnitDocumentPk: ").Append(TextUnitDocumentPk).Append("\n");
            sb.Append("  TextUnitDocumentName: ").Append(TextUnitDocumentName).Append("\n");
            sb.Append("  TextUnitDocumentDescription: ").Append(TextUnitDocumentDescription).Append("\n");
            sb.Append("  TextUnitDocumentDocumentType: ").Append(TextUnitDocumentDocumentType).Append("\n");
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
            return this.Equals(input as GeoEntityUsage);
        }

        /// <summary>
        /// Returns true if GeoEntityUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoEntityUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoEntityUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.EntityCategory == input.EntityCategory ||
                    (this.EntityCategory != null &&
                    this.EntityCategory.Equals(input.EntityCategory))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Pk == input.Pk ||
                    (this.Pk != null &&
                    this.Pk.Equals(input.Pk))
                ) && 
                (
                    this.TextUnitPk == input.TextUnitPk ||
                    (this.TextUnitPk != null &&
                    this.TextUnitPk.Equals(input.TextUnitPk))
                ) && 
                (
                    this.TextUnitUnitType == input.TextUnitUnitType ||
                    (this.TextUnitUnitType != null &&
                    this.TextUnitUnitType.Equals(input.TextUnitUnitType))
                ) && 
                (
                    this.TextUnitLocationStart == input.TextUnitLocationStart ||
                    (this.TextUnitLocationStart != null &&
                    this.TextUnitLocationStart.Equals(input.TextUnitLocationStart))
                ) && 
                (
                    this.TextUnitLocationEnd == input.TextUnitLocationEnd ||
                    (this.TextUnitLocationEnd != null &&
                    this.TextUnitLocationEnd.Equals(input.TextUnitLocationEnd))
                ) && 
                (
                    this.TextUnitDocumentPk == input.TextUnitDocumentPk ||
                    (this.TextUnitDocumentPk != null &&
                    this.TextUnitDocumentPk.Equals(input.TextUnitDocumentPk))
                ) && 
                (
                    this.TextUnitDocumentName == input.TextUnitDocumentName ||
                    (this.TextUnitDocumentName != null &&
                    this.TextUnitDocumentName.Equals(input.TextUnitDocumentName))
                ) && 
                (
                    this.TextUnitDocumentDescription == input.TextUnitDocumentDescription ||
                    (this.TextUnitDocumentDescription != null &&
                    this.TextUnitDocumentDescription.Equals(input.TextUnitDocumentDescription))
                ) && 
                (
                    this.TextUnitDocumentDocumentType == input.TextUnitDocumentDocumentType ||
                    (this.TextUnitDocumentDocumentType != null &&
                    this.TextUnitDocumentDocumentType.Equals(input.TextUnitDocumentDocumentType))
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
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.EntityCategory != null)
                    hashCode = hashCode * 59 + this.EntityCategory.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Pk != null)
                    hashCode = hashCode * 59 + this.Pk.GetHashCode();
                if (this.TextUnitPk != null)
                    hashCode = hashCode * 59 + this.TextUnitPk.GetHashCode();
                if (this.TextUnitUnitType != null)
                    hashCode = hashCode * 59 + this.TextUnitUnitType.GetHashCode();
                if (this.TextUnitLocationStart != null)
                    hashCode = hashCode * 59 + this.TextUnitLocationStart.GetHashCode();
                if (this.TextUnitLocationEnd != null)
                    hashCode = hashCode * 59 + this.TextUnitLocationEnd.GetHashCode();
                if (this.TextUnitDocumentPk != null)
                    hashCode = hashCode * 59 + this.TextUnitDocumentPk.GetHashCode();
                if (this.TextUnitDocumentName != null)
                    hashCode = hashCode * 59 + this.TextUnitDocumentName.GetHashCode();
                if (this.TextUnitDocumentDescription != null)
                    hashCode = hashCode * 59 + this.TextUnitDocumentDescription.GetHashCode();
                if (this.TextUnitDocumentDocumentType != null)
                    hashCode = hashCode * 59 + this.TextUnitDocumentDocumentType.GetHashCode();
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

            
            // Count (int) maximum
            if(this.Count > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value less than or equal to 2147483647.", new [] { "Count" });
            }

            // Count (int) minimum
            if(this.Count < (int)-2147483648)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Count, must be a value greater than or equal to -2147483648.", new [] { "Count" });
            }

            yield break;
        }
    }

}