using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CreateruleRequest {
        /// <summary>
        /// Gets or Sets Pos
        /// </summary>
        [DataMember(Name = "pos", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pos")]
        public int? Pos { get; set; }

        /// <summary>
        /// Gets or Sets Rule
        /// </summary>
        [DataMember(Name = "rule", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rule")]
        public Rule Rule { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateruleRequest {\n");
            sb.Append("  Pos: ").Append(Pos).Append("\n");
            sb.Append("  Rule: ").Append(Rule).Append("\n");
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
