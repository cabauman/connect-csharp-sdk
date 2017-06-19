/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
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

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents a discount that applies to one or more line items in an order.
    /// </summary>
    [DataContract]
    public partial class OrderLineItemDiscount :  IEquatable<OrderLineItemDiscount>, IValidatableObject
    {
        /// <summary>
        /// The type of the discount. If it is created by API, it would be either FIXED_PERCENTAGE or FIXED_AMOUNT as VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.
        /// </summary>
        /// <value>The type of the discount. If it is created by API, it would be either FIXED_PERCENTAGE or FIXED_AMOUNT as VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum FIXEDPERCENTAGE for "FIXED_PERCENTAGE"
            /// </summary>
            [EnumMember(Value = "FIXED_PERCENTAGE")]
            FIXEDPERCENTAGE,
            
            /// <summary>
            /// Enum FIXEDAMOUNT for "FIXED_AMOUNT"
            /// </summary>
            [EnumMember(Value = "FIXED_AMOUNT")]
            FIXEDAMOUNT,
            
            /// <summary>
            /// Enum VARIABLEPERCENTAGE for "VARIABLE_PERCENTAGE"
            /// </summary>
            [EnumMember(Value = "VARIABLE_PERCENTAGE")]
            VARIABLEPERCENTAGE,
            
            /// <summary>
            /// Enum VARIABLEAMOUNT for "VARIABLE_AMOUNT"
            /// </summary>
            [EnumMember(Value = "VARIABLE_AMOUNT")]
            VARIABLEAMOUNT
        }

        /// <summary>
        /// The scope of the discount.
        /// </summary>
        /// <value>The scope of the discount.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            
            /// <summary>
            /// Enum LINEITEM for "LINEITEM"
            /// </summary>
            [EnumMember(Value = "LINEITEM")]
            LINEITEM,
            
            /// <summary>
            /// Enum ORDER for "ORDER"
            /// </summary>
            [EnumMember(Value = "ORDER")]
            ORDER
        }

        /// <summary>
        /// The type of the discount. If it is created by API, it would be either FIXED_PERCENTAGE or FIXED_AMOUNT as VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.
        /// </summary>
        /// <value>The type of the discount. If it is created by API, it would be either FIXED_PERCENTAGE or FIXED_AMOUNT as VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The scope of the discount.
        /// </summary>
        /// <value>The scope of the discount.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemDiscount" /> class.
        /// </summary>
        /// <param name="Name">The discount&#39;s name..</param>
        /// <param name="Type">The type of the discount. If it is created by API, it would be either FIXED_PERCENTAGE or FIXED_AMOUNT as VARIABLE_* is not supported in API because the order is created at the time of sale and either percentage or amount has to be specified..</param>
        /// <param name="Percentage">The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%..</param>
        /// <param name="AmountMoney">The amount of the discount..</param>
        /// <param name="AppliedMoney">The amount of the money applied by the discount in an order..</param>
        /// <param name="Scope">The scope of the discount..</param>
        public OrderLineItemDiscount(string Name = default(string), TypeEnum? Type = default(TypeEnum?), string Percentage = default(string), Money AmountMoney = default(Money), Money AppliedMoney = default(Money), ScopeEnum? Scope = default(ScopeEnum?))
        {
            this.Name = Name;
            this.Type = Type;
            this.Percentage = Percentage;
            this.AmountMoney = AmountMoney;
            this.AppliedMoney = AppliedMoney;
            this.Scope = Scope;
        }
        
        /// <summary>
        /// The discount&#39;s name.
        /// </summary>
        /// <value>The discount&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.
        /// </summary>
        /// <value>The percentage of the tax, as a string representation of a decimal number. A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public string Percentage { get; set; }
        /// <summary>
        /// The amount of the discount.
        /// </summary>
        /// <value>The amount of the discount.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The amount of the money applied by the discount in an order.
        /// </summary>
        /// <value>The amount of the money applied by the discount in an order.</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public Money AppliedMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineItemDiscount {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  AppliedMoney: ").Append(AppliedMoney).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderLineItemDiscount);
        }

        /// <summary>
        /// Returns true if OrderLineItemDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderLineItemDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderLineItemDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.AppliedMoney == other.AppliedMoney ||
                    this.AppliedMoney != null &&
                    this.AppliedMoney.Equals(other.AppliedMoney)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.AppliedMoney != null)
                    hash = hash * 59 + this.AppliedMoney.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}