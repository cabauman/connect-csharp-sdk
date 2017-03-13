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
    /// Represents a line item to include in an order. Each line item describes a different product to purchase, with its own quantity and price details.
    /// </summary>
    [DataContract]
    public partial class CreateOrderRequestLineItem :  IEquatable<CreateOrderRequestLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrderRequestLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestLineItem" /> class.
        /// </summary>
        /// <param name="Name">The name of the line item. This value cannot exceed 500 characters. (required).</param>
        /// <param name="Quantity">The quantity to purchase, as a string representation of a number. Currently, only integer values are supported. (required).</param>
        /// <param name="BasePriceMoney">The base price for a single unit of the line item&#39;s associated variation. If a line item represents a Custom Amount instead of a particular product, this field indicates that amount. (required).</param>
        public CreateOrderRequestLineItem(string Name = default(string), string Quantity = default(string), Money BasePriceMoney = default(Money))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateOrderRequestLineItem and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for CreateOrderRequestLineItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "BasePriceMoney" is required (not null)
            if (BasePriceMoney == null)
            {
                throw new InvalidDataException("BasePriceMoney is a required property for CreateOrderRequestLineItem and cannot be null");
            }
            else
            {
                this.BasePriceMoney = BasePriceMoney;
            }
        }
        
        /// <summary>
        /// The name of the line item. This value cannot exceed 500 characters.
        /// </summary>
        /// <value>The name of the line item. This value cannot exceed 500 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The quantity to purchase, as a string representation of a number. Currently, only integer values are supported.
        /// </summary>
        /// <value>The quantity to purchase, as a string representation of a number. Currently, only integer values are supported.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public string Quantity { get; set; }
        /// <summary>
        /// The base price for a single unit of the line item&#39;s associated variation. If a line item represents a Custom Amount instead of a particular product, this field indicates that amount.
        /// </summary>
        /// <value>The base price for a single unit of the line item&#39;s associated variation. If a line item represents a Custom Amount instead of a particular product, this field indicates that amount.</value>
        [DataMember(Name="base_price_money", EmitDefaultValue=false)]
        public Money BasePriceMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequestLineItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  BasePriceMoney: ").Append(BasePriceMoney).Append("\n");
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
            return this.Equals(obj as CreateOrderRequestLineItem);
        }

        /// <summary>
        /// Returns true if CreateOrderRequestLineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderRequestLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequestLineItem other)
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
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.BasePriceMoney == other.BasePriceMoney ||
                    this.BasePriceMoney != null &&
                    this.BasePriceMoney.Equals(other.BasePriceMoney)
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
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.BasePriceMoney != null)
                    hash = hash * 59 + this.BasePriceMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 500.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Quantity (string) minLength
            if(this.Quantity != null && this.Quantity.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Quantity, length must be greater than 1.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}
