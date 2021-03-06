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
    /// UserStats
    /// </summary>
    [DataContract]
    public partial class UserStats :  IEquatable<UserStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserStats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStats" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="userName">userName (required).</param>
        /// <param name="groupName">groupName (required).</param>
        /// <param name="totalProjects">totalProjects (required).</param>
        /// <param name="documentsAssigned">documentsAssigned (required).</param>
        /// <param name="documentsCompleted">documentsCompleted (required).</param>
        /// <param name="documentsTodo">documentsTodo (required).</param>
        /// <param name="documentsCompletedPcnt">documentsCompletedPcnt (required).</param>
        /// <param name="documentsTodoPcnt">documentsTodoPcnt (required).</param>
        /// <param name="clausesAssigned">clausesAssigned (required).</param>
        /// <param name="clausesCompleted">clausesCompleted (required).</param>
        /// <param name="clausesTodo">clausesTodo (required).</param>
        /// <param name="clausesCompletedPcnt">clausesCompletedPcnt (required).</param>
        /// <param name="clausesTodoPcnt">clausesTodoPcnt (required).</param>
        public UserStats(int id = default(int), string userName = default(string), string groupName = default(string), int totalProjects = default(int), int documentsAssigned = default(int), int documentsCompleted = default(int), int documentsTodo = default(int), decimal documentsCompletedPcnt = default(decimal), decimal documentsTodoPcnt = default(decimal), int clausesAssigned = default(int), int clausesCompleted = default(int), int clausesTodo = default(int), decimal clausesCompletedPcnt = default(decimal), decimal clausesTodoPcnt = default(decimal))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UserStats and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new InvalidDataException("userName is a required property for UserStats and cannot be null");
            }
            else
            {
                this.UserName = userName;
            }

            // to ensure "groupName" is required (not null)
            if (groupName == null)
            {
                throw new InvalidDataException("groupName is a required property for UserStats and cannot be null");
            }
            else
            {
                this.GroupName = groupName;
            }

            this.GroupName = groupName;
            // to ensure "totalProjects" is required (not null)
            if (totalProjects == null)
            {
                throw new InvalidDataException("totalProjects is a required property for UserStats and cannot be null");
            }
            else
            {
                this.TotalProjects = totalProjects;
            }

            // to ensure "documentsAssigned" is required (not null)
            if (documentsAssigned == null)
            {
                throw new InvalidDataException("documentsAssigned is a required property for UserStats and cannot be null");
            }
            else
            {
                this.DocumentsAssigned = documentsAssigned;
            }

            // to ensure "documentsCompleted" is required (not null)
            if (documentsCompleted == null)
            {
                throw new InvalidDataException("documentsCompleted is a required property for UserStats and cannot be null");
            }
            else
            {
                this.DocumentsCompleted = documentsCompleted;
            }

            // to ensure "documentsTodo" is required (not null)
            if (documentsTodo == null)
            {
                throw new InvalidDataException("documentsTodo is a required property for UserStats and cannot be null");
            }
            else
            {
                this.DocumentsTodo = documentsTodo;
            }

            // to ensure "documentsCompletedPcnt" is required (not null)
            if (documentsCompletedPcnt == null)
            {
                throw new InvalidDataException("documentsCompletedPcnt is a required property for UserStats and cannot be null");
            }
            else
            {
                this.DocumentsCompletedPcnt = documentsCompletedPcnt;
            }

            // to ensure "documentsTodoPcnt" is required (not null)
            if (documentsTodoPcnt == null)
            {
                throw new InvalidDataException("documentsTodoPcnt is a required property for UserStats and cannot be null");
            }
            else
            {
                this.DocumentsTodoPcnt = documentsTodoPcnt;
            }

            // to ensure "clausesAssigned" is required (not null)
            if (clausesAssigned == null)
            {
                throw new InvalidDataException("clausesAssigned is a required property for UserStats and cannot be null");
            }
            else
            {
                this.ClausesAssigned = clausesAssigned;
            }

            // to ensure "clausesCompleted" is required (not null)
            if (clausesCompleted == null)
            {
                throw new InvalidDataException("clausesCompleted is a required property for UserStats and cannot be null");
            }
            else
            {
                this.ClausesCompleted = clausesCompleted;
            }

            // to ensure "clausesTodo" is required (not null)
            if (clausesTodo == null)
            {
                throw new InvalidDataException("clausesTodo is a required property for UserStats and cannot be null");
            }
            else
            {
                this.ClausesTodo = clausesTodo;
            }

            // to ensure "clausesCompletedPcnt" is required (not null)
            if (clausesCompletedPcnt == null)
            {
                throw new InvalidDataException("clausesCompletedPcnt is a required property for UserStats and cannot be null");
            }
            else
            {
                this.ClausesCompletedPcnt = clausesCompletedPcnt;
            }

            // to ensure "clausesTodoPcnt" is required (not null)
            if (clausesTodoPcnt == null)
            {
                throw new InvalidDataException("clausesTodoPcnt is a required property for UserStats and cannot be null");
            }
            else
            {
                this.ClausesTodoPcnt = clausesTodoPcnt;
            }

        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="user_name", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name="group_name", EmitDefaultValue=true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets TotalProjects
        /// </summary>
        [DataMember(Name="total_projects", EmitDefaultValue=true)]
        public int TotalProjects { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsAssigned
        /// </summary>
        [DataMember(Name="documents_assigned", EmitDefaultValue=true)]
        public int DocumentsAssigned { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsCompleted
        /// </summary>
        [DataMember(Name="documents_completed", EmitDefaultValue=true)]
        public int DocumentsCompleted { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsTodo
        /// </summary>
        [DataMember(Name="documents_todo", EmitDefaultValue=true)]
        public int DocumentsTodo { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsCompletedPcnt
        /// </summary>
        [DataMember(Name="documents_completed_pcnt", EmitDefaultValue=true)]
        public decimal DocumentsCompletedPcnt { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsTodoPcnt
        /// </summary>
        [DataMember(Name="documents_todo_pcnt", EmitDefaultValue=true)]
        public decimal DocumentsTodoPcnt { get; set; }

        /// <summary>
        /// Gets or Sets ClausesAssigned
        /// </summary>
        [DataMember(Name="clauses_assigned", EmitDefaultValue=true)]
        public int ClausesAssigned { get; set; }

        /// <summary>
        /// Gets or Sets ClausesCompleted
        /// </summary>
        [DataMember(Name="clauses_completed", EmitDefaultValue=true)]
        public int ClausesCompleted { get; set; }

        /// <summary>
        /// Gets or Sets ClausesTodo
        /// </summary>
        [DataMember(Name="clauses_todo", EmitDefaultValue=true)]
        public int ClausesTodo { get; set; }

        /// <summary>
        /// Gets or Sets ClausesCompletedPcnt
        /// </summary>
        [DataMember(Name="clauses_completed_pcnt", EmitDefaultValue=true)]
        public decimal ClausesCompletedPcnt { get; set; }

        /// <summary>
        /// Gets or Sets ClausesTodoPcnt
        /// </summary>
        [DataMember(Name="clauses_todo_pcnt", EmitDefaultValue=true)]
        public decimal ClausesTodoPcnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStats {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  TotalProjects: ").Append(TotalProjects).Append("\n");
            sb.Append("  DocumentsAssigned: ").Append(DocumentsAssigned).Append("\n");
            sb.Append("  DocumentsCompleted: ").Append(DocumentsCompleted).Append("\n");
            sb.Append("  DocumentsTodo: ").Append(DocumentsTodo).Append("\n");
            sb.Append("  DocumentsCompletedPcnt: ").Append(DocumentsCompletedPcnt).Append("\n");
            sb.Append("  DocumentsTodoPcnt: ").Append(DocumentsTodoPcnt).Append("\n");
            sb.Append("  ClausesAssigned: ").Append(ClausesAssigned).Append("\n");
            sb.Append("  ClausesCompleted: ").Append(ClausesCompleted).Append("\n");
            sb.Append("  ClausesTodo: ").Append(ClausesTodo).Append("\n");
            sb.Append("  ClausesCompletedPcnt: ").Append(ClausesCompletedPcnt).Append("\n");
            sb.Append("  ClausesTodoPcnt: ").Append(ClausesTodoPcnt).Append("\n");
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
            return this.Equals(input as UserStats);
        }

        /// <summary>
        /// Returns true if UserStats instances are equal
        /// </summary>
        /// <param name="input">Instance of UserStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.TotalProjects == input.TotalProjects ||
                    (this.TotalProjects != null &&
                    this.TotalProjects.Equals(input.TotalProjects))
                ) && 
                (
                    this.DocumentsAssigned == input.DocumentsAssigned ||
                    (this.DocumentsAssigned != null &&
                    this.DocumentsAssigned.Equals(input.DocumentsAssigned))
                ) && 
                (
                    this.DocumentsCompleted == input.DocumentsCompleted ||
                    (this.DocumentsCompleted != null &&
                    this.DocumentsCompleted.Equals(input.DocumentsCompleted))
                ) && 
                (
                    this.DocumentsTodo == input.DocumentsTodo ||
                    (this.DocumentsTodo != null &&
                    this.DocumentsTodo.Equals(input.DocumentsTodo))
                ) && 
                (
                    this.DocumentsCompletedPcnt == input.DocumentsCompletedPcnt ||
                    (this.DocumentsCompletedPcnt != null &&
                    this.DocumentsCompletedPcnt.Equals(input.DocumentsCompletedPcnt))
                ) && 
                (
                    this.DocumentsTodoPcnt == input.DocumentsTodoPcnt ||
                    (this.DocumentsTodoPcnt != null &&
                    this.DocumentsTodoPcnt.Equals(input.DocumentsTodoPcnt))
                ) && 
                (
                    this.ClausesAssigned == input.ClausesAssigned ||
                    (this.ClausesAssigned != null &&
                    this.ClausesAssigned.Equals(input.ClausesAssigned))
                ) && 
                (
                    this.ClausesCompleted == input.ClausesCompleted ||
                    (this.ClausesCompleted != null &&
                    this.ClausesCompleted.Equals(input.ClausesCompleted))
                ) && 
                (
                    this.ClausesTodo == input.ClausesTodo ||
                    (this.ClausesTodo != null &&
                    this.ClausesTodo.Equals(input.ClausesTodo))
                ) && 
                (
                    this.ClausesCompletedPcnt == input.ClausesCompletedPcnt ||
                    (this.ClausesCompletedPcnt != null &&
                    this.ClausesCompletedPcnt.Equals(input.ClausesCompletedPcnt))
                ) && 
                (
                    this.ClausesTodoPcnt == input.ClausesTodoPcnt ||
                    (this.ClausesTodoPcnt != null &&
                    this.ClausesTodoPcnt.Equals(input.ClausesTodoPcnt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.TotalProjects != null)
                    hashCode = hashCode * 59 + this.TotalProjects.GetHashCode();
                if (this.DocumentsAssigned != null)
                    hashCode = hashCode * 59 + this.DocumentsAssigned.GetHashCode();
                if (this.DocumentsCompleted != null)
                    hashCode = hashCode * 59 + this.DocumentsCompleted.GetHashCode();
                if (this.DocumentsTodo != null)
                    hashCode = hashCode * 59 + this.DocumentsTodo.GetHashCode();
                if (this.DocumentsCompletedPcnt != null)
                    hashCode = hashCode * 59 + this.DocumentsCompletedPcnt.GetHashCode();
                if (this.DocumentsTodoPcnt != null)
                    hashCode = hashCode * 59 + this.DocumentsTodoPcnt.GetHashCode();
                if (this.ClausesAssigned != null)
                    hashCode = hashCode * 59 + this.ClausesAssigned.GetHashCode();
                if (this.ClausesCompleted != null)
                    hashCode = hashCode * 59 + this.ClausesCompleted.GetHashCode();
                if (this.ClausesTodo != null)
                    hashCode = hashCode * 59 + this.ClausesTodo.GetHashCode();
                if (this.ClausesCompletedPcnt != null)
                    hashCode = hashCode * 59 + this.ClausesCompletedPcnt.GetHashCode();
                if (this.ClausesTodoPcnt != null)
                    hashCode = hashCode * 59 + this.ClausesTodoPcnt.GetHashCode();
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
