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

namespace IO.Swagger.model.libraryDocuments
{
    /// <summary>
    /// LibraryDocumentCreationInfoV6
    /// </summary>
    [DataContract]
    public partial class LibraryDocumentCreationInfoV6 :  IEquatable<LibraryDocumentCreationInfoV6>, IValidatableObject
    {
        /// <summary>
        /// Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT requests
        /// </summary>
        /// <value>Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT requests</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SharingModeEnum
        {
            
            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            [EnumMember(Value = "USER")]
            USER = 1,
            
            /// <summary>
            /// Enum GROUP for value: GROUP
            /// </summary>
            [EnumMember(Value = "GROUP")]
            GROUP = 2,
            
            /// <summary>
            /// Enum ACCOUNT for value: ACCOUNT
            /// </summary>
            [EnumMember(Value = "ACCOUNT")]
            ACCOUNT = 3,
            
            /// <summary>
            /// Enum GLOBAL for value: GLOBAL
            /// </summary>
            [EnumMember(Value = "GLOBAL")]
            GLOBAL = 4
        }

        /// <summary>
        /// Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT requests
        /// </summary>
        /// <value>Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT requests</value>
        [DataMember(Name="sharingMode", EmitDefaultValue=false)]
        public SharingModeEnum? SharingMode { get; set; }
        /// <summary>
        /// State of the library document.
        /// </summary>
        /// <value>State of the library document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum AUTHORING for value: AUTHORING
            /// </summary>
            [EnumMember(Value = "AUTHORING")]
            AUTHORING = 1,
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 2
        }

        /// <summary>
        /// State of the library document.
        /// </summary>
        /// <value>State of the library document.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Status of the library document
        /// </summary>
        /// <value>Status of the library document</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum AUTHORING for value: AUTHORING
            /// </summary>
            [EnumMember(Value = "AUTHORING")]
            AUTHORING = 1,
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 2,
            
