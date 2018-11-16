using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Config7 {
        /// <summary>
        /// Gets or Sets Authentication
        /// </summary>
        [DataMember(Name = "authentication", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "authentication")]
        public string Authentication { get; set; }

        /// <summary>
        /// Gets or Sets Communities
        /// </summary>
        [DataMember(Name = "communities", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "communities")]
        public List<string> Communities { get; set; }

        /// <summary>
        /// Gets or Sets Engineid
        /// </summary>
        [DataMember(Name = "engineid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "engineid")]
        public string Engineid { get; set; }

        /// <summary>
        /// Gets or Sets Loglevel
        /// </summary>
        [DataMember(Name = "loglevel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "loglevel")]
        public string Loglevel { get; set; }

        /// <summary>
        /// Gets or Sets Notraps
        /// </summary>
        [DataMember(Name = "notraps", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notraps")]
        public List<string> Notraps { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "privacy")]
        public string Privacy { get; set; }

        /// <summary>
        /// Gets or Sets Remoteusers
        /// </summary>
        [DataMember(Name = "remoteusers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "remoteusers")]
        public List<string> Remoteusers { get; set; }

        /// <summary>
        /// Gets or Sets Syscontact
        /// </summary>
        [DataMember(Name = "syscontact", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "syscontact")]
        public string Syscontact { get; set; }

        /// <summary>
        /// Gets or Sets Syslocation
        /// </summary>
        [DataMember(Name = "syslocation", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "syslocation")]
        public string Syslocation { get; set; }

        /// <summary>
        /// Gets or Sets Targets
        /// </summary>
        [DataMember(Name = "targets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "targets")]
        public List<string> Targets { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "users")]
        public List<string> Users { get; set; }

        /// <summary>
        /// Gets or Sets V3targets
        /// </summary>
        [DataMember(Name = "v3targets", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "v3targets")]
        public List<string> V3targets { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Config7 {\n");
            sb.Append("  Authentication: ").Append(Authentication).Append("\n");
            sb.Append("  Communities: ").Append(Communities).Append("\n");
            sb.Append("  Engineid: ").Append(Engineid).Append("\n");
            sb.Append("  Loglevel: ").Append(Loglevel).Append("\n");
            sb.Append("  Notraps: ").Append(Notraps).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Remoteusers: ").Append(Remoteusers).Append("\n");
            sb.Append("  Syscontact: ").Append(Syscontact).Append("\n");
            sb.Append("  Syslocation: ").Append(Syslocation).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  V3targets: ").Append(V3targets).Append("\n");
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
