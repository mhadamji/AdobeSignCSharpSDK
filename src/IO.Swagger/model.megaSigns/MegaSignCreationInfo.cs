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
    /// MegaSignCreationInfo
    /// </summary>
    [DataContract]
    public partial class MegaSignCreationInfo :  IEquatable<MegaSignCreationInfo>, IValidatableObject
    {
        /// <summary>
        /// Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used
        /// </summary>
        /// <value>Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReminderFrequencyEnum
        {
            
            /// <summary>
            /// Enum DAILYUNTILSIGNED for value: DAILY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "DAILY_UNTIL_SIGNED")]
            DAILYUNTILSIGNED = 1,
            
            /// <summary>
            /// Enum WEEKDAILYUNTILSIGNED for value: WEEKDAILY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "WEEKDAILY_UNTIL_SIGNED")]
            WEEKDAILYUNTILSIGNED = 2,
            
            /// <summary>
            /// Enum EVERYOTHERDAYUNTILSIGNED for value: EVERY_OTHER_DAY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "EVERY_OTHER_DAY_UNTIL_SIGNED")]
            EVERYOTHERDAYUNTILSIGNED = 3,
            
            /// <summary>
            /// Enum EVERYTHIRDDAYUNTILSIGNED for value: EVERY_THIRD_DAY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "EVERY_THIRD_DAY_UNTIL_SIGNED")]
            EVERYTHIRDDAYUNTILSIGNED = 4,
            
            /// <summary>
            /// Enum EVERYFIFTHDAYUNTILSIGNED for value: EVERY_FIFTH_DAY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "EVERY_FIFTH_DAY_UNTIL_SIGNED")]
            EVERYFIFTHDAYUNTILSIGNED = 5,
            
            /// <summary>
            /// Enum WEEKLYUNTILSIGNED for value: WEEKLY_UNTIL_SIGNED
            /// </summary>
            [EnumMember(Value = "WEEKLY_UNTIL_SIGNED")]
            WEEKLYUNTILSIGNED = 6
        }

        /// <summary>
        /// Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used
        /// </summary>
        /// <value>Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used</value>
        [DataMember(Name="reminderFrequency", EmitDefaultValue=false)]
        public ReminderFrequencyEnum? ReminderFrequency { get; set; }
        /// <summary>
        /// Specifies the type of signature you would like to request - written or e-signature. The possible values are &lt;br&gt; ESIGN : Agreement needs to be signed electronically &lt;br&gt;, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system
        /// </summary>
        /// <value>Specifies the type of signature you would like to request - written or e-signature. The possible values are &lt;br&gt; ESIGN : Agreement needs to be signed electronically &lt;br&gt;, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SignatureTypeEnum
        {
            
            /// <summary>
            /// Enum ESIGN for value: ESIGN
            /// </summary>
            [EnumMember(Value = "ESIGN")]
            ESIGN = 1,
            
            /// <summary>
            /// Enum WRITTEN for value: WRITTEN
            /// </summary>
            [EnumMember(Value = "WRITTEN")]
            WRITTEN = 2
        }

        /// <summary>
        /// Specifies the type of signature you would like to request - written or e-signature. The possible values are &lt;br&gt; ESIGN : Agreement needs to be signed electronically &lt;br&gt;, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system
        /// </summary>
        /// <value>Specifies the type of signature you would like to request - written or e-signature. The possible values are &lt;br&gt; ESIGN : Agreement needs to be signed electronically &lt;br&gt;, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system</value>
        [DataMember(Name="signatureType", EmitDefaultValue=false)]
        public SignatureTypeEnum? SignatureType { get; set; }
        /// <summary>
        /// State of the Megasign
        /// </summary>
        /// <value>State of the Megasign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum PROCESS for value: IN_PROCESS
            /// </summary>
            [EnumMember(Value = "IN_PROCESS")]
            PROCESS = 1
        }

        /// <summary>
        /// State of the Megasign
        /// </summary>
        /// <value>State of the Megasign</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Status of the Megasign
        /// </summary>
        /// <value>Status of the Megasign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum AUTHORING for value: AUTHORING
            /// </summary>
            [EnumMember(Value = "AUTHORING")]
            AUTHORING = 1,
            
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
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 4,
            
            /// <summary>
            /// Enum EXPIRED for value: EXPIRED
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            EXPIRED = 5,
            
            /// <summary>
            /// Enum PREFILL for value: PREFILL
            /// </summary>
            [EnumMember(Value = "PREFILL")]
            PREFILL = 6
        }

        /// <summary>
        /// Status of the Megasign
        /// </summary>
        /// <value>Status of the Megasign</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MegaSignCreationInfo" /> class.
        /// </summary>
        /// <param name="Ccs">A list of one or more CCs that will be copied in the megasign transaction. The CCs will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file .</param>
        /// <param name="ChildAgreementsInfo">Info corresponding to each child agreement of the megaSign .</param>
        /// <param name="CreatedDate">Date when megasign was created. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time.</param>
        /// <param name="ExpirationTime">Time after which Agreement expires and needs to be signed before it. Format should be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time. Should not be provided in offline agreement creation..</param>
        /// <param name="ExternalId">An arbitrary value from your system, which can be specified at sending time and then later returned or queried.</param>
        /// <param name="FileInfos">A list of one or more files (or references to files) that will be sent out for signature. If more than one file is provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in every FileInfo object must be specified.</param>
        /// <param name="FirstReminderDelay">Integer which specifies the delay in hours before sending the first reminder.&lt;br&gt;This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.&lt;br&gt;If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.&lt;br&gt;i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT.</param>
        /// <param name="Id">The unique identifier of megasign .</param>
        /// <param name="Locale">The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the agreement sender.</param>
        /// <param name="Message">An optional message to the participants, describing what is being sent or why their signature is required.</param>
        /// <param name="Name">The name of the agreement that will be used to identify it, in emails, website and other places.</param>
        /// <param name="PostSignOption">URL and associated properties for the success page the user will be taken to after completing the signing process.</param>
        /// <param name="ReminderFrequency">Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used.</param>
        /// <param name="SecurityOption">Optional security parameters for the megasign.</param>
        /// <param name="SenderEmail">Email of agreement sender. Only provided in GET. Can not be provided in POST/PUT request. If provided in POST/PUT, it will be ignored.</param>
        /// <param name="SignatureType">Specifies the type of signature you would like to request - written or e-signature. The possible values are &lt;br&gt; ESIGN : Agreement needs to be signed electronically &lt;br&gt;, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system.</param>
        /// <param name="State">State of the Megasign.</param>
        /// <param name="Status">Status of the Megasign.</param>
        /// <param name="VaultingInfo">Vaulting properties that allows Adobe Sign to securely store documents with a vault provider.</param>
        public MegaSignCreationInfo(List<MegaSignCcInfo> Ccs = default(List<MegaSignCcInfo>), ChildAgreementsInfo ChildAgreementsInfo = default(ChildAgreementsInfo), DateTime? CreatedDate = default(DateTime?), DateTime? ExpirationTime = default(DateTime?), ExternalId ExternalId = default(ExternalId), List<FileInfo> FileInfos = default(List<FileInfo>), int? FirstReminderDelay = default(int?), string Id = default(string), string Locale = default(string), string Message = default(string), string Name = default(string), PostSignOption PostSignOption = default(PostSignOption), ReminderFrequencyEnum? ReminderFrequency = default(ReminderFrequencyEnum?), MegaSignSecurityOption SecurityOption = default(MegaSignSecurityOption), string SenderEmail = default(string), SignatureTypeEnum? SignatureType = default(SignatureTypeEnum?), StateEnum? State = default(StateEnum?), StatusEnum? Status = default(StatusEnum?), VaultingInfo VaultingInfo = default(VaultingInfo))
        {
            this.Ccs = Ccs;
            this.ChildAgreementsInfo = ChildAgreementsInfo;
            this.CreatedDate = CreatedDate;
            this.ExpirationTime = ExpirationTime;
            this.ExternalId = ExternalId;
            this.FileInfos = FileInfos;
            this.FirstReminderDelay = FirstReminderDelay;
            this.Id = Id;
            this.Locale = Locale;
            this.Message = Message;
            this.Name = Name;
            this.PostSignOption = PostSignOption;
            this.ReminderFrequency = ReminderFrequency;
            this.SecurityOption = SecurityOption;
            this.SenderEmail = SenderEmail;
            this.SignatureType = SignatureType;
            this.State = State;
            this.Status = Status;
            this.VaultingInfo = VaultingInfo;
        }
        
        /// <summary>
        /// A list of one or more CCs that will be copied in the megasign transaction. The CCs will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file 
        /// </summary>
        /// <value>A list of one or more CCs that will be copied in the megasign transaction. The CCs will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file </value>
        [DataMember(Name="ccs", EmitDefaultValue=false)]
        public List<MegaSignCcInfo> Ccs { get; set; }

        /// <summary>
        /// Info corresponding to each child agreement of the megaSign 
        /// </summary>
        /// <value>Info corresponding to each child agreement of the megaSign </value>
        [DataMember(Name="childAgreementsInfo", EmitDefaultValue=false)]
        public ChildAgreementsInfo ChildAgreementsInfo { get; set; }

        /// <summary>
        /// Date when megasign was created. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
        /// </summary>
        /// <value>Date when megasign was created. Format would be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Time after which Agreement expires and needs to be signed before it. Format should be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time. Should not be provided in offline agreement creation.
        /// </summary>
        /// <value>Time after which Agreement expires and needs to be signed before it. Format should be yyyy-MM-dd&#39;T&#39;HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time. Should not be provided in offline agreement creation.</value>
        [DataMember(Name="expirationTime", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// An arbitrary value from your system, which can be specified at sending time and then later returned or queried
        /// </summary>
        /// <value>An arbitrary value from your system, which can be specified at sending time and then later returned or queried</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public ExternalId ExternalId { get; set; }

        /// <summary>
        /// A list of one or more files (or references to files) that will be sent out for signature. If more than one file is provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in every FileInfo object must be specified
        /// </summary>
        /// <value>A list of one or more files (or references to files) that will be sent out for signature. If more than one file is provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in every FileInfo object must be specified</value>
        [DataMember(Name="fileInfos", EmitDefaultValue=false)]
        public List<FileInfo> FileInfos { get; set; }

        /// <summary>
        /// Integer which specifies the delay in hours before sending the first reminder.&lt;br&gt;This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.&lt;br&gt;If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.&lt;br&gt;i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT
        /// </summary>
        /// <value>Integer which specifies the delay in hours before sending the first reminder.&lt;br&gt;This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.&lt;br&gt;If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.&lt;br&gt;i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT</value>
        [DataMember(Name="firstReminderDelay", EmitDefaultValue=false)]
        public int? FirstReminderDelay { get; set; }

        /// <summary>
        /// The unique identifier of megasign 
        /// </summary>
        /// <value>The unique identifier of megasign </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the agreement sender
        /// </summary>
        /// <value>The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the agreement sender</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// An optional message to the participants, describing what is being sent or why their signature is required
        /// </summary>
        /// <value>An optional message to the participants, describing what is being sent or why their signature is required</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The name of the agreement that will be used to identify it, in emails, website and other places
        /// </summary>
        /// <value>The name of the agreement that will be used to identify it, in emails, website and other places</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// URL and associated properties for the success page the user will be taken to after completing the signing process
        /// </summary>
        /// <value>URL and associated properties for the success page the user will be taken to after completing the signing process</value>
        [DataMember(Name="postSignOption", EmitDefaultValue=false)]
        public PostSignOption PostSignOption { get; set; }


        /// <summary>
        /// Optional security parameters for the megasign
        /// </summary>
        /// <value>Optional security parameters for the megasign</value>
        [DataMember(Name="securityOption", EmitDefaultValue=false)]
        public MegaSignSecurityOption SecurityOption { get; set; }

        /// <summary>
        /// Email of agreement sender. Only provided in GET. Can not be provided in POST/PUT request. If provided in POST/PUT, it will be ignored
        /// </summary>
        /// <value>Email of agreement sender. Only provided in GET. Can not be provided in POST/PUT request. If provided in POST/PUT, it will be ignored</value>
        [DataMember(Name="senderEmail", EmitDefaultValue=false)]
        public string SenderEmail { get; set; }




        /// <summary>
        /// Vaulting properties that allows Adobe Sign to securely store documents with a vault provider
        /// </summary>
        /// <value>Vaulting properties that allows Adobe Sign to securely store documents with a vault provider</value>
        [DataMember(Name="vaultingInfo", EmitDefaultValue=false)]
        public VaultingInfo VaultingInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MegaSignCreationInfo {\n");
            sb.Append("  Ccs: ").Append(Ccs).Append("\n");
            sb.Append("  ChildAgreementsInfo: ").Append(ChildAgreementsInfo).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
            sb.Append("  FirstReminderDelay: ").Append(FirstReminderDelay).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostSignOption: ").Append(PostSignOption).Append("\n");
            sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
            sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  VaultingInfo: ").Append(VaultingInfo).Append("\n");
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
            return this.Equals(input as MegaSignCreationInfo);
        }

        /// <summary>
        /// Returns true if MegaSignCreationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MegaSignCreationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MegaSignCreationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ccs == input.Ccs ||
                    this.Ccs != null &&
                    this.Ccs.SequenceEqual(input.Ccs)
                ) && 
                (
                    this.ChildAgreementsInfo == input.ChildAgreementsInfo ||
                    (this.ChildAgreementsInfo != null &&
                    this.ChildAgreementsInfo.Equals(input.ChildAgreementsInfo))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FileInfos == input.FileInfos ||
                    this.FileInfos != null &&
                    this.FileInfos.SequenceEqual(input.FileInfos)
                ) && 
                (
                    this.FirstReminderDelay == input.FirstReminderDelay ||
                    (this.FirstReminderDelay != null &&
                    this.FirstReminderDelay.Equals(input.FirstReminderDelay))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PostSignOption == input.PostSignOption ||
                    (this.PostSignOption != null &&
                    this.PostSignOption.Equals(input.PostSignOption))
                ) && 
                (
                    this.ReminderFrequency == input.ReminderFrequency ||
                    (this.ReminderFrequency != null &&
                    this.ReminderFrequency.Equals(input.ReminderFrequency))
                ) && 
                (
                    this.SecurityOption == input.SecurityOption ||
                    (this.SecurityOption != null &&
                    this.SecurityOption.Equals(input.SecurityOption))
                ) && 
                (
                    this.SenderEmail == input.SenderEmail ||
                    (this.SenderEmail != null &&
                    this.SenderEmail.Equals(input.SenderEmail))
                ) && 
                (
                    this.SignatureType == input.SignatureType ||
                    (this.SignatureType != null &&
                    this.SignatureType.Equals(input.SignatureType))
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
                    this.VaultingInfo == input.VaultingInfo ||
                    (this.VaultingInfo != null &&
                    this.VaultingInfo.Equals(input.VaultingInfo))
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
                if (this.Ccs != null)
                    hashCode = hashCode * 59 + this.Ccs.GetHashCode();
                if (this.ChildAgreementsInfo != null)
                    hashCode = hashCode * 59 + this.ChildAgreementsInfo.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FileInfos != null)
                    hashCode = hashCode * 59 + this.FileInfos.GetHashCode();
                if (this.FirstReminderDelay != null)
                    hashCode = hashCode * 59 + this.FirstReminderDelay.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PostSignOption != null)
                    hashCode = hashCode * 59 + this.PostSignOption.GetHashCode();
                if (this.ReminderFrequency != null)
                    hashCode = hashCode * 59 + this.ReminderFrequency.GetHashCode();
                if (this.SecurityOption != null)
                    hashCode = hashCode * 59 + this.SecurityOption.GetHashCode();
                if (this.SenderEmail != null)
                    hashCode = hashCode * 59 + this.SenderEmail.GetHashCode();
                if (this.SignatureType != null)
                    hashCode = hashCode * 59 + this.SignatureType.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.VaultingInfo != null)
                    hashCode = hashCode * 59 + this.VaultingInfo.GetHashCode();
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
