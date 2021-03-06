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
    /// ProjectDocumentsSimilarityByVectorsForm
    /// </summary>
    [DataContract]
    public partial class ProjectDocumentsSimilarityByVectorsForm :  IEquatable<ProjectDocumentsSimilarityByVectorsForm>, IValidatableObject
    {
        /// <summary>
        /// Defines DistanceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DistanceTypeEnum
        {
            /// <summary>
            /// Enum Braycurtis for value: braycurtis
            /// </summary>
            [EnumMember(Value = "braycurtis")]
            Braycurtis = 1,

            /// <summary>
            /// Enum Canberra for value: canberra
            /// </summary>
            [EnumMember(Value = "canberra")]
            Canberra = 2,

            /// <summary>
            /// Enum Chebyshev for value: chebyshev
            /// </summary>
            [EnumMember(Value = "chebyshev")]
            Chebyshev = 3,

            /// <summary>
            /// Enum Cityblock for value: cityblock
            /// </summary>
            [EnumMember(Value = "cityblock")]
            Cityblock = 4,

            /// <summary>
            /// Enum Correlation for value: correlation
            /// </summary>
            [EnumMember(Value = "correlation")]
            Correlation = 5,

            /// <summary>
            /// Enum Cosine for value: cosine
            /// </summary>
            [EnumMember(Value = "cosine")]
            Cosine = 6,

            /// <summary>
            /// Enum Dice for value: dice
            /// </summary>
            [EnumMember(Value = "dice")]
            Dice = 7,

            /// <summary>
            /// Enum Euclidean for value: euclidean
            /// </summary>
            [EnumMember(Value = "euclidean")]
            Euclidean = 8,

            /// <summary>
            /// Enum Hamming for value: hamming
            /// </summary>
            [EnumMember(Value = "hamming")]
            Hamming = 9,

            /// <summary>
            /// Enum Jaccard for value: jaccard
            /// </summary>
            [EnumMember(Value = "jaccard")]
            Jaccard = 10,

            /// <summary>
            /// Enum Jensenshannon for value: jensenshannon
            /// </summary>
            [EnumMember(Value = "jensenshannon")]
            Jensenshannon = 11,

            /// <summary>
            /// Enum Kulsinski for value: kulsinski
            /// </summary>
            [EnumMember(Value = "kulsinski")]
            Kulsinski = 12,

            /// <summary>
            /// Enum Mahalanobis for value: mahalanobis
            /// </summary>
            [EnumMember(Value = "mahalanobis")]
            Mahalanobis = 13,

            /// <summary>
            /// Enum Minkowski for value: minkowski
            /// </summary>
            [EnumMember(Value = "minkowski")]
            Minkowski = 14,

            /// <summary>
            /// Enum Rogerstanimoto for value: rogerstanimoto
            /// </summary>
            [EnumMember(Value = "rogerstanimoto")]
            Rogerstanimoto = 15,

            /// <summary>
            /// Enum Russellrao for value: russellrao
            /// </summary>
            [EnumMember(Value = "russellrao")]
            Russellrao = 16,

            /// <summary>
            /// Enum Seuclidean for value: seuclidean
            /// </summary>
            [EnumMember(Value = "seuclidean")]
            Seuclidean = 17,

            /// <summary>
            /// Enum Sokalmichener for value: sokalmichener
            /// </summary>
            [EnumMember(Value = "sokalmichener")]
            Sokalmichener = 18,

            /// <summary>
            /// Enum Sokalsneath for value: sokalsneath
            /// </summary>
            [EnumMember(Value = "sokalsneath")]
            Sokalsneath = 19,

            /// <summary>
            /// Enum Sqeuclidean for value: sqeuclidean
            /// </summary>
            [EnumMember(Value = "sqeuclidean")]
            Sqeuclidean = 20,

            /// <summary>
            /// Enum Wminkowski for value: wminkowski
            /// </summary>
            [EnumMember(Value = "wminkowski")]
            Wminkowski = 21,

            /// <summary>
            /// Enum Yule for value: yule
            /// </summary>
            [EnumMember(Value = "yule")]
            Yule = 22

        }

        /// <summary>
        /// Gets or Sets DistanceType
        /// </summary>
        [DataMember(Name="distance_type", EmitDefaultValue=true)]
        public DistanceTypeEnum? DistanceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDocumentsSimilarityByVectorsForm" /> class.
        /// </summary>
        /// <param name="runName">runName.</param>
        /// <param name="similarityThreshold">Min. Similarity Value 50-100% (default to 75).</param>
        /// <param name="project">Project with Document Transformer trained model.</param>
        /// <param name="featureSource">featureSource (default to &quot;vector&quot;).</param>
        /// <param name="distanceType">distanceType (default to DistanceTypeEnum.Cosine).</param>
        /// <param name="itemId">Optional. Search similar for one concrete document.</param>
        /// <param name="createReverseRelations">createReverseRelations.</param>
        /// <param name="useTfidf">useTfidf.</param>
        /// <param name="delete">delete.</param>
        public ProjectDocumentsSimilarityByVectorsForm(string runName = default(string), int? similarityThreshold = 75, int? project = default(int?), string featureSource = "vector", DistanceTypeEnum? distanceType = DistanceTypeEnum.Cosine, int? itemId = default(int?), bool? createReverseRelations = default(bool?), bool? useTfidf = default(bool?), bool? delete = default(bool?))
        {
            this.RunName = runName;
            this.SimilarityThreshold = similarityThreshold;
            this.Project = project;
            this.FeatureSource = featureSource;
            this.DistanceType = distanceType;
            this.ItemId = itemId;
            this.CreateReverseRelations = createReverseRelations;
            this.UseTfidf = useTfidf;
            this.Delete = delete;
            this.RunName = runName;
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
            // use default value if no "featureSource" provided
            if (featureSource == null)
            {
                this.FeatureSource = "vector";
            }
            else
            {
                this.FeatureSource = featureSource;
            }
            // use default value if no "distanceType" provided
            if (distanceType == null)
            {
                this.DistanceType = DistanceTypeEnum.Cosine;
            }
            else
            {
                this.DistanceType = distanceType;
            }
            this.ItemId = itemId;
            this.CreateReverseRelations = createReverseRelations;
            this.UseTfidf = useTfidf;
            this.Delete = delete;
        }

        /// <summary>
        /// Gets or Sets RunName
        /// </summary>
        [DataMember(Name="run_name", EmitDefaultValue=true)]
        public string RunName { get; set; }

        /// <summary>
        /// Min. Similarity Value 50-100%
        /// </summary>
        /// <value>Min. Similarity Value 50-100%</value>
        [DataMember(Name="similarity_threshold", EmitDefaultValue=true)]
        public int? SimilarityThreshold { get; set; }

        /// <summary>
        /// Project with Document Transformer trained model
        /// </summary>
        /// <value>Project with Document Transformer trained model</value>
        [DataMember(Name="project", EmitDefaultValue=true)]
        public int? Project { get; set; }

        /// <summary>
        /// Gets or Sets FeatureSource
        /// </summary>
        [DataMember(Name="feature_source", EmitDefaultValue=true)]
        public string FeatureSource { get; set; }


        /// <summary>
        /// Optional. Search similar for one concrete document
        /// </summary>
        /// <value>Optional. Search similar for one concrete document</value>
        [DataMember(Name="item_id", EmitDefaultValue=true)]
        public int? ItemId { get; set; }

        /// <summary>
        /// Gets or Sets CreateReverseRelations
        /// </summary>
        [DataMember(Name="create_reverse_relations", EmitDefaultValue=true)]
        public bool? CreateReverseRelations { get; set; }

        /// <summary>
        /// Gets or Sets UseTfidf
        /// </summary>
        [DataMember(Name="use_tfidf", EmitDefaultValue=true)]
        public bool? UseTfidf { get; set; }

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
            sb.Append("class ProjectDocumentsSimilarityByVectorsForm {\n");
            sb.Append("  RunName: ").Append(RunName).Append("\n");
            sb.Append("  SimilarityThreshold: ").Append(SimilarityThreshold).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  FeatureSource: ").Append(FeatureSource).Append("\n");
            sb.Append("  DistanceType: ").Append(DistanceType).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  CreateReverseRelations: ").Append(CreateReverseRelations).Append("\n");
            sb.Append("  UseTfidf: ").Append(UseTfidf).Append("\n");
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
            return this.Equals(input as ProjectDocumentsSimilarityByVectorsForm);
        }

        /// <summary>
        /// Returns true if ProjectDocumentsSimilarityByVectorsForm instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectDocumentsSimilarityByVectorsForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectDocumentsSimilarityByVectorsForm input)
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
                    this.FeatureSource == input.FeatureSource ||
                    (this.FeatureSource != null &&
                    this.FeatureSource.Equals(input.FeatureSource))
                ) && 
                (
                    this.DistanceType == input.DistanceType ||
                    (this.DistanceType != null &&
                    this.DistanceType.Equals(input.DistanceType))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.CreateReverseRelations == input.CreateReverseRelations ||
                    (this.CreateReverseRelations != null &&
                    this.CreateReverseRelations.Equals(input.CreateReverseRelations))
                ) && 
                (
                    this.UseTfidf == input.UseTfidf ||
                    (this.UseTfidf != null &&
                    this.UseTfidf.Equals(input.UseTfidf))
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
                if (this.SimilarityThreshold != null)
                    hashCode = hashCode * 59 + this.SimilarityThreshold.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.FeatureSource != null)
                    hashCode = hashCode * 59 + this.FeatureSource.GetHashCode();
                if (this.DistanceType != null)
                    hashCode = hashCode * 59 + this.DistanceType.GetHashCode();
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.CreateReverseRelations != null)
                    hashCode = hashCode * 59 + this.CreateReverseRelations.GetHashCode();
                if (this.UseTfidf != null)
                    hashCode = hashCode * 59 + this.UseTfidf.GetHashCode();
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
