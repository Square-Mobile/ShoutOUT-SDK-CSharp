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
    public partial class ActivityRecord :  IEquatable<ActivityRecord>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityRecord" /> class.
        /// Initializes a new instance of the <see cref="ActivityRecord" />class.
        /// </summary>
        /// <param name="UserId">UserId (required).</param>
        /// <param name="ActivityId">ActivityId.</param>
        /// <param name="ActivityName">ActivityName.</param>
        /// <param name="ActivityData">ActivityData.</param>

        public ActivityRecord(string UserId = null, string ActivityId = null, string ActivityName = null, Object ActivityData = null)
        {
            // to ensure "UserId" is required (not null)
            if (UserId == null)
            {
                throw new InvalidDataException("UserId is a required property for ActivityRecord and cannot be null");
            }
            else
            {
                this.UserId = UserId;
            }
            this.ActivityId = ActivityId;
            this.ActivityName = ActivityName;
            this.ActivityData = ActivityData;
            
        }
        
    
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or Sets ActivityId
        /// </summary>
        [DataMember(Name="activity_id", EmitDefaultValue=false)]
        public string ActivityId { get; set; }
    
        /// <summary>
        /// Gets or Sets ActivityName
        /// </summary>
        [DataMember(Name="activity_name", EmitDefaultValue=false)]
        public string ActivityName { get; set; }
    
        /// <summary>
        /// Gets or Sets ActivityData
        /// </summary>
        [DataMember(Name="activity_data", EmitDefaultValue=false)]
        public Object ActivityData { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityRecord {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
            sb.Append("  ActivityData: ").Append(ActivityData).Append("\n");
            
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
            return this.Equals(obj as ActivityRecord);
        }

        /// <summary>
        /// Returns true if ActivityRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ActivityId == other.ActivityId ||
                    this.ActivityId != null &&
                    this.ActivityId.Equals(other.ActivityId)
                ) && 
                (
                    this.ActivityName == other.ActivityName ||
                    this.ActivityName != null &&
                    this.ActivityName.Equals(other.ActivityName)
                ) && 
                (
                    this.ActivityData == other.ActivityData ||
                    this.ActivityData != null &&
                    this.ActivityData.Equals(other.ActivityData)
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
                
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                
                if (this.ActivityId != null)
                    hash = hash * 59 + this.ActivityId.GetHashCode();
                
                if (this.ActivityName != null)
                    hash = hash * 59 + this.ActivityName.GetHashCode();
                
                if (this.ActivityData != null)
                    hash = hash * 59 + this.ActivityData.GetHashCode();
                
                return hash;
            }
        }

    }
}
