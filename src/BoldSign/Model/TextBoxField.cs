/* 
 * BoldSign API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1
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
using BoldSign.Api.Resources;

namespace BoldSign.Model
{
    /// <summary>
    /// TextBoxField
    /// </summary>
    [DataContract]
    public class TextBoxField : FormField
    {

        /// <summary>
        ///     Initializes a new instance of the <see cref="TextBoxField" /> class.
        /// </summary>
        [JsonConstructor]
        protected TextBoxField()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxField" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="bounds">bounds (required).</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="value">value.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="font">font (required).</param>
        /// <param name="fontHexColor">fontHexColor.</param>
        /// <param name="isBoldFont">isBoldFont.</param>
        /// <param name="isItalicFont">isItalicFont.</param>
        /// <param name="isUnderLineFont">isUnderLineFont.</param>
        /// <param name="lineHeight">lineHeight.</param>
        /// <param name="characterLimit">characterLimit.</param>
        /// <param name="validationType">validationType.</param>
        /// <param name="validationCustomRegex">validationCustomRegex.</param>
        /// <param name="validationCustomRegexMessage">validationCustomRegexMessage.</param>
        /// <param name="placeholder">placeHolder.</param>
        [Obsolete("Name is deprecated, please use Id instead")]
        public TextBoxField(string name = default, int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, bool isUnderLineFont = default, int lineHeight = default, int characterLimit = default, ValidationType validationType = default(ValidationType), string validationCustomRegex = default(string), string validationCustomRegexMessage = default(string), string placeholder = default(string)) : base(name: name, type: FieldType.TextBox, pageNumber: pageNumber, bounds: bounds, isRequired: isRequired, value: value, font: font, fontSize: fontSize, fontHexColor: fontHexColor, isBoldFont: isBoldFont, isItalicFont: isItalicFont, isUnderLineFont: isUnderLineFont, lineHeight: lineHeight, characterLimit: characterLimit)
        {
            this.ValidationType = validationType;
            this.ValidationCustomRegex = validationCustomRegex;
            this.ValidationCustomRegexMessage = validationCustomRegexMessage;
            this.Placeholder = placeholder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxField" /> class.
        /// </summary>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="bounds">bounds (required).</param>
        /// <param name="isRequired">isRequired.</param>
        /// <param name="value">value.</param>
        /// <param name="fontSize">fontSize.</param>
        /// <param name="font">font (required).</param>
        /// <param name="fontHexColor">fontHexColor.</param>
        /// <param name="isBoldFont">isBoldFont.</param>
        /// <param name="isItalicFont">isItalicFont.</param>
        /// <param name="isUnderLineFont">isUnderLineFont.</param>
        /// <param name="lineHeight">lineHeight.</param>
        /// <param name="characterLimit">characterLimit.</param>
        /// <param name="validationType">validationType.</param>
        /// <param name="validationCustomRegex">validationCustomRegex.</param>
        /// <param name="validationCustomRegexMessage">validationCustomRegexMessage.</param>
        /// <param name="placeholder">placeHolder.</param>
        /// <param name="id">id.</param>
        public TextBoxField(int pageNumber = default, Rectangle bounds = default, bool isRequired = default, string value = default, FontFamily font = FontFamily.Helvetica, int fontSize = default, string fontHexColor = default, bool isBoldFont = default, bool isItalicFont = default, bool isUnderLineFont = default, int lineHeight = default, int characterLimit = default, ValidationType validationType = default(ValidationType), string validationCustomRegex = default(string), string validationCustomRegexMessage = default(string), string placeholder = default(string), string id = default(string))
            : base(type: FieldType.TextBox, pageNumber: pageNumber, bounds: bounds, isRequired: isRequired, value: value, font: font, fontSize: fontSize, fontHexColor: fontHexColor, isBoldFont: isBoldFont, isItalicFont: isItalicFont, isUnderLineFont: isUnderLineFont, lineHeight: lineHeight, characterLimit: characterLimit, id: id)
        {
            this.ValidationType = validationType;
            this.ValidationCustomRegex = validationCustomRegex;
            this.ValidationCustomRegexMessage = validationCustomRegexMessage;
            this.Placeholder = placeholder;
        }

        /// <summary>
        /// Gets or Sets Placeholder value
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets ValidationType
        /// </summary>
        [DataMember(Name = "validationType", EmitDefaultValue = false)]
        public ValidationType ValidationType { get; set; }

        /// <summary>
        /// Gets or Sets ValidationCustomRegex
        /// </summary>
        [DataMember(Name = "validationCustomRegex", EmitDefaultValue = false)]
        public string ValidationCustomRegex { get; set; }

        // <summary>
        /// Gets or Sets ValidationCustomRegexMessage.
        /// </summary>
        [DataMember(Name = "validationCustomRegexMessage", EmitDefaultValue = false)]
        public string ValidationCustomRegexMessage { get; set; }

        /// <summary>
        /// Gets the form field type.It is a read only property.
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = true)]
        public override FieldType Type
        {
            get => base.m_type;
            set { throw new Exception("Read only"); }
        }
    }
}
