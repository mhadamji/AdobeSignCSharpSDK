/**
*  Copyright 2019 Adobe Systems Incorporated. All rights reserved.
*  This file is licensed to you under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License. You may obtain a copy
*  of the License at http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software distributed under
*  the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
*  OF ANY KIND, either express or implied. See the License for the specific language
*  governing permissions and limitations under the License.
*
*
**/


/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 6.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.model.agreements
{
    /// <summary>
    /// FileInfo
    /// </summary>
    [DataContract]
    public partial class FileInfo :  IEquatable<FileInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileInfo" /> class.
        /// </summary>
        /// <param name="Document">A document that is associated with the agreement. This field cannot be provided in POST call. In case of GET call, this is the only field returned in the response.</param>
        /// <param name="Label">The unique label value of a file info element. In case of custom workflow this will map a file to corresponding file element in workflow definition. This must be specified in case of custom workflow agreement creation request .</param>
        /// <param name="LibraryDocumentId">ID for an existing Library document that will be added to the agreement.</param>
        /// <param name="TransientDocumentId">ID for a transient document that will be added to the agreement.</param>
        /// <param name="UrlFileInfo">URL for an external document to add to the agreement.</param>
        public FileInfo(Document Document = default(Document), string Label = default(string), string LibraryDocumentId = default(string), string TransientDocumentId = default(string), URLFileInfo UrlFileInfo = default(URLFileInfo))
        {
            this.Document = Document;
            this.Label = Label;
            this.LibraryDocumentId = LibraryDocumentId;
            this.TransientDocumentId = TransientDocumentId;
            this.UrlFileInfo = UrlFileInfo;
        }
        
        /// <summary>
        /// A document that is associated with the agreement. This field cannot be provided in POST call. In case of GET call, this is the only field returned in the response
        /// </summary>
        /// <value>A document that is associated with the agreement. This field cannot be provided in POST call. In case of GET call, this is the only field returned in the response</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }

        /// <summary>
        /// The unique label value of a file info element. In case of custom workflow this will map a file to corresponding file element in workflow definition. This must be specified in case of custom workflow agreement creation request 
        /// </summary>
        /// <value>The unique label value of a file info element. In case of custom workflow this will map a file to corresponding file element in workflow definition. This must be specified in case of custom workflow agreement creation request </value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// ID for an existing Library document that will be added to the agreement
        /// </summary>
        /// <value>ID for an existing Library document that will be added to the agreement</value>
        [DataMember(Name="libraryDocumentId", EmitDefaultValue=false)]
        public string LibraryDocumentId { get; set; }

        /// <summary>
        /// ID for a transient document that will be added to the agreement
        /// </summary>
        /// <value>ID for a transient document that will be added to the agreement</value>
        [DataMember(Name="transientDocumentId", EmitDefaultValue=false)]
        public string TransientDocumentId { get; set; }

        /// <summary>
        /// URL for an external document to add to the agreement
        /// </summary>
        /// <value>URL for an external document to add to the agreement</value>
        [DataMember(Name="urlFileInfo", EmitDefaultValue=false)]
        public URLFileInfo UrlFileInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileInfo {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  LibraryDocumentId: ").Append(LibraryDocumentId).Append("\n");
            sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
            sb.Append("  UrlFileInfo: ").Append(UrlFileInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as FileInfo);
        }

        /// <summary>
        /// Returns true if FileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.LibraryDocumentId == input.LibraryDocumentId ||
                    (this.LibraryDocumentId != null &&
                    this.LibraryDocumentId.Equals(input.LibraryDocumentId))
                ) && 
                (
                    this.TransientDocumentId == input.TransientDocumentId ||
                    (this.TransientDocumentId != null &&
                    this.TransientDocumentId.Equals(input.TransientDocumentId))
                ) && 
                (
                    this.UrlFileInfo == input.UrlFileInfo ||
                    (this.UrlFileInfo != null &&
                    this.UrlFileInfo.Equals(input.UrlFileInfo))
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
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.LibraryDocumentId != null)
                    hashCode = hashCode * 59 + this.LibraryDocumentId.GetHashCode();
                if (this.TransientDocumentId != null)
                    hashCode = hashCode * 59 + this.TransientDocumentId.GetHashCode();
                if (this.UrlFileInfo != null)
                    hashCode = hashCode * 59 + this.UrlFileInfo.GetHashCode();
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
