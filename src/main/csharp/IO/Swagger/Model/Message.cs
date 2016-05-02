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
    public partial class Message :  IEquatable<Message>
    { 
        public enum  {
            
            [EnumMember(Value = "sms")]
            Sms
        }

    
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// Initializes a new instance of the <see cref="Message" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Source">Source (required).</param>
        /// <param name="Destinations">Destinations (required).</param>
        /// <param name="Transports">Transports.</param>
        /// <param name="Content">Content.</param>

        public Message(string Id = null, string Source = null, List<string> Destinations = null, List<TransportsEnum?> Transports = null, MessageContent Content = null)
        {
            // to ensure "Source" is required (not null)
            if (Source == null)
            {
                throw new InvalidDataException("Source is a required property for Message and cannot be null");
            }
            else
            {
                this.Source = Source;
            }
            // to ensure "Destinations" is required (not null)
            if (Destinations == null)
            {
                throw new InvalidDataException("Destinations is a required property for Message and cannot be null");
            }
            else
            {
                this.Destinations = Destinations;
            }
            this.Id = Id;
            this.Transports = Transports;
            this.Content = Content;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
    
        /// <summary>
        /// Gets or Sets Destinations
        /// </summary>
        [DataMember(Name="destinations", EmitDefaultValue=false)]
        public List<string> Destinations { get; set; }
    
        /// <summary>
        /// Gets or Sets Transports
        /// </summary>
        [DataMember(Name="transports", EmitDefaultValue=false)]
        public List<string> Transports { get; set; }
    
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public MessageContent Content { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  Transports: ").Append(Transports).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            
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
            return this.Equals(obj as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="other">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Destinations == other.Destinations ||
                    this.Destinations != null &&
                    this.Destinations.SequenceEqual(other.Destinations)
                ) && 
                (
                    this.Transports == other.Transports ||
                    this.Transports != null &&
                    this.Transports.SequenceEqual(other.Transports)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                
                if (this.Destinations != null)
                    hash = hash * 59 + this.Destinations.GetHashCode();
                
                if (this.Transports != null)
                    hash = hash * 59 + this.Transports.GetHashCode();
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                return hash;
            }
        }

    }
}
