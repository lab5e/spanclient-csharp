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
    /// CreateFirmwareRequest
    /// </summary>
    [DataContract]
    public partial class CreateFirmwareRequest :  IEquatable<CreateFirmwareRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFirmwareRequest" /> class.
        /// </summary>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="image">image.</param>
        /// <param name="version">version.</param>
        /// <param name="filename">filename.</param>
        /// <param name="tags">tags.</param>
        public CreateFirmwareRequest(string collectionId = default(string), byte[] image = default(byte[]), string version = default(string), string filename = default(string), Dictionary<string, string> tags = default(Dictionary<string, string>))
        {
            this.CollectionId = collectionId;
            this.Image = image;
            this.Version = version;
            this.Filename = filename;
            this.Tags = tags;
        }
        
        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name="collectionId", EmitDefaultValue=false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public byte[] Image { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFirmwareRequest {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as CreateFirmwareRequest);
        }

        /// <summary>
        /// Returns true if CreateFirmwareRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFirmwareRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFirmwareRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
