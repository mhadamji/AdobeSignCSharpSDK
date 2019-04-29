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

namespace IO.Swagger.model.widgets
{
    /// <summary>
    /// ParticipantSecurityOption
    /// </summary>
    [DataContract]
    public partial class ParticipantSecurityOption :  IEquatable<ParticipantSecurityOption>, IValidatableObject
    {
        /// <summary>
        /// The authentication method for the participants to have access to view and sign the document. When replacing a participant that has PASSWORD or PHONE authentication specified, you must supply a password or phone number for the new participant, and you cannot change the authentication method
        /// </summary>
        /// <value>The authentication method for the participants to have access to view and sign the document. When replacing a participant that has PASSWORD or PHONE authentication specified, you must supply a password or phone number for the new participant, and you cannot change the authentication method</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationMethodEnum
        {
            
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,
            
            /// <summary>
            /// Enum PASSWORD for value: PASSWORD
            /// </summary>
            [EnumMember(Value = "PASSWORD")]
            PASSWORD = 2,
            
            /// <summary>
            /// Enum PHONE for value: PHONE
            /// </summary>
            [EnumMember(Value = "PHONE")]
            PHONE = 3,
            
            /// <summary>
            /// Enum KBA for value: KBA
            /// </summary>
            [EnumMember(Value = "KBA")]
            KBA = 4,
            
            /// <summary>
            /// Enum WEBIDENTITY for value: WEB_IDENTITY
            /// </summary>
            [EnumMember(Value = "WEB_IDENTITY")]
            WEBIDENTITY = 5,
            
            /// <summary>
            /// Enum ADOBESIGN for value: ADOBE_SIGN
            /// </summary>
            [EnumMember(Value = "ADOBE_SIGN")]
            ADOBESIGN = 6,
            
            /// <summary>
            /// Enum GOVID for value: GOV_ID
            /// </summary>
            [EnumMember(Value = "GOV_ID")]
            GOVID = 7
        }

        /// <summary>
        /// The authentication method for the participants to have access to view and sign the document. When replacing a participant that has PASSWORD or PHONE authentication specified, you must supply a password or phone number for the new participant, and you cannot change the authentication method
        /// </summary>
        /// <value>The authentication method for the participants to have access to view and sign the document. When replacing a participant that has PASSWORD or PHONE authentication specified, you must supply a password or phone number for the new participant, and you cannot change the authentication method</value>
        [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
        public AuthenticationMethodEnum? AuthenticationMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantSecurityOption" /> class.
        /// </summary>
        /// <param name="AuthenticationMethod">The authentication method for the participants to have access to view and sign the document. When replacing a participant that has PASSWORD or PHONE authentication specified, you must supply a password or phone number for the new participant, and you cannot change the authentication method.</param>
        /// <param name="Password">The password required for the participant to view and sign the document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. The password will not be returned in GET call. When replacing a participant that has PASSWORD authentication specified, you must supply a password for the new participant..</param>
        /// <param name="PhoneInfo">The phoneInfo required for the participant to view and sign the document.</param>
        public ParticipantSecurityOption(AuthenticationMethodEnum? AuthenticationMethod = default(AuthenticationMethodEnum?), string Password = default(string), PhoneInfo PhoneInfo = default(PhoneInfo))
        {
            this.AuthenticationMethod = AuthenticationMethod;
            this.Password = Password;
            this.PhoneInfo = PhoneInfo;
        }
        

        /// <summary>
        /// The password required for the participant to view and sign the document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. The password will not be returned in GET call. When replacing a participant that has PASSWORD authentication specified, you must supply a password for the new participant.
        /// </summary>
        /// <value>The password required for the participant to view and sign the document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. The password will not be returned in GET call. When replacing a participant that has PASSWORD authentication specified, you must supply a password for the new participant.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The phoneInfo required for the participant to view and sign the document
        /// </summary>
        /// <value>The phoneInfo required for the participant to view and sign the document</value>
        [DataMember(Name="phoneInfo", EmitDefaultValue=false)]
        public PhoneInfo PhoneInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticipantSecurityOption {\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PhoneInfo: ").Append(PhoneInfo).Append("\n");
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
            return this.Equals(input as ParticipantSecurityOption);
        }

        /// <summary>
        /// Returns true if ParticipantSecurityOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ParticipantSecurityOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantSecurityOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationMethod == input.AuthenticationMethod ||
                    (this.AuthenticationMethod != null &&
                    this.AuthenticationMethod.Equals(input.AuthenticationMethod))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PhoneInfo == input.PhoneInfo ||
                    (this.PhoneInfo != null &&
                    this.PhoneInfo.Equals(input.PhoneInfo))
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
                if (this.AuthenticationMethod != null)
                    hashCode = hashCode * 59 + this.AuthenticationMethod.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PhoneInfo != null)
                    hashCode = hashCode * 59 + this.PhoneInfo.GetHashCode();
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
