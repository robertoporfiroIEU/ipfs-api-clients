/* 
 * FISSION
 *
 * Easily use IPFS from Web 2.0 applications
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@fission.codes
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines Tier
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Tier
    {
        
        /// <summary>
        /// Enum Test for value: test
        /// </summary>
        [EnumMember(Value = "test")]
        Test = 1,
        
        /// <summary>
        /// Enum Free for value: free
        /// </summary>
        [EnumMember(Value = "free")]
        Free = 2
    }

}
