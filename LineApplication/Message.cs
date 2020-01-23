using Newtonsoft.Json;

namespace PushMessageSample
{
    [JsonObject]
    public class Message
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        public Message(string type, string text)
        {
            this.Type = type;
            this.Text = text;
        }
    }
}
