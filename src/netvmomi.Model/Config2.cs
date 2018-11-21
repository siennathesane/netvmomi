using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Config2 {
        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Servers
        /// </summary>
        [DataMember(Name = "servers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "servers")]
        public List<string> Servers { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Config2 {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
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