            /// <summary>
            /// Enum REMOVED for value: REMOVED
            /// </summary>
            [EnumMember(Value = "REMOVED")]
            REMOVED = 3
        }

        /// <summary>
        /// Status of the library document
        /// </summary>
        /// <value>Status of the library document</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines TemplateTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TemplateTypesEnum
        {
            
            /// <summary>
            /// Enum DOCUMENT for value: DOCUMENT
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            DOCUMENT = 1,
            
            /// <summary>
            /// Enum FORMFIELDLAYER for value: FORM_FIELD_LAYER
            /// </summary>
            [EnumMember(Value = "FORM_FIELD_LAYER")]
            FORMFIELDLAYER = 2
        }


        /// <summary>
        /// A list of one or more library template types
        /// </summary>
        /// <value>A list of one or more library template types</value>
        [DataMember(Name="templateTypes", EmitDefaultValue=false)]
        public List<TemplateTypesEnum> TemplateTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryDocumentCreationInfoV6" /> class.
        /// </summary>
        /// <param name="CreatedDate">Date when library document was created. It will be ignored in POST/PUT requests. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="CreatorEmail">Email address of the library document creator. It will be ignored in POST/PUT requests.</param>
        /// <param name="CreatorName">Name of the library document creator.  It will be ignored in POST/PUT requests.</param>
        /// <param name="FileInfos">A list of one or more files (or references to files) that will be used to create the template. If more than one file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must be specified.</param>
        /// <param name="Id">The unique identifier that is used to refer to the library template. It will be ignored in POST requests.</param>
        /// <param name="ModifiedDate">Date when library document was last modified. It will be ignored in POST/PUT requests. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="Name">The name of the library template that will be used to identify it, in emails and on the website.</param>
        /// <param name="SharingMode">Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT requests.</param>
        /// <param name="State">State of the library document..</param>
        /// <param name="Status">Status of the library document.</param>
        /// <param name="TemplateTypes">A list of one or more library template types.</param>
        public LibraryDocumentCreationInfoV6(DateTime? CreatedDate = default(DateTime?), string CreatorEmail = default(string), string CreatorName = default(string), List<FileInfo> FileInfos = default(List<FileInfo>), string Id = default(string), DateTime? ModifiedDate = default(DateTime?), string Name = default(string), SharingModeEnum? SharingMode = default(SharingModeEnum?), StateEnum? State = default(StateEnum?), StatusEnum? Status = default(StatusEnum?), List<TemplateTypesEnum> TemplateTypes = default(List<TemplateTypesEnum>))
        {
            this.CreatedDate = CreatedDate;
            this.CreatorEmail = CreatorEmail;
            this.CreatorName = CreatorName;
            this.FileInfos = FileInfos;
            this.Id = Id;
            this.ModifiedDate = ModifiedDate;
            this.Name = Name;
            this.SharingMode = SharingMode;
            this.State = State;
            this.Status = Status;
            this.TemplateTypes = TemplateTypes;
        }
        
        /// <summary>
        /// Date when library document was created. It will be ignored in POST/PUT requests. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>Date when library document was created. It will be ignored in POST/PUT requests. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Email address of the library document creator. It will be ignored in POST/PUT requests
        /// </summary>
        /// <value>Email address of the library document creator. It will be ignored in POST/PUT requests</value>
        [DataMember(Name="creatorEmail", EmitDefaultValue=false)]
        public string CreatorEmail { get; set; }

        /// <summary>
        /// Name of the library document creator.  It will be ignored in POST/PUT requests
        /// </summary>
        /// <value>Name of the library document creator.  It will be ignored in POST/PUT requests</value>
        [DataMember(Name="creatorName", EmitDefaultValue=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// A list of one or more files (or references to files) that will be used to create the template. If more than one file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must be specified
        /// </summary>
        /// <value>A list of one or more files (or references to files) that will be used to create the template. If more than one file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must be specified</value>
        [DataMember(Name="fileInfos", EmitDefaultValue=false)]
        public List<FileInfo> FileInfos { get; set; }

        /// <summary>
        /// The unique identifier that is used to refer to the library template. It will be ignored in POST requests
        /// </summary>
        /// <value>The unique identifier that is used to refer to the library template. It will be ignored in POST requests</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Date when library document was last modified. It will be ignored in POST/PUT requests. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>Date when library document was last modified. It will be ignored in POST/PUT requests. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The name of the library template that will be used to identify it, in emails and on the website
        /// </summary>
        /// <value>The name of the library template that will be used to identify it, in emails and on the website</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LibraryDocumentCreationInfoV6 {\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatorEmail: ").Append(CreatorEmail).Append("\n");
            sb.Append("  CreatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SharingMode: ").Append(SharingMode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TemplateTypes: ").Append(TemplateTypes).Append("\n");
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
            return this.Equals(input as LibraryDocumentCreationInfoV6);
        }

        /// <summary>
        /// Returns true if LibraryDocumentCreationInfoV6 instances are equal
        /// </summary>
        /// <param name="input">Instance of LibraryDocumentCreationInfoV6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LibraryDocumentCreationInfoV6 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.CreatorEmail == input.CreatorEmail ||
                    (this.CreatorEmail != null &&
                    this.CreatorEmail.Equals(input.CreatorEmail))
                ) && 
                (
                    this.CreatorName == input.CreatorName ||
                    (this.CreatorName != null &&
                    this.CreatorName.Equals(input.CreatorName))
                ) && 
                (
                    this.FileInfos == input.FileInfos ||
                    this.FileInfos != null &&
                    this.FileInfos.SequenceEqual(input.FileInfos)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SharingMode == input.SharingMode ||
                    (this.SharingMode != null &&
                    this.SharingMode.Equals(input.SharingMode))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TemplateTypes == input.TemplateTypes ||
                    this.TemplateTypes != null &&
                    this.TemplateTypes.SequenceEqual(input.TemplateTypes)
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
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatorEmail != null)
                    hashCode = hashCode * 59 + this.CreatorEmail.GetHashCode();
                if (this.CreatorName != null)
                    hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.FileInfos != null)
                    hashCode = hashCode * 59 + this.FileInfos.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SharingMode != null)
                    hashCode = hashCode * 59 + this.SharingMode.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TemplateTypes != null)
                    hashCode = hashCode * 59 + this.TemplateTypes.GetHashCode();
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
