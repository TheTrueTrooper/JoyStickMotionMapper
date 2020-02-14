using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JoyStickMotionMapper
{
    [JsonConverter(typeof(StringEnumConverter))]
    enum AvalibleProtocols
    {
        ComPort
    }
}
