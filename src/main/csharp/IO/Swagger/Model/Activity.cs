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
    public partial class Activity :  IEquatable<Activity>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// Initializes a new instance of the <see cref="Activity" />class.
        /// </summary>
        /// <param name="Title">Title (required).</param>
        /// <param name="TemplateId">TemplateId (required).</param>
        /// <param name="Points">Points.</param>
        /// <param name="PointsRate">PointsRate.</param>
        /// <param name="MetaData">MetaData.</param>

        public Activity(string Title = null, int? TemplateId = null, double? Points = null, double? PointsRate = null, Object MetaData = null)
        {
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for Activity and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "TemplateId" is required (not null)
            if (TemplateId == null)
            {
                throw new InvalidDataException("TemplateId is a required property for Activity and cannot be null");
            }
            else
            {
                this.TemplateId = TemplateId;
            }
            this.Points = Points;
            this.PointsRate = PointsRate;
            this.MetaData = MetaData;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="template_id", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }
    
        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public double? Points { get; set; }
    
        /// <summary>
        /// Gets or Sets PointsRate
        /// </summary>
        [DataMember(Name="points_rate", EmitDefaultValue=false)]
        public double? PointsRate { get; set; }
    
        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name="meta_data", EmitDefaultValue=false)]
        public Object MetaData { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  PointsRate: ").Append(PointsRate).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            
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
            return this.Equals(obj as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="other">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.Points == other.Points ||
                    this.Points != null &&
                    this.Points.Equals(other.Points)
                ) && 
                (
                    this.PointsRate == other.PointsRate ||
                    this.PointsRate != null &&
                    this.PointsRate.Equals(other.PointsRate)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.Equals(other.MetaData)
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
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                
                if (this.Points != null)
                    hash = hash * 59 + this.Points.GetHashCode();
                
                if (this.PointsRate != null)
                    hash = hash * 59 + this.PointsRate.GetHashCode();
                
                if (this.MetaData != null)
                    hash = hash * 59 + this.MetaData.GetHashCode();
                
                return hash;
            }
        }

    }
}
