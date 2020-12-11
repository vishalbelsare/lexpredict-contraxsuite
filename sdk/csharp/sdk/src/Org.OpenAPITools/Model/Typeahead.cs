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
    /// Typeahead
    /// </summary>
    [DataContract]
    public partial class Typeahead :  IEquatable<Typeahead>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Typeahead" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Typeahead() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Typeahead" /> class.
        /// </summary>
        /// <param name="q">q (required).</param>
        public Typeahead(string q = default(string))
        {
            // to ensure "q" is required (not null)
            if (q == null)
            {
                throw new InvalidDataException("q is a required property for Typeahead and cannot be null");
            }
            else
            {
                this.Q = q;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Q
        /// </summary>
        [DataMember(Name="q", EmitDefaultValue=true)]
        public string Q { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Typeahead {\n");
            sb.Append("  Q: ").Append(Q).Append("\n");
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
            return this.Equals(input as Typeahead);
        }

        /// <summary>
        /// Returns true if Typeahead instances are equal
        /// </summary>
        /// <param name="input">Instance of Typeahead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Typeahead input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Q == input.Q ||
                    (this.Q != null &&
                    this.Q.Equals(input.Q))
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
                if (this.Q != null)
                    hashCode = hashCode * 59 + this.Q.GetHashCode();
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