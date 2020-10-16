using Newtonsoft.Json;
using System.Collections.Generic;

namespace HomeAssistantDiscoveryHelper
{
    public class HomeAssistantDiscovery
    {
        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("~", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicBase { get; set; }
        [JsonProperty("command_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandTopic { get; set; }
        [JsonProperty("availability_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityTopic { get; set; }
        [JsonProperty("state_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string StateTopic { get; set; }
        [JsonProperty("effect_list", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> EffectList { get; set; }
        [JsonProperty("effect_command_topic", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectTopic { get; set; }
        [JsonProperty("retain")]
        public bool Retain { get; set; }
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public HomeAssistantDevice Device { get; set; }
    }
}
