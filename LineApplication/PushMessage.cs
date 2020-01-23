using Newtonsoft.Json;
using System.Collections.Generic;

namespace PushMessageSample
{
    [JsonObject]
    public class PushMessage
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("messages")]
        public List<Message> message { get; set; } = new List<Message>();
    }
}
