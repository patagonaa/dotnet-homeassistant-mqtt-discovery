using Newtonsoft.Json;
using System.Collections.Generic;

namespace HomeAssistantDiscoveryHelper
{
    public class HomeAssistantDevice
    {
        [JsonProperty("identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Identifiers { get; set; }
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}
