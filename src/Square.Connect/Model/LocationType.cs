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
    /// Indicates the location's type.
    /// </summary>
    /// <value>Indicates the location's type.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationType
    {
        
        /// <summary>
        /// Enum PHYSICAL for "PHYSICAL"
        /// </summary>
        [EnumMember(Value = "PHYSICAL")]
        PHYSICAL,
        
        /// <summary>
        /// Enum MOBILE for "MOBILE"
        /// </summary>
        [EnumMember(Value = "MOBILE")]
        MOBILE
    }

}