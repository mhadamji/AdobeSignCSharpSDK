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
    /// MegaSign
    /// </summary>
    [DataContract]
    public partial class MegaSign :  IEquatable<MegaSign>, IValidatableObject
    {
        /// <summary>
        /// Current status of the MegaSign parent agreement from the perspective of the user
        /// </summary>
        /// <value>Current status of the MegaSign parent agreement from the perspective of the user</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum WAITINGFORMYSIGNATURE for value: WAITING_FOR_MY_SIGNATURE
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_MY_SIGNATURE")]
            WAITINGFORMYSIGNATURE = 1,
            
            /// <summary>
            /// Enum INPROCESS for value: IN_PROCESS
            /// </summary>
            [EnumMember(Value = "IN_PROCESS")]
            INPROCESS = 2,
            
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 3,
            
            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 4,
            
            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 5,
            
            /// <summary>
            /// Enum WAITINGFORAUTHORING for value: WAITING_FOR_AUTHORING
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_AUTHORING")]
            WAITINGFORAUTHORING = 6,
            
            /// <summary>
            /// Enum WAITINGFORPREFILL for value: WAITING_FOR_PREFILL
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_PREFILL")]
            WAITINGFORPREFILL = 7
        }

        /// <summary>
        /// Current status of the MegaSign parent agreement from the perspective of the user
        /// </summary>
        /// <value>Current status of the MegaSign parent agreement from the perspective of the user</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MegaSign" /> class.
        /// </summary>
        /// <param name="DisplayDate">The display date for the MegaSign parent agreement. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="Id">The unique identifier of the MegaSign parent agreement.</param>
        /// <param name="Esign">True, if the signature type of the MegaSign parent agreement is ESIGN. False, if the signature type of the MegaSign parent agreement is WRITTEN.</param>
        /// <param name="Name">Name of the MegaSign parent agreement.</param>
        /// <param name="Status">Current status of the MegaSign parent agreement from the perspective of the user.</param>
        public MegaSign(DateTime? DisplayDate = default(DateTime?), string Id = default(string), bool? Esign = default(bool?), string Name = default(string), StatusEnum? Status = default(StatusEnum?))
        {
            this.DisplayDate = DisplayDate;
            this.Id = Id;
            this.Esign = Esign;
            this.Name = Name;
            this.Status = Status;
        }
        
        /// <summary>
        /// The display date for the MegaSign parent agreement. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>The display date for the MegaSign parent agreement. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="displayDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DisplayDate { get; set; }

        /// <summary>
        /// The unique identifier of the MegaSign parent agreement
        /// </summary>
        /// <value>The unique identifier of the MegaSign parent agreement</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// True, if the signature type of the MegaSign parent agreement is ESIGN. False, if the signature type of the MegaSign parent agreement is WRITTEN
        /// </summary>
        /// <value>True, if the signature type of the MegaSign parent agreement is ESIGN. False, if the signature type of the MegaSign parent agreement is WRITTEN</value>
        [DataMember(Name="esign", EmitDefaultValue=false)]
        public bool? Esign { get; set; }

        /// <summary>
        /// Name of the MegaSign parent agreement
        /// </summary>
        /// <value>Name of the MegaSign parent agreement</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MegaSign {\n");
            sb.Append("  DisplayDate: ").Append(DisplayDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Esign: ").Append(Esign).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as MegaSign);
        }

        /// <summary>
        /// Returns true if MegaSign instances are equal
        /// </summary>
        /// <param name="input">Instance of MegaSign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MegaSign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayDate == input.DisplayDate ||
                    (this.DisplayDate != null &&
                    this.DisplayDate.Equals(input.DisplayDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Esign == input.Esign ||
                    (this.Esign != null &&
                    this.Esign.Equals(input.Esign))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.DisplayDate != null)
                    hashCode = hashCode * 59 + this.DisplayDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Esign != null)
                    hashCode = hashCode * 59 + this.Esign.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
