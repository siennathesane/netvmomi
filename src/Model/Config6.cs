using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Config6 {
        /// <summary>
        /// Gets or Sets AuthHash
        /// </summary>
        [DataMember(Name = "auth_hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "auth_hash")]
        public string AuthHash { get; set; }

        /// <summary>
        /// Gets or Sets PrivHash
        /// </summary>
        [DataMember(Name = "priv_hash", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "priv_hash")]
        public string PrivHash { get; set; }

        /// <summary>
        /// Gets or Sets RawSecret
        /// </summary>
        [DataMember(Name = "raw_secret", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "raw_secret")]
        public bool? RawSecret { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Config6 {\n");
            sb.Append("  AuthHash: ").Append(AuthHash).Append("\n");
            sb.Append("  PrivHash: ").Append(PrivHash).Append("\n");
            sb.Append("  RawSecret: ").Append(RawSecret).Append("\n");
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
