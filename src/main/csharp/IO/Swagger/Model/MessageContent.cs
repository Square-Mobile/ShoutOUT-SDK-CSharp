using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class MessageContent :  IEquatable<MessageContent>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContent" /> class.
        /// Initializes a new instance of the <see cref="MessageContent" />class.
        /// </summary>
        /// <param name="Sms">Sms.</param>

        public MessageContent(string Sms = null)
        {
            this.Sms = Sms;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sms
        /// </summary>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public string Sms { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageContent {\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            
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
            return this.Equals(obj as MessageContent);
        }

        /// <summary>
        /// Returns true if MessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sms == other.Sms ||
                    this.Sms != null &&
                    this.Sms.Equals(other.Sms)
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
                
                if (this.Sms != null)
                    hash = hash * 59 + this.Sms.GetHashCode();
                
                return hash;
            }
        }

    }
}
