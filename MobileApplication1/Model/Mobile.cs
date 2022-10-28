using System.Text.Json;
using System.Text.Json.Serialization;

namespace MobileAplication.Model
{
    public class Mobile
    {
        [JsonPropertyName("id")]
        public int mobile_id { get; set; }

        [JsonPropertyName("model")]
        public string mobile_model { get; set; }

        [JsonPropertyName("image")]
        public string mobile_img { get; set; }

        // saving data into file using override-tostring .....
        public override string ToString()
        {
            return JsonSerializer.Serialize<Mobile>(this);
        }

    }
}
