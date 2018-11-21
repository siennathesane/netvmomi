using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Config {
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
