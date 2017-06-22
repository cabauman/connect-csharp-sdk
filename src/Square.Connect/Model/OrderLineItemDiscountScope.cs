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
    /// Indicates whether this is a line item or order-level discount.
    /// </summary>
    /// <value>Indicates whether this is a line item or order-level discount.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderLineItemDiscountScope
    {
        
        /// <summary>
        /// Enum LINEITEM for "LINE_ITEM"
        /// </summary>
        [EnumMember(Value = "LINE_ITEM")]
        LINEITEM,
        
        /// <summary>
        /// Enum ORDER for "ORDER"
        /// </summary>
        [EnumMember(Value = "ORDER")]
        ORDER
    }

}
