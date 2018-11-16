using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Config12 {
        /// <summary>
        /// Gets or Sets CheckUpdates
        /// </summary>
        [DataMember(Name = "check_updates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "check_updates")]
        public string CheckUpdates { get; set; }

        /// <summary>
        /// Gets or Sets CurrentURL
        /// </summary>
        [DataMember(Name = "current_URL", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "current_URL")]
        public string CurrentURL { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "day")]
        public string Day { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Config12 {\n");
            sb.Append("  CheckUpdates: ").Append(CheckUpdates).Append("\n");
            sb.Append("  CurrentURL: ").Append(CurrentURL).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
