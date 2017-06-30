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
    /// Defines the parameters that can be included in the body of a request to the [CreateCheckout](#endpoint-createcheckout) endpoint.
    /// </summary>
    [DataContract]
    public partial class CreateCheckoutRequest :  IEquatable<CreateCheckoutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCheckoutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutRequest" /> class.
        /// </summary>
        /// <param name="IdempotencyKey">A unique string that identifies this checkout among others you&#39;ve created. It can be any valid string but must be unique for every order sent to Square Checkout for a given location ID.  The idempotency key is used to avoid processing the same order more than once. If you&#39;re unsure whether a particular checkout was created successfully, you can reattempt it with the same idempotency key and all the same other parameters without worrying about creating duplicates.  We recommend using a random number/string generator native to the language you are working in to generate strings for your idempotency keys.  See [Idempotency keys](#idempotencykeys) for more information. (required).</param>
        /// <param name="Order">The order including line items to be checked out. (required).</param>
        /// <param name="AskForShippingAddress">If &#x60;true&#x60;, Square Checkout will collect shipping information on your behalf and store that information with the transaction information in your Square Dashboard.  Default: &#x60;false&#x60;..</param>
        /// <param name="MerchantSupportEmail">The email address to display on the Square Checkout confirmation page and confirmation email that the buyer can use to contact the merchant.  If this value is not set, the confirmation page and email will display the primary email address associated with the merchant&#39;s Square account.  Default: none; only exists if explicitly set..</param>
        /// <param name="PrePopulateBuyerEmail">If provided, the buyer&#39;s email is pre-populated on the checkout page as an editable text field.  Default: none; only exists if explicitly set..</param>
        /// <param name="PrePopulateShippingAddress">If provided, the buyer&#39;s shipping info is pre-populated on the checkout page as editable text fields.  Default: none; only exists if explicitly set..</param>
        /// <param name="RedirectUrl">The URL to redirect to after checkout is completed with &#x60;checkoutId&#x60;, Square&#39;s &#x60;orderId&#x60;, &#x60;transactionId&#x60;, and &#x60;referenceId&#x60; appended as URL parameters. For example, if the provided redirect_url is &#x60;http://www.example.com/order-complete&#x60;, a successful transaction redirects the customer to:  &#x60;http://www.example.com/order-complete?checkoutId&#x3D;xxxxxx&amp;orderId&#x3D;xxxxxx&amp;referenceId&#x3D;xxxxxx&amp;transactionId&#x3D;xxxxxx&#x60;  If you do not provide a redirect URL, Square Checkout will display an order confirmation page on your behalf; however Square strongly recommends that you provide a redirect URL so you can verify the transaction results and finalize the order through your existing/normal confirmation workflow.  Default: none; only exists if explicitly set..</param>
        public CreateCheckoutRequest(string IdempotencyKey = default(string), CreateOrderRequest Order = default(CreateOrderRequest), bool? AskForShippingAddress = default(bool?), string MerchantSupportEmail = default(string), string PrePopulateBuyerEmail = default(string), Address PrePopulateShippingAddress = default(Address), string RedirectUrl = default(string))
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for CreateCheckoutRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            // to ensure "Order" is required (not null)
            if (Order == null)
            {
                throw new InvalidDataException("Order is a required property for CreateCheckoutRequest and cannot be null");
            }
            else
            {
                this.Order = Order;
            }
            this.AskForShippingAddress = AskForShippingAddress;
            this.MerchantSupportEmail = MerchantSupportEmail;
            this.PrePopulateBuyerEmail = PrePopulateBuyerEmail;
            this.PrePopulateShippingAddress = PrePopulateShippingAddress;
            this.RedirectUrl = RedirectUrl;
        }
        
        /// <summary>
        /// A unique string that identifies this checkout among others you&#39;ve created. It can be any valid string but must be unique for every order sent to Square Checkout for a given location ID.  The idempotency key is used to avoid processing the same order more than once. If you&#39;re unsure whether a particular checkout was created successfully, you can reattempt it with the same idempotency key and all the same other parameters without worrying about creating duplicates.  We recommend using a random number/string generator native to the language you are working in to generate strings for your idempotency keys.  See [Idempotency keys](#idempotencykeys) for more information.
        /// </summary>
        /// <value>A unique string that identifies this checkout among others you&#39;ve created. It can be any valid string but must be unique for every order sent to Square Checkout for a given location ID.  The idempotency key is used to avoid processing the same order more than once. If you&#39;re unsure whether a particular checkout was created successfully, you can reattempt it with the same idempotency key and all the same other parameters without worrying about creating duplicates.  We recommend using a random number/string generator native to the language you are working in to generate strings for your idempotency keys.  See [Idempotency keys](#idempotencykeys) for more information.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// The order including line items to be checked out.
        /// </summary>
        /// <value>The order including line items to be checked out.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public CreateOrderRequest Order { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, Square Checkout will collect shipping information on your behalf and store that information with the transaction information in your Square Dashboard.  Default: &#x60;false&#x60;.
        /// </summary>
        /// <value>If &#x60;true&#x60;, Square Checkout will collect shipping information on your behalf and store that information with the transaction information in your Square Dashboard.  Default: &#x60;false&#x60;.</value>
        [DataMember(Name="ask_for_shipping_address", EmitDefaultValue=false)]
        public bool? AskForShippingAddress { get; set; }
        /// <summary>
        /// The email address to display on the Square Checkout confirmation page and confirmation email that the buyer can use to contact the merchant.  If this value is not set, the confirmation page and email will display the primary email address associated with the merchant&#39;s Square account.  Default: none; only exists if explicitly set.
        /// </summary>
        /// <value>The email address to display on the Square Checkout confirmation page and confirmation email that the buyer can use to contact the merchant.  If this value is not set, the confirmation page and email will display the primary email address associated with the merchant&#39;s Square account.  Default: none; only exists if explicitly set.</value>
        [DataMember(Name="merchant_support_email", EmitDefaultValue=false)]
        public string MerchantSupportEmail { get; set; }
        /// <summary>
        /// If provided, the buyer&#39;s email is pre-populated on the checkout page as an editable text field.  Default: none; only exists if explicitly set.
        /// </summary>
        /// <value>If provided, the buyer&#39;s email is pre-populated on the checkout page as an editable text field.  Default: none; only exists if explicitly set.</value>
        [DataMember(Name="pre_populate_buyer_email", EmitDefaultValue=false)]
        public string PrePopulateBuyerEmail { get; set; }
        /// <summary>
        /// If provided, the buyer&#39;s shipping info is pre-populated on the checkout page as editable text fields.  Default: none; only exists if explicitly set.
        /// </summary>
        /// <value>If provided, the buyer&#39;s shipping info is pre-populated on the checkout page as editable text fields.  Default: none; only exists if explicitly set.</value>
        [DataMember(Name="pre_populate_shipping_address", EmitDefaultValue=false)]
        public Address PrePopulateShippingAddress { get; set; }
        /// <summary>
        /// The URL to redirect to after checkout is completed with &#x60;checkoutId&#x60;, Square&#39;s &#x60;orderId&#x60;, &#x60;transactionId&#x60;, and &#x60;referenceId&#x60; appended as URL parameters. For example, if the provided redirect_url is &#x60;http://www.example.com/order-complete&#x60;, a successful transaction redirects the customer to:  &#x60;http://www.example.com/order-complete?checkoutId&#x3D;xxxxxx&amp;orderId&#x3D;xxxxxx&amp;referenceId&#x3D;xxxxxx&amp;transactionId&#x3D;xxxxxx&#x60;  If you do not provide a redirect URL, Square Checkout will display an order confirmation page on your behalf; however Square strongly recommends that you provide a redirect URL so you can verify the transaction results and finalize the order through your existing/normal confirmation workflow.  Default: none; only exists if explicitly set.
        /// </summary>
        /// <value>The URL to redirect to after checkout is completed with &#x60;checkoutId&#x60;, Square&#39;s &#x60;orderId&#x60;, &#x60;transactionId&#x60;, and &#x60;referenceId&#x60; appended as URL parameters. For example, if the provided redirect_url is &#x60;http://www.example.com/order-complete&#x60;, a successful transaction redirects the customer to:  &#x60;http://www.example.com/order-complete?checkoutId&#x3D;xxxxxx&amp;orderId&#x3D;xxxxxx&amp;referenceId&#x3D;xxxxxx&amp;transactionId&#x3D;xxxxxx&#x60;  If you do not provide a redirect URL, Square Checkout will display an order confirmation page on your behalf; however Square strongly recommends that you provide a redirect URL so you can verify the transaction results and finalize the order through your existing/normal confirmation workflow.  Default: none; only exists if explicitly set.</value>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCheckoutRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  AskForShippingAddress: ").Append(AskForShippingAddress).Append("\n");
            sb.Append("  MerchantSupportEmail: ").Append(MerchantSupportEmail).Append("\n");
            sb.Append("  PrePopulateBuyerEmail: ").Append(PrePopulateBuyerEmail).Append("\n");
            sb.Append("  PrePopulateShippingAddress: ").Append(PrePopulateShippingAddress).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
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
            return this.Equals(obj as CreateCheckoutRequest);
        }

        /// <summary>
        /// Returns true if CreateCheckoutRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCheckoutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCheckoutRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.AskForShippingAddress == other.AskForShippingAddress ||
                    this.AskForShippingAddress != null &&
                    this.AskForShippingAddress.Equals(other.AskForShippingAddress)
                ) && 
                (
                    this.MerchantSupportEmail == other.MerchantSupportEmail ||
                    this.MerchantSupportEmail != null &&
                    this.MerchantSupportEmail.Equals(other.MerchantSupportEmail)
                ) && 
                (
                    this.PrePopulateBuyerEmail == other.PrePopulateBuyerEmail ||
                    this.PrePopulateBuyerEmail != null &&
                    this.PrePopulateBuyerEmail.Equals(other.PrePopulateBuyerEmail)
                ) && 
                (
                    this.PrePopulateShippingAddress == other.PrePopulateShippingAddress ||
                    this.PrePopulateShippingAddress != null &&
                    this.PrePopulateShippingAddress.Equals(other.PrePopulateShippingAddress)
                ) && 
                (
                    this.RedirectUrl == other.RedirectUrl ||
                    this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(other.RedirectUrl)
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
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.AskForShippingAddress != null)
                    hash = hash * 59 + this.AskForShippingAddress.GetHashCode();
                if (this.MerchantSupportEmail != null)
                    hash = hash * 59 + this.MerchantSupportEmail.GetHashCode();
                if (this.PrePopulateBuyerEmail != null)
                    hash = hash * 59 + this.PrePopulateBuyerEmail.GetHashCode();
                if (this.PrePopulateShippingAddress != null)
                    hash = hash * 59 + this.PrePopulateShippingAddress.GetHashCode();
                if (this.RedirectUrl != null)
                    hash = hash * 59 + this.RedirectUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // IdempotencyKey (string) maxLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length > 192)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be less than 192.", new [] { "IdempotencyKey" });
            }

            // IdempotencyKey (string) minLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be greater than 1.", new [] { "IdempotencyKey" });
            }

            // MerchantSupportEmail (string) maxLength
            if(this.MerchantSupportEmail != null && this.MerchantSupportEmail.Length > 254)
            {
                yield return new ValidationResult("Invalid value for MerchantSupportEmail, length must be less than 254.", new [] { "MerchantSupportEmail" });
            }

            // PrePopulateBuyerEmail (string) maxLength
            if(this.PrePopulateBuyerEmail != null && this.PrePopulateBuyerEmail.Length > 254)
            {
                yield return new ValidationResult("Invalid value for PrePopulateBuyerEmail, length must be less than 254.", new [] { "PrePopulateBuyerEmail" });
            }

            yield break;
        }
    }

}
