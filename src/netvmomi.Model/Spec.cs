using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Spec {
        /// <summary>
        /// Gets or Sets RecurrenceInfo
        /// </summary>
        [DataMember(Name = "recurrence_info", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "recurrence_info")]
        public RecurrenceInfo RecurrenceInfo { get; set; }

        /// <summary>
        /// Gets or Sets BackupPassword
        /// </summary>
        [DataMember(Name = "backup_password", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "backup_password")]
        public string BackupPassword { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets RetentionInfo
        /// </summary>
        [DataMember(Name = "retention_info", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "retention_info")]
        public RetentionInfo RetentionInfo { get; set; }

        /// <summary>
        /// Gets or Sets Parts
        /// </summary>
        [DataMember(Name = "parts", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parts")]
        public List<string> Parts { get; set; }

        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name = "enable", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Gets or Sets LocationPassword
        /// </summary>
        [DataMember(Name = "location_password", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location_password")]
        public string LocationPassword { get; set; }

        /// <summary>
        /// Gets or Sets LocationUser
        /// </summary>
        [DataMember(Name = "location_user", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location_user")]
        public string LocationUser { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Spec {\n");
            sb.Append("  RecurrenceInfo: ").Append(RecurrenceInfo).Append("\n");
            sb.Append("  BackupPassword: ").Append(BackupPassword).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  RetentionInfo: ").Append(RetentionInfo).Append("\n");
            sb.Append("  Parts: ").Append(Parts).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  LocationPassword: ").Append(LocationPassword).Append("\n");
            sb.Append("  LocationUser: ").Append(LocationUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson() {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
