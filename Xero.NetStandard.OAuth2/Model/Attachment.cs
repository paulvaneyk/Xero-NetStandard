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
    /// Attachment
    /// </summary>
    [DataContract]
    public partial class Attachment :  IEquatable<Attachment>, IValidatableObject
    {
        
        /// <summary>
        /// Unique ID for the file
        /// </summary>
        /// <value>Unique ID for the file</value>
        [DataMember(Name="AttachmentID", EmitDefaultValue=false)]
        public Guid? AttachmentID { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        /// <value>Name of the file</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// URL to the file on xero.com
        /// </summary>
        /// <value>URL to the file on xero.com</value>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Type of file
        /// </summary>
        /// <value>Type of file</value>
        [DataMember(Name="MimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Length of the file content
        /// </summary>
        /// <value>Length of the file content</value>
        [DataMember(Name="ContentLength", EmitDefaultValue=false)]
        public decimal? ContentLength { get; set; }

        /// <summary>
        /// Include the file with the online invoice
        /// </summary>
        /// <value>Include the file with the online invoice</value>
        [DataMember(Name="IncludeOnline", EmitDefaultValue=false)]
        public bool? IncludeOnline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attachment {\n");
            sb.Append("  AttachmentID: ").Append(AttachmentID).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  IncludeOnline: ").Append(IncludeOnline).Append("\n");
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
            return this.Equals(input as Attachment);
        }

        /// <summary>
        /// Returns true if Attachment instances are equal
        /// </summary>
        /// <param name="input">Instance of Attachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attachment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachmentID == input.AttachmentID ||
                    (this.AttachmentID != null &&
                    this.AttachmentID.Equals(input.AttachmentID))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.ContentLength == input.ContentLength ||
                    this.ContentLength.Equals(input.ContentLength)
                ) && 
                (
                    this.IncludeOnline == input.IncludeOnline ||
                    this.IncludeOnline.Equals(input.IncludeOnline)
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
                if (this.AttachmentID != null)
                    hashCode = hashCode * 59 + this.AttachmentID.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                hashCode = hashCode * 59 + this.ContentLength.GetHashCode();
                hashCode = hashCode * 59 + this.IncludeOnline.GetHashCode();
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
