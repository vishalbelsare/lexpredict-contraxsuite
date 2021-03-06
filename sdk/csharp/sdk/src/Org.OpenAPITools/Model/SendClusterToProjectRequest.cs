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
    /// SendClusterToProjectRequest
    /// </summary>
    [DataContract]
    public partial class SendClusterToProjectRequest :  IEquatable<SendClusterToProjectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendClusterToProjectRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendClusterToProjectRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendClusterToProjectRequest" /> class.
        /// </summary>
        /// <param name="clusterIds">clusterIds (required).</param>
        /// <param name="projectId">projectId (required).</param>
        public SendClusterToProjectRequest(List<int> clusterIds = default(List<int>), int projectId = default(int))
        {
            // to ensure "clusterIds" is required (not null)
            if (clusterIds == null)
            {
                throw new InvalidDataException("clusterIds is a required property for SendClusterToProjectRequest and cannot be null");
            }
            else
            {
                this.ClusterIds = clusterIds;
            }

            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new InvalidDataException("projectId is a required property for SendClusterToProjectRequest and cannot be null");
            }
            else
            {
                this.ProjectId = projectId;
            }

        }

        /// <summary>
        /// Gets or Sets ClusterIds
        /// </summary>
        [DataMember(Name="cluster_ids", EmitDefaultValue=true)]
        public List<int> ClusterIds { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="project_id", EmitDefaultValue=true)]
        public int ProjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendClusterToProjectRequest {\n");
            sb.Append("  ClusterIds: ").Append(ClusterIds).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
            return this.Equals(input as SendClusterToProjectRequest);
        }

        /// <summary>
        /// Returns true if SendClusterToProjectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SendClusterToProjectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendClusterToProjectRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterIds == input.ClusterIds ||
                    this.ClusterIds != null &&
                    input.ClusterIds != null &&
                    this.ClusterIds.SequenceEqual(input.ClusterIds)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
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
                if (this.ClusterIds != null)
                    hashCode = hashCode * 59 + this.ClusterIds.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
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
