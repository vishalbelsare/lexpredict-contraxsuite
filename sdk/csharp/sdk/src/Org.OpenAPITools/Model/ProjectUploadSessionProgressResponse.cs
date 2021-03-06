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
    /// ProjectUploadSessionProgressResponse
    /// </summary>
    [DataContract]
    public partial class ProjectUploadSessionProgressResponse :  IEquatable<ProjectUploadSessionProgressResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUploadSessionProgressResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectUploadSessionProgressResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUploadSessionProgressResponse" /> class.
        /// </summary>
        /// <param name="projectId">projectId (required).</param>
        /// <param name="documentTasksProgress">documentTasksProgress (required).</param>
        /// <param name="documentTasksProgressTotal">documentTasksProgressTotal (required).</param>
        /// <param name="documentsTotalSize">documentsTotalSize (required).</param>
        /// <param name="sessionStatus">sessionStatus (required).</param>
        public ProjectUploadSessionProgressResponse(int projectId = default(int), decimal? documentTasksProgress = default(decimal?), decimal? documentTasksProgressTotal = default(decimal?), int documentsTotalSize = default(int), string sessionStatus = default(string))
        {
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new InvalidDataException("projectId is a required property for ProjectUploadSessionProgressResponse and cannot be null");
            }
            else
            {
                this.ProjectId = projectId;
            }

            // to ensure "documentTasksProgress" is required (not null)
            if (documentTasksProgress == null)
            {
                throw new InvalidDataException("documentTasksProgress is a required property for ProjectUploadSessionProgressResponse and cannot be null");
            }
            else
            {
                this.DocumentTasksProgress = documentTasksProgress;
            }

            this.DocumentTasksProgress = documentTasksProgress;
            // to ensure "documentTasksProgressTotal" is required (not null)
            if (documentTasksProgressTotal == null)
            {
                throw new InvalidDataException("documentTasksProgressTotal is a required property for ProjectUploadSessionProgressResponse and cannot be null");
            }
            else
            {
                this.DocumentTasksProgressTotal = documentTasksProgressTotal;
            }

            this.DocumentTasksProgressTotal = documentTasksProgressTotal;
            // to ensure "documentsTotalSize" is required (not null)
            if (documentsTotalSize == null)
            {
                throw new InvalidDataException("documentsTotalSize is a required property for ProjectUploadSessionProgressResponse and cannot be null");
            }
            else
            {
                this.DocumentsTotalSize = documentsTotalSize;
            }

            // to ensure "sessionStatus" is required (not null)
            if (sessionStatus == null)
            {
                throw new InvalidDataException("sessionStatus is a required property for ProjectUploadSessionProgressResponse and cannot be null");
            }
            else
            {
                this.SessionStatus = sessionStatus;
            }

            this.SessionStatus = sessionStatus;
        }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="project_id", EmitDefaultValue=true)]
        public int ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTasksProgress
        /// </summary>
        [DataMember(Name="document_tasks_progress", EmitDefaultValue=true)]
        public decimal? DocumentTasksProgress { get; set; }

        /// <summary>
        /// Gets or Sets DocumentTasksProgressTotal
        /// </summary>
        [DataMember(Name="document_tasks_progress_total", EmitDefaultValue=true)]
        public decimal? DocumentTasksProgressTotal { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsTotalSize
        /// </summary>
        [DataMember(Name="documents_total_size", EmitDefaultValue=true)]
        public int DocumentsTotalSize { get; set; }

        /// <summary>
        /// Gets or Sets SessionStatus
        /// </summary>
        [DataMember(Name="session_status", EmitDefaultValue=true)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectUploadSessionProgressResponse {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  DocumentTasksProgress: ").Append(DocumentTasksProgress).Append("\n");
            sb.Append("  DocumentTasksProgressTotal: ").Append(DocumentTasksProgressTotal).Append("\n");
            sb.Append("  DocumentsTotalSize: ").Append(DocumentsTotalSize).Append("\n");
            sb.Append("  SessionStatus: ").Append(SessionStatus).Append("\n");
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
            return this.Equals(input as ProjectUploadSessionProgressResponse);
        }

        /// <summary>
        /// Returns true if ProjectUploadSessionProgressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectUploadSessionProgressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectUploadSessionProgressResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.DocumentTasksProgress == input.DocumentTasksProgress ||
                    (this.DocumentTasksProgress != null &&
                    this.DocumentTasksProgress.Equals(input.DocumentTasksProgress))
                ) && 
                (
                    this.DocumentTasksProgressTotal == input.DocumentTasksProgressTotal ||
                    (this.DocumentTasksProgressTotal != null &&
                    this.DocumentTasksProgressTotal.Equals(input.DocumentTasksProgressTotal))
                ) && 
                (
                    this.DocumentsTotalSize == input.DocumentsTotalSize ||
                    (this.DocumentsTotalSize != null &&
                    this.DocumentsTotalSize.Equals(input.DocumentsTotalSize))
                ) && 
                (
                    this.SessionStatus == input.SessionStatus ||
                    (this.SessionStatus != null &&
                    this.SessionStatus.Equals(input.SessionStatus))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DocumentTasksProgress != null)
                    hashCode = hashCode * 59 + this.DocumentTasksProgress.GetHashCode();
                if (this.DocumentTasksProgressTotal != null)
                    hashCode = hashCode * 59 + this.DocumentTasksProgressTotal.GetHashCode();
                if (this.DocumentsTotalSize != null)
                    hashCode = hashCode * 59 + this.DocumentsTotalSize.GetHashCode();
                if (this.SessionStatus != null)
                    hashCode = hashCode * 59 + this.SessionStatus.GetHashCode();
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
