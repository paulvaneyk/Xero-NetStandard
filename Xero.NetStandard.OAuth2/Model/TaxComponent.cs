/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.1
 * Contact: api@xero.com
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model
{
    /// <summary>
    /// TaxComponent
    /// </summary>
    [DataContract]
    public partial class TaxComponent :  IEquatable<TaxComponent>, IValidatableObject
    {
        
        /// <summary>
        /// Name of Tax Component
        /// </summary>
        /// <value>Name of Tax Component</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Tax Rate (up to 4dp)
        /// </summary>
        /// <value>Tax Rate (up to 4dp)</value>
        [DataMember(Name="Rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }

        /// <summary>
        /// Boolean to describe if Tax rate is compounded.
        /// </summary>
        /// <value>Boolean to describe if Tax rate is compounded.</value>
        [DataMember(Name="IsCompound", EmitDefaultValue=false)]
        public bool? IsCompound { get; set; }

        /// <summary>
        /// Boolean to describe if tax rate is non-recoverable. Non-recoverable rates are only applicable to Canadian organisations
        /// </summary>
        /// <value>Boolean to describe if tax rate is non-recoverable. Non-recoverable rates are only applicable to Canadian organisations</value>
        [DataMember(Name="IsNonRecoverable", EmitDefaultValue=false)]
        public bool? IsNonRecoverable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxComponent {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  IsCompound: ").Append(IsCompound).Append("\n");
            sb.Append("  IsNonRecoverable: ").Append(IsNonRecoverable).Append("\n");
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
            return this.Equals(input as TaxComponent);
        }

        /// <summary>
        /// Returns true if TaxComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                ) && 
                (
                    this.IsCompound == input.IsCompound ||
                    this.IsCompound.Equals(input.IsCompound)
                ) && 
                (
                    this.IsNonRecoverable == input.IsNonRecoverable ||
                    this.IsNonRecoverable.Equals(input.IsNonRecoverable)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Rate.GetHashCode();
                hashCode = hashCode * 59 + this.IsCompound.GetHashCode();
                hashCode = hashCode * 59 + this.IsNonRecoverable.GetHashCode();
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
