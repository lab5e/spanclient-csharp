/* 
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.0.12 reported-davon
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
    /// Metadata about firmware on devices.
    /// </summary>
    [DataContract]
    public partial class FirmwareMetadata :  IEquatable<FirmwareMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareMetadata" /> class.
        /// </summary>
        /// <param name="currentFirmwareId">currentFirmwareId.</param>
        /// <param name="targetFirmwareId">targetFirmwareId.</param>
        /// <param name="firmwareVersion">Last reported firmware version..</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="modelNumber">modelNumber.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="state">State of the firmware..</param>
        /// <param name="stateMessage">stateMessage.</param>
        public FirmwareMetadata(string currentFirmwareId = default(string), string targetFirmwareId = default(string), string firmwareVersion = default(string), string serialNumber = default(string), string modelNumber = default(string), string manufacturer = default(string), string state = default(string), string stateMessage = default(string))
        {
            this.CurrentFirmwareId = currentFirmwareId;
            this.TargetFirmwareId = targetFirmwareId;
            this.FirmwareVersion = firmwareVersion;
            this.SerialNumber = serialNumber;
            this.ModelNumber = modelNumber;
            this.Manufacturer = manufacturer;
            this.State = state;
            this.StateMessage = stateMessage;
        }
        
        /// <summary>
        /// Gets or Sets CurrentFirmwareId
        /// </summary>
        [DataMember(Name="currentFirmwareId", EmitDefaultValue=false)]
        public string CurrentFirmwareId { get; set; }

        /// <summary>
        /// Gets or Sets TargetFirmwareId
        /// </summary>
        [DataMember(Name="targetFirmwareId", EmitDefaultValue=false)]
        public string TargetFirmwareId { get; set; }

        /// <summary>
        /// Last reported firmware version.
        /// </summary>
        /// <value>Last reported firmware version.</value>
        [DataMember(Name="firmwareVersion", EmitDefaultValue=false)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets ModelNumber
        /// </summary>
        [DataMember(Name="modelNumber", EmitDefaultValue=false)]
        public string ModelNumber { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="manufacturer", EmitDefaultValue=false)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// State of the firmware.
        /// </summary>
        /// <value>State of the firmware.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateMessage
        /// </summary>
        [DataMember(Name="stateMessage", EmitDefaultValue=false)]
        public string StateMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareMetadata {\n");
            sb.Append("  CurrentFirmwareId: ").Append(CurrentFirmwareId).Append("\n");
            sb.Append("  TargetFirmwareId: ").Append(TargetFirmwareId).Append("\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  ModelNumber: ").Append(ModelNumber).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateMessage: ").Append(StateMessage).Append("\n");
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
            return this.Equals(input as FirmwareMetadata);
        }

        /// <summary>
        /// Returns true if FirmwareMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmwareMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentFirmwareId == input.CurrentFirmwareId ||
                    (this.CurrentFirmwareId != null &&
                    this.CurrentFirmwareId.Equals(input.CurrentFirmwareId))
                ) && 
                (
                    this.TargetFirmwareId == input.TargetFirmwareId ||
                    (this.TargetFirmwareId != null &&
                    this.TargetFirmwareId.Equals(input.TargetFirmwareId))
                ) && 
                (
                    this.FirmwareVersion == input.FirmwareVersion ||
                    (this.FirmwareVersion != null &&
                    this.FirmwareVersion.Equals(input.FirmwareVersion))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.ModelNumber == input.ModelNumber ||
                    (this.ModelNumber != null &&
                    this.ModelNumber.Equals(input.ModelNumber))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateMessage == input.StateMessage ||
                    (this.StateMessage != null &&
                    this.StateMessage.Equals(input.StateMessage))
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
                if (this.CurrentFirmwareId != null)
                    hashCode = hashCode * 59 + this.CurrentFirmwareId.GetHashCode();
                if (this.TargetFirmwareId != null)
                    hashCode = hashCode * 59 + this.TargetFirmwareId.GetHashCode();
                if (this.FirmwareVersion != null)
                    hashCode = hashCode * 59 + this.FirmwareVersion.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.ModelNumber != null)
                    hashCode = hashCode * 59 + this.ModelNumber.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateMessage != null)
                    hashCode = hashCode * 59 + this.StateMessage.GetHashCode();
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
