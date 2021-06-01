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
    /// PartySimilarityForm
    /// </summary>
    [DataContract]
    public partial class PartySimilarityForm :  IEquatable<PartySimilarityForm>, IValidatableObject
    {
        /// <summary>
        /// Defines SimilarityType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SimilarityTypeEnum
        {
            /// <summary>
            /// Enum Setratio for value: token_set_ratio
            /// </summary>
            [EnumMember(Value = "token_set_ratio")]
            Setratio = 1,

            /// <summary>
            /// Enum Sortratio for value: token_sort_ratio
            /// </summary>
            [EnumMember(Value = "token_sort_ratio")]
            Sortratio = 2

        }

        /// <summary>
        /// Gets or Sets SimilarityType
        /// </summary>
        [DataMember(Name="similarity_type", EmitDefaultValue=true)]
        public SimilarityTypeEnum? SimilarityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartySimilarityForm" /> class.
        /// </summary>
        /// <param name="runName">runName.</param>
        /// <param name="caseSensitive">caseSensitive.</param>
        /// <param name="similarityType">similarityType (default to SimilarityTypeEnum.Setratio).</param>
        /// <param name="similarityThreshold">Min. Similarity Value 0-100%. (default to 90).</param>
        /// <param name="delete">delete.</param>
        public PartySimilarityForm(string runName = default(string), bool? caseSensitive = default(bool?), SimilarityTypeEnum? similarityType = SimilarityTypeEnum.Setratio, int? similarityThreshold = 90, bool? delete = default(bool?))
        {
            this.RunName = runName;
            this.CaseSensitive = caseSensitive;
            this.SimilarityType = similarityType;
            this.SimilarityThreshold = similarityThreshold;
            this.Delete = delete;
            this.RunName = runName;
            this.CaseSensitive = caseSensitive;
            // use default value if no "similarityType" provided
            if (similarityType == null)
            {
                this.SimilarityType = SimilarityTypeEnum.Setratio;
            }
            else
            {
                this.SimilarityType = similarityType;
            }
            // use default value if no "similarityThreshold" provided
            if (similarityThreshold == null)
            {
                this.SimilarityThreshold = 90;
            }
            else
            {
                this.SimilarityThreshold = similarityThreshold;
            }
            this.Delete = delete;
        }

        /// <summary>
        /// Gets or Sets RunName
        /// </summary>
        [DataMember(Name="run_name", EmitDefaultValue=true)]
        public string RunName { get; set; }

        /// <summary>
        /// Gets or Sets CaseSensitive
        /// </summary>
        [DataMember(Name="case_sensitive", EmitDefaultValue=true)]
        public bool? CaseSensitive { get; set; }


        /// <summary>
        /// Min. Similarity Value 0-100%.
        /// </summary>
        /// <value>Min. Similarity Value 0-100%.</value>
        [DataMember(Name="similarity_threshold", EmitDefaultValue=true)]
        public int? SimilarityThreshold { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>
        [DataMember(Name="delete", EmitDefaultValue=true)]
        public bool? Delete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartySimilarityForm {\n");
            sb.Append("  RunName: ").Append(RunName).Append("\n");
            sb.Append("  CaseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  SimilarityType: ").Append(SimilarityType).Append("\n");
            sb.Append("  SimilarityThreshold: ").Append(SimilarityThreshold).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
            return this.Equals(input as PartySimilarityForm);
        }

        /// <summary>
        /// Returns true if PartySimilarityForm instances are equal
        /// </summary>
        /// <param name="input">Instance of PartySimilarityForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartySimilarityForm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RunName == input.RunName ||
                    (this.RunName != null &&
                    this.RunName.Equals(input.RunName))
                ) && 
                (
                    this.CaseSensitive == input.CaseSensitive ||
                    (this.CaseSensitive != null &&
                    this.CaseSensitive.Equals(input.CaseSensitive))
                ) && 
                (
                    this.SimilarityType == input.SimilarityType ||
                    (this.SimilarityType != null &&
                    this.SimilarityType.Equals(input.SimilarityType))
                ) && 
                (
                    this.SimilarityThreshold == input.SimilarityThreshold ||
                    (this.SimilarityThreshold != null &&
                    this.SimilarityThreshold.Equals(input.SimilarityThreshold))
                ) && 
                (
                    this.Delete == input.Delete ||
                    (this.Delete != null &&
                    this.Delete.Equals(input.Delete))
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
                if (this.RunName != null)
                    hashCode = hashCode * 59 + this.RunName.GetHashCode();
                if (this.CaseSensitive != null)
                    hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.SimilarityType != null)
                    hashCode = hashCode * 59 + this.SimilarityType.GetHashCode();
                if (this.SimilarityThreshold != null)
                    hashCode = hashCode * 59 + this.SimilarityThreshold.GetHashCode();
                if (this.Delete != null)
                    hashCode = hashCode * 59 + this.Delete.GetHashCode();
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
            // RunName (string) maxLength
            if(this.RunName != null && this.RunName.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RunName, length must be less than 100.", new [] { "RunName" });
            }

 

 
            // SimilarityThreshold (int?) maximum
            if(this.SimilarityThreshold > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SimilarityThreshold, must be a value less than or equal to 100.", new [] { "SimilarityThreshold" });
            }

            // SimilarityThreshold (int?) minimum
            if(this.SimilarityThreshold < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SimilarityThreshold, must be a value greater than or equal to 0.", new [] { "SimilarityThreshold" });
            }

            yield break;
        }
    }

}