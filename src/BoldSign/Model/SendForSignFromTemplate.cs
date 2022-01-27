/*
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    ///     Return send for signature template details in which the document is in the form of.
    /// </summary>
    [DataContract]
    public class SendForSignFromTemplate
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SendForSignFromTemplate" /> class.
        /// </summary>
        /// <param name="templateId">Gets or sets the document id..</param>
        /// <param name="title">Gets or sets the title..</param>
        /// <param name="message">Gets or sets the message..</param>
        /// <param name="roles">Gets or sets the roles..</param>
        /// <param name="brandId">Gets or sets the brandId..</param>
        /// <param name="labels">Gets or sets the labels.</param>
        /// <param name="disableEmails">Gets or sets the disableEmails.</param>
        /// <param name="hideDocumentId">Gets or sets the hideDocumentId.</param>
        /// <param name="reminderSettings">Gets or sets the reminderSettings.</param>
        /// <param name="cc">Gets or sets the cc.</param>
        /// <param name="expiryDays">Gets or sets the expiryDays.</param>
        public SendForSignFromTemplate(
            string templateId = default,
            string title = default,
            string message = default,
            List<Roles> roles = default,
            string brandId = default,
            List<string> labels = default,
            bool disableEmails = default,
            bool hideDocumentId = default,
            ReminderSettings reminderSettings = default,
            IEnumerable<DocumentCC> cc = default,
            int expiryDays = 60)
        {
            this.TemplateId = templateId;
            this.Title = title;
            this.Message = message;
            this.Roles = roles;
            this.TemplateId = templateId;
            this.Title = title;
            this.Message = message;
            this.Roles = roles;
            this.BrandId = brandId;
            this.Labels = labels;
            this.DisableEmails = disableEmails;
            this.HideDocumentId = hideDocumentId;
            this.ReminderSettings = reminderSettings;
            this.CC = cc;
            this.ExpiryDays = expiryDays;
        }

        /// <summary>
        ///     Gets or sets the template Id.
        /// </summary>
        /// <value>Gets or sets the document id.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        ///     Gets or sets title for the signature request.
        /// </summary>
        /// <value>Gets or sets the title.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        ///     Gets or sets common message for all the document recipients.
        /// </summary>
        /// <value>Gets or sets the message.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the signer roles in a template of the document.
        /// </summary>
        /// <value>Gets or sets the roles.</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<Roles> Roles { get; set; }

        /// <summary>
        /// Gets or sets the brand id.
        /// </summary>
        [DataMember(Name = "brandId", EmitDefaultValue = true)]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = true)]
        public List<string> Labels { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether to enable or disable emails.When disable emails is set to true, all the status emails and completed document email will be stopped, and reminder is also automatically ignored.
        /// </summary>
        [DataMember(Name = "disableEmails", EmitDefaultValue = true)]
        public bool DisableEmails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to remove the document ID watermark from all the PDF pages of the document.
        /// Default is false.
        /// </summary>
        [DataMember(Name = "hideDocumentId", EmitDefaultValue = true)]
        public bool HideDocumentId { get; set; }

        /// <summary>
        /// Gets or sets the reminder settings for the signature request.
        /// </summary>
        [DataMember(Name = "reminderSettings", EmitDefaultValue = true)]
        public ReminderSettings ReminderSettings { get; set; }

        /// <summary>
        ///     Gets or sets document CC details.
        /// </summary>
        [DataMember(Name = "cc", EmitDefaultValue = true)]
        public IEnumerable<DocumentCC> CC { get; set; }

        /// <summary>
        ///  Gets or sets number of days after which the document will expire.
        /// </summary>
        [DataMember(Name = "expiryDays", EmitDefaultValue = true)]
        public int ExpiryDays { get; set; } = 60;

        /// <summary>
        ///     Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
