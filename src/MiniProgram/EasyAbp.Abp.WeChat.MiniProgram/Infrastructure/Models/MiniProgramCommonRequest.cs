using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models
{
    public abstract class MiniProgramCommonRequest : IMiniProgramRequest
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),//序列化 驼峰
            });
        }
    }
}