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
    /// UserConfig
    /// </summary>
    [DataContract]
    public partial class UserConfig :  IEquatable<UserConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfig" /> class.
        /// </summary>
        /// <param name="iNTERPLANETARYFISSIONURL">iNTERPLANETARYFISSIONURL (required).</param>
        /// <param name="iNTERPLANETARYFISSIONUSERNAME">iNTERPLANETARYFISSIONUSERNAME (required).</param>
        /// <param name="iNTERPLANETARYFISSIONPASSWORD">iNTERPLANETARYFISSIONPASSWORD (required).</param>
        public UserConfig(string iNTERPLANETARYFISSIONURL = default(string), string iNTERPLANETARYFISSIONUSERNAME = default(string), Secret iNTERPLANETARYFISSIONPASSWORD = default(Secret))
        {
            // to ensure "iNTERPLANETARYFISSIONURL" is required (not null)
            if (iNTERPLANETARYFISSIONURL == null)
            {
                throw new InvalidDataException("iNTERPLANETARYFISSIONURL is a required property for UserConfig and cannot be null");
            }
            else
            {
                this.INTERPLANETARY_FISSION_URL = iNTERPLANETARYFISSIONURL;
            }
            // to ensure "iNTERPLANETARYFISSIONUSERNAME" is required (not null)
            if (iNTERPLANETARYFISSIONUSERNAME == null)
            {
                throw new InvalidDataException("iNTERPLANETARYFISSIONUSERNAME is a required property for UserConfig and cannot be null");
            }
            else
            {
                this.INTERPLANETARY_FISSION_USERNAME = iNTERPLANETARYFISSIONUSERNAME;
            }
            // to ensure "iNTERPLANETARYFISSIONPASSWORD" is required (not null)
            if (iNTERPLANETARYFISSIONPASSWORD == null)
            {
                throw new InvalidDataException("iNTERPLANETARYFISSIONPASSWORD is a required property for UserConfig and cannot be null");
            }
            else
            {
                this.INTERPLANETARY_FISSION_PASSWORD = iNTERPLANETARYFISSIONPASSWORD;
            }
        }
        
        /// <summary>
        /// Gets or Sets INTERPLANETARY_FISSION_URL
        /// </summary>
        [DataMember(Name="INTERPLANETARY_FISSION_URL", EmitDefaultValue=false)]
        public string INTERPLANETARY_FISSION_URL { get; set; }

        /// <summary>
        /// Gets or Sets INTERPLANETARY_FISSION_USERNAME
        /// </summary>
        [DataMember(Name="INTERPLANETARY_FISSION_USERNAME", EmitDefaultValue=false)]
        public string INTERPLANETARY_FISSION_USERNAME { get; set; }

        /// <summary>
        /// Gets or Sets INTERPLANETARY_FISSION_PASSWORD
        /// </summary>
        [DataMember(Name="INTERPLANETARY_FISSION_PASSWORD", EmitDefaultValue=false)]
        public Secret INTERPLANETARY_FISSION_PASSWORD { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserConfig {\n");
            sb.Append("  INTERPLANETARY_FISSION_URL: ").Append(INTERPLANETARY_FISSION_URL).Append("\n");
            sb.Append("  INTERPLANETARY_FISSION_USERNAME: ").Append(INTERPLANETARY_FISSION_USERNAME).Append("\n");
            sb.Append("  INTERPLANETARY_FISSION_PASSWORD: ").Append(INTERPLANETARY_FISSION_PASSWORD).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as UserConfig);
        }

        /// <summary>
        /// Returns true if UserConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of UserConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.INTERPLANETARY_FISSION_URL == input.INTERPLANETARY_FISSION_URL ||
                    (this.INTERPLANETARY_FISSION_URL != null &&
                    this.INTERPLANETARY_FISSION_URL.Equals(input.INTERPLANETARY_FISSION_URL))
                ) && 
                (
                    this.INTERPLANETARY_FISSION_USERNAME == input.INTERPLANETARY_FISSION_USERNAME ||
                    (this.INTERPLANETARY_FISSION_USERNAME != null &&
                    this.INTERPLANETARY_FISSION_USERNAME.Equals(input.INTERPLANETARY_FISSION_USERNAME))
                ) && 
                (
                    this.INTERPLANETARY_FISSION_PASSWORD == input.INTERPLANETARY_FISSION_PASSWORD ||
                    (this.INTERPLANETARY_FISSION_PASSWORD != null &&
                    this.INTERPLANETARY_FISSION_PASSWORD.Equals(input.INTERPLANETARY_FISSION_PASSWORD))
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
                if (this.INTERPLANETARY_FISSION_URL != null)
                    hashCode = hashCode * 59 + this.INTERPLANETARY_FISSION_URL.GetHashCode();
                if (this.INTERPLANETARY_FISSION_USERNAME != null)
                    hashCode = hashCode * 59 + this.INTERPLANETARY_FISSION_USERNAME.GetHashCode();
                if (this.INTERPLANETARY_FISSION_PASSWORD != null)
                    hashCode = hashCode * 59 + this.INTERPLANETARY_FISSION_PASSWORD.GetHashCode();
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
