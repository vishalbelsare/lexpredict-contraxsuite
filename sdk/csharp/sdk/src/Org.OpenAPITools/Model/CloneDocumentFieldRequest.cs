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
    /// CloneDocumentFieldRequest
    /// </summary>
    [DataContract]
    public partial class CloneDocumentFieldRequest :  IEquatable<CloneDocumentFieldRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentFieldRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloneDocumentFieldRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentFieldRequest" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="documentType">documentType (required).</param>
        public CloneDocumentFieldRequest(string code = default(string), Guid documentType = default(Guid))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for CloneDocumentFieldRequest and cannot be null");
            }
            else
            {
                this.Code = code;
            }

            // to ensure "documentType" is required (not null)
            if (documentType == null)
            {
                throw new InvalidDataException("documentType is a required property for CloneDocumentFieldRequest and cannot be null");
            }
            else
            {
                this.DocumentType = documentType;
            }

        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name="document_type", EmitDefaultValue=true)]
        public Guid DocumentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneDocumentFieldRequest {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
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
            return this.Equals(input as CloneDocumentFieldRequest);
        }

        /// <summary>
        /// Returns true if CloneDocumentFieldRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneDocumentFieldRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneDocumentFieldRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
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
