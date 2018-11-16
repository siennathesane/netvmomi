using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace netvmomi.Model {

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RestorejobCreateRequest {
        /// <summary>
        /// Gets or Sets Piece
        /// </summary>
        [DataMember(Name = "piece", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "piece")]
        public Piece2 Piece { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RestorejobCreateRequest {\n");
            sb.Append("  Piece: ").Append(Piece).Append("\n");
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
