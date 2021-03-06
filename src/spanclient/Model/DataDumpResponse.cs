/* 
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.3 factual-kahlil
 * Contact: dev@lab5e.com
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
using OpenAPIDateConverter = spanclient.Client.OpenAPIDateConverter;

namespace spanclient.Model
{
    /// <summary>
    /// DataDumpResponse
    /// </summary>
    [DataContract]
    public partial class DataDumpResponse :  IEquatable<DataDumpResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataDumpResponse" /> class.
        /// </summary>
        /// <param name="collections">collections.</param>
        public DataDumpResponse(List<DumpedCollection> collections = default(List<DumpedCollection>))
        {
            this.Collections = collections;
        }
        
        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name="collections", EmitDefaultValue=false)]
        public List<DumpedCollection> Collections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataDumpResponse {\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
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
            return this.Equals(input as DataDumpResponse);
        }

        /// <summary>
        /// Returns true if DataDumpResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataDumpResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataDumpResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Collections == input.Collections ||
                    this.Collections != null &&
                    input.Collections != null &&
                    this.Collections.SequenceEqual(input.Collections)
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
                if (this.Collections != null)
                    hashCode = hashCode * 59 + this.Collections.GetHashCode();
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
