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

namespace IO.Swagger.model.megaSigns
{
    /// <summary>
    /// MegaSignChildAgreementsFileInfo
    /// </summary>
    [DataContract]
    public partial class MegaSignChildAgreementsFileInfo :  IEquatable<MegaSignChildAgreementsFileInfo>, IValidatableObject
    {
        /// <summary>
        /// Input type through which participantSetsInfos will be provided. Whichever input type is provided, the values should be provided in its corresponding value object. Currently we are supporting CSV file format for providing megaSIgn child recipients.
        /// </summary>
        /// <value>Input type through which participantSetsInfos will be provided. Whichever input type is provided, the values should be provided in its corresponding value object. Currently we are supporting CSV file format for providing megaSIgn child recipients.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileTypeEnum
        {
            
            /// <summary>
            /// Enum CSV for value: CSV
            /// </summary>
            [EnumMember(Value = "CSV")]
            CSV = 1
        }

        /// <summary>
        /// Input type through which participantSetsInfos will be provided. Whichever input type is provided, the values should be provided in its corresponding value object. Currently we are supporting CSV file format for providing megaSIgn child recipients.
        /// </summary>
        /// <value>Input type through which participantSetsInfos will be provided. Whichever input type is provided, the values should be provided in its corresponding value object. Currently we are supporting CSV file format for providing megaSIgn child recipients.</value>
        [DataMember(Name="fileType", EmitDefaultValue=false)]
        public FileTypeEnum? FileType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MegaSignChildAgreementsFileInfo" /> class.
        /// </summary>
        /// <param name="ChildAgreementsInfoFileId">id of the file containg information about the existing childAgreementsInfo associated with the megaSign. Will be ignored in POST call and in case of GET call, this is the only thing that will be returned. The content of the file can be fetched through GET /megaSigns/{megaSignId}/childAgreementsInfo/{childAgreementsInfoFileId} endpoint..</param>
        /// <param name="FileType">Input type through which participantSetsInfos will be provided. Whichever input type is provided, the values should be provided in its corresponding value object. Currently we are supporting CSV file format for providing megaSIgn child recipients..</param>
        /// <param name="TransientDocumentId">Transient id of the input file which contains participantSetsInfos. Currently only csv format is suppported. More details about CSV format &lt;a href&#x3D;&#39;https://www.adobe.com/go/documentcloud_megasigncsv&#39;&gt;here&lt;/a&gt;  .</param>
        public MegaSignChildAgreementsFileInfo(string ChildAgreementsInfoFileId = default(string), FileTypeEnum? FileType = default(FileTypeEnum?), string TransientDocumentId = default(string))
        {
            this.ChildAgreementsInfoFileId = ChildAgreementsInfoFileId;
            this.FileType = FileType;
            this.TransientDocumentId = TransientDocumentId;
        }
        
        /// <summary>
        /// id of the file containg information about the existing childAgreementsInfo associated with the megaSign. Will be ignored in POST call and in case of GET call, this is the only thing that will be returned. The content of the file can be fetched through GET /megaSigns/{megaSignId}/childAgreementsInfo/{childAgreementsInfoFileId} endpoint.
        /// </summary>
        /// <value>id of the file containg information about the existing childAgreementsInfo associated with the megaSign. Will be ignored in POST call and in case of GET call, this is the only thing that will be returned. The content of the file can be fetched through GET /megaSigns/{megaSignId}/childAgreementsInfo/{childAgreementsInfoFileId} endpoint.</value>
        [DataMember(Name="childAgreementsInfoFileId", EmitDefaultValue=false)]
        public string ChildAgreementsInfoFileId { get; set; }


        /// <summary>
        /// Transient id of the input file which contains participantSetsInfos. Currently only csv format is suppported. More details about CSV format &lt;a href&#x3D;&#39;https://www.adobe.com/go/documentcloud_megasigncsv&#39;&gt;here&lt;/a&gt;  
        /// </summary>
        /// <value>Transient id of the input file which contains participantSetsInfos. Currently only csv format is suppported. More details about CSV format &lt;a href&#x3D;&#39;https://www.adobe.com/go/documentcloud_megasigncsv&#39;&gt;here&lt;/a&gt;  </value>
        [DataMember(Name="transientDocumentId", EmitDefaultValue=false)]
        public string TransientDocumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MegaSignChildAgreementsFileInfo {\n");
            sb.Append("  ChildAgreementsInfoFileId: ").Append(ChildAgreementsInfoFileId).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
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
            return this.Equals(input as MegaSignChildAgreementsFileInfo);
        }

        /// <summary>
        /// Returns true if MegaSignChildAgreementsFileInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MegaSignChildAgreementsFileInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MegaSignChildAgreementsFileInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChildAgreementsInfoFileId == input.ChildAgreementsInfoFileId ||
                    (this.ChildAgreementsInfoFileId != null &&
                    this.ChildAgreementsInfoFileId.Equals(input.ChildAgreementsInfoFileId))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.TransientDocumentId == input.TransientDocumentId ||
                    (this.TransientDocumentId != null &&
                    this.TransientDocumentId.Equals(input.TransientDocumentId))
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
                if (this.ChildAgreementsInfoFileId != null)
                    hashCode = hashCode * 59 + this.ChildAgreementsInfoFileId.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.TransientDocumentId != null)
                    hashCode = hashCode * 59 + this.TransientDocumentId.GetHashCode();
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
