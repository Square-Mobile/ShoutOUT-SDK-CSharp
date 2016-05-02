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
    public partial class MessageResponse :  IEquatable<MessageResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResponse" /> class.
        /// Initializes a new instance of the <see cref="MessageResponse" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Cost">Cost.</param>
        /// <param name="Balance">Balance.</param>
        /// <param name="SentOn">SentOn.</param>
        /// <param name="Status">Status.</param>

        public MessageResponse(string Id = null, int? Cost = null, int? Balance = null, string SentOn = null, string Status = null)
        {
            this.Id = Id;
            this.Cost = Cost;
            this.Balance = Balance;
            this.SentOn = SentOn;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public int? Cost { get; set; }
    
        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public int? Balance { get; set; }
    
        /// <summary>
        /// Gets or Sets SentOn
        /// </summary>
        [DataMember(Name="sent_on", EmitDefaultValue=false)]
        public string SentOn { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  SentOn: ").Append(SentOn).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as MessageResponse);
        }

        /// <summary>
        /// Returns true if MessageResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResponse other)
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
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.Balance == other.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(other.Balance)
                ) && 
                (
                    this.SentOn == other.SentOn ||
                    this.SentOn != null &&
                    this.SentOn.Equals(other.SentOn)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                
                if (this.SentOn != null)
                    hash = hash * 59 + this.SentOn.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
