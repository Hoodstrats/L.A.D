/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using Newtonsoft.Json;

namespace Hood.Core
{
    public struct JsonConfig
    {
        [JsonProperty("LogIndex")]
        public int _logIndex { get; set; }
        [JsonProperty("CPU")]
        public bool _cpuPriority { get; set; }
        [JsonProperty("SaveFile")]
        public string _saveFile {get;set;}
        [JsonProperty("SavePath")]
        public string _savePath { get; set; }
    }
}
