using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RecurrenceInfo {
        /// <summary>
        /// Gets or Sets Hour
        /// </summary>
        [DataMember(Name = "hour", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [DataMember(Name = "days", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "days")]
        public List<string> Days { get; set; }

        /// <summary>
        /// Gets or Sets Minute
        /// </summary>
        [DataMember(Name = "minute", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "minute")]
        public int? Minute { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecurrenceInfo {\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Minute: ").Append(Minute).Append("\n");
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
