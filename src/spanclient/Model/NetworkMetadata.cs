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
    /// Network metadata for devices.
    /// </summary>
    [DataContract]
    public partial class NetworkMetadata :  IEquatable<NetworkMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkMetadata" /> class.
        /// </summary>
        /// <param name="allocatedIp">Allocated IP address..</param>
        /// <param name="allocatedAt">allocatedAt.</param>
        /// <param name="cellId">Cell ID for device. This might not be set, depending on the provider in use..</param>
        public NetworkMetadata(string allocatedIp = default(string), string allocatedAt = default(string), string cellId = default(string))
        {
            this.AllocatedIp = allocatedIp;
            this.AllocatedAt = allocatedAt;
            this.CellId = cellId;
        }
        
        /// <summary>
        /// Allocated IP address.
        /// </summary>
        /// <value>Allocated IP address.</value>
        [DataMember(Name="allocatedIp", EmitDefaultValue=false)]
        public string AllocatedIp { get; set; }

        /// <summary>
        /// Gets or Sets AllocatedAt
        /// </summary>
        [DataMember(Name="allocatedAt", EmitDefaultValue=false)]
        public string AllocatedAt { get; set; }

        /// <summary>
        /// Cell ID for device. This might not be set, depending on the provider in use.
        /// </summary>
        /// <value>Cell ID for device. This might not be set, depending on the provider in use.</value>
        [DataMember(Name="cellId", EmitDefaultValue=false)]
        public string CellId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkMetadata {\n");
            sb.Append("  AllocatedIp: ").Append(AllocatedIp).Append("\n");
            sb.Append("  AllocatedAt: ").Append(AllocatedAt).Append("\n");
            sb.Append("  CellId: ").Append(CellId).Append("\n");
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
            return this.Equals(input as NetworkMetadata);
        }

        /// <summary>
        /// Returns true if NetworkMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllocatedIp == input.AllocatedIp ||
                    (this.AllocatedIp != null &&
                    this.AllocatedIp.Equals(input.AllocatedIp))
                ) && 
                (
                    this.AllocatedAt == input.AllocatedAt ||
                    (this.AllocatedAt != null &&
                    this.AllocatedAt.Equals(input.AllocatedAt))
                ) && 
                (
                    this.CellId == input.CellId ||
                    (this.CellId != null &&
                    this.CellId.Equals(input.CellId))
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
                if (this.AllocatedIp != null)
                    hashCode = hashCode * 59 + this.AllocatedIp.GetHashCode();
                if (this.AllocatedAt != null)
                    hashCode = hashCode * 59 + this.AllocatedAt.GetHashCode();
                if (this.CellId != null)
                    hashCode = hashCode * 59 + this.CellId.GetHashCode();
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
