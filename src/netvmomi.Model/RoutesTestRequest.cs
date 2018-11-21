using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RoutesTestRequest {
        /// <summary>
        /// Gets or Sets Gateways
        /// </summary>
        [DataMember(Name = "gateways", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gateways")]
        public List<string> Gateways { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoutesTestRequest {\n");
            sb.Append("  Gateways: ").Append(Gateways).Append("\n");
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
