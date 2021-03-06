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
    /// SimilarityForm
    /// </summary>
    [DataContract]
    public partial class SimilarityForm :  IEquatable<SimilarityForm>, IValidatableObject
    {
        /// <summary>
        /// Defines Project
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProjectEnum
        {
            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 1,

            /// <summary>
            /// Enum _27 for value: 27
            /// </summary>
            [EnumMember(Value = "27")]
            _27 = 2,

            /// <summary>
            /// Enum _26 for value: 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26 = 3,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 4,

            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24 = 5,

            /// <summary>
            /// Enum _23 for value: 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23 = 6,

            /// <summary>
            /// Enum _22 for value: 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22 = 7,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 8,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 9,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 10,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 11,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 12,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 13,

            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 14,

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 15,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 16,

            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 17,

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 18,

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 19,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 20,

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 21,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 22,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 23

        }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=true)]
        public ProjectEnum? Project { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarityForm" /> class.
        /// </summary>
        /// <param name="runName">runName.</param>
        /// <param name="searchSimilarDocuments">searchSimilarDocuments.</param>
        /// <param name="searchSimilarTextUnits">searchSimilarTextUnits.</param>
        /// <param name="similarityThreshold">Min. Similarity Value 50-100% (default to 75).</param>
        /// <param name="project">project.</param>
        /// <param name="useIdf">useIdf.</param>
        /// <param name="delete">delete.</param>
        public SimilarityForm(string runName = default(string), bool? searchSimilarDocuments = default(bool?), bool? searchSimilarTextUnits = default(bool?), int? similarityThreshold = 75, ProjectEnum? project = default(ProjectEnum?), bool? useIdf = default(bool?), bool? delete = default(bool?))
        {
            this.RunName = runName;
            this.SearchSimilarDocuments = searchSimilarDocuments;
            this.SearchSimilarTextUnits = searchSimilarTextUnits;
            this.SimilarityThreshold = similarityThreshold;
            this.Project = project;
            this.UseIdf = useIdf;
            this.Delete = delete;
            this.RunName = runName;
            this.SearchSimilarDocuments = searchSimilarDocuments;
            this.SearchSimilarTextUnits = searchSimilarTextUnits;
            // use default value if no "similarityThreshold" provided
            if (similarityThreshold == null)
            {
                this.SimilarityThreshold = 75;
            }
            else
            {
                this.SimilarityThreshold = similarityThreshold;
            }
            this.Project = project;
            this.UseIdf = useIdf;
            this.Delete = delete;
        }

        /// <summary>
        /// Gets or Sets RunName
        /// </summary>
        [DataMember(Name="run_name", EmitDefaultValue=true)]
        public string RunName { get; set; }

        /// <summary>
        /// Gets or Sets SearchSimilarDocuments
        /// </summary>
        [DataMember(Name="search_similar_documents", EmitDefaultValue=true)]
        public bool? SearchSimilarDocuments { get; set; }

        /// <summary>
        /// Gets or Sets SearchSimilarTextUnits
        /// </summary>
        [DataMember(Name="search_similar_text_units", EmitDefaultValue=true)]
        public bool? SearchSimilarTextUnits { get; set; }

        /// <summary>
        /// Min. Similarity Value 50-100%
        /// </summary>
        /// <value>Min. Similarity Value 50-100%</value>
        [DataMember(Name="similarity_threshold", EmitDefaultValue=true)]
        public int? SimilarityThreshold { get; set; }


        /// <summary>
        /// Gets or Sets UseIdf
        /// </summary>
        [DataMember(Name="use_idf", EmitDefaultValue=true)]
        public bool? UseIdf { get; set; }

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
            sb.Append("class SimilarityForm {\n");
            sb.Append("  RunName: ").Append(RunName).Append("\n");
            sb.Append("  SearchSimilarDocuments: ").Append(SearchSimilarDocuments).Append("\n");
            sb.Append("  SearchSimilarTextUnits: ").Append(SearchSimilarTextUnits).Append("\n");
            sb.Append("  SimilarityThreshold: ").Append(SimilarityThreshold).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  UseIdf: ").Append(UseIdf).Append("\n");
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
            return this.Equals(input as SimilarityForm);
        }

        /// <summary>
        /// Returns true if SimilarityForm instances are equal
        /// </summary>
        /// <param name="input">Instance of SimilarityForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimilarityForm input)
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
                    this.SearchSimilarDocuments == input.SearchSimilarDocuments ||
                    (this.SearchSimilarDocuments != null &&
                    this.SearchSimilarDocuments.Equals(input.SearchSimilarDocuments))
                ) && 
                (
                    this.SearchSimilarTextUnits == input.SearchSimilarTextUnits ||
                    (this.SearchSimilarTextUnits != null &&
                    this.SearchSimilarTextUnits.Equals(input.SearchSimilarTextUnits))
                ) && 
                (
                    this.SimilarityThreshold == input.SimilarityThreshold ||
                    (this.SimilarityThreshold != null &&
                    this.SimilarityThreshold.Equals(input.SimilarityThreshold))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.UseIdf == input.UseIdf ||
                    (this.UseIdf != null &&
                    this.UseIdf.Equals(input.UseIdf))
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
                if (this.SearchSimilarDocuments != null)
                    hashCode = hashCode * 59 + this.SearchSimilarDocuments.GetHashCode();
                if (this.SearchSimilarTextUnits != null)
                    hashCode = hashCode * 59 + this.SearchSimilarTextUnits.GetHashCode();
                if (this.SimilarityThreshold != null)
                    hashCode = hashCode * 59 + this.SimilarityThreshold.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.UseIdf != null)
                    hashCode = hashCode * 59 + this.UseIdf.GetHashCode();
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
            if(this.SimilarityThreshold < (int?)50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SimilarityThreshold, must be a value greater than or equal to 50.", new [] { "SimilarityThreshold" });
            }

            yield break;
        }
    }

}
