using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Piece2 {
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
        /// Gets or Sets LocationPassword
        /// </summary>
        [DataMember(Name = "location_password", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location_password")]
        public string LocationPassword { get; set; }

        /// <summary>
        /// Gets or Sets LocationType
        /// </summary>
        [DataMember(Name = "location_type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "location_type")]
        public string LocationType { get; set; }

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
            sb.Append("class Piece2 {\n");
            sb.Append("  BackupPassword: ").Append(BackupPassword).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LocationPassword: ").Append(LocationPassword).Append("\n");
            sb.Append("  LocationType: ").Append(LocationType).Append("\n");
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
