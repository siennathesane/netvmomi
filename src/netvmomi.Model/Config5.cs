using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Config5 {
        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "addresses")]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Autoconf
        /// </summary>
        [DataMember(Name = "autoconf", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "autoconf")]
        public bool? Autoconf { get; set; }

        /// <summary>
        /// Gets or Sets DefaultGateway
        /// </summary>
        [DataMember(Name = "default_gateway", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "default_gateway")]
        public string DefaultGateway { get; set; }

        /// <summary>
        /// Gets or Sets Dhcp
        /// </summary>
        [DataMember(Name = "dhcp", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dhcp")]
        public bool? Dhcp { get; set; }

        /// <summary>
        /// Gets or Sets InterfaceName
        /// </summary>
        [DataMember(Name = "interface_name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "interface_name")]
        public string InterfaceName { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Config5 {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Autoconf: ").Append(Autoconf).Append("\n");
            sb.Append("  DefaultGateway: ").Append(DefaultGateway).Append("\n");
            sb.Append("  Dhcp: ").Append(Dhcp).Append("\n");
            sb.Append("  InterfaceName: ").Append(InterfaceName).Append("\n");
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
