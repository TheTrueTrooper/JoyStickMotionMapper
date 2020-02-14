using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoyStickMotionMapper;

namespace JoyStickMotionMapper.ConfigHelper
{
    class SystemConfig
    {
        public static SystemConfig ConfigFactory(string Location)
        {
            SystemConfig Return;
            using (Stream Stream = new FileStream(Location, FileMode.Open))
            using (StreamReader SR = new StreamReader(Stream))
            using (JsonReader Reader = new JsonTextReader(SR))
            {
                JsonSerializer Serializer = new JsonSerializer();
                Return = Serializer.Deserialize<SystemConfig>(Reader);
            }
            return Return;
        }

        public void SaveConfig(string Path)
        {
            using (Stream Stream = new FileStream(Path, FileMode.Create))
            using (StreamWriter SR = new StreamWriter(Stream))
            {
                SR.Write(JsonConvert.SerializeObject(this, Formatting.Indented));
                SR.Close();
            }
        }

        [JsonProperty("GamePath")]
        public string GamePath { get; set; }
        [JsonProperty("StartOptionsRunArgs")]
        public string StartOptionsRunArgs { get; set; }
        [JsonProperty("StartOptionsInput")]
        public string StartOptionsInput { get; set; }
        [JsonProperty("RuntimeProcess")]
        public string RuntimeProcess { get; set; }
        [JsonProperty("MotionOutPutPath")]
        public string MotionOutPutPath { get; set; }
        [JsonProperty("ProtocolType"), JsonConverter(typeof(StringEnumConverter))]
        public AvalibleProtocols? ProtocolType { get; set; }
        [JsonProperty("ProtocolConnectionString")]
        public string ProtocolConnectionString { get; set; }
        [JsonProperty("TimeBetweenTicksMS")]
        public ulong TimeBetweenTicksMS { get; set; }
    }
}
