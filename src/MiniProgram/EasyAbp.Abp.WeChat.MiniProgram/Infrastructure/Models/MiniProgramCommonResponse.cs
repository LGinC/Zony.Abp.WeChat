using System;
using Newtonsoft.Json;
using Volo.Abp;

namespace EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models
{
    public class MiniProgramCommonResponse : IMiniProgramResponse
    {
        [JsonProperty("errmsg")] public string ErrorMessage { get; set; }

        [JsonProperty("errcode")] public int ErrorCode { get; set; }

        public ReturnCode Code => (ReturnCode) ErrorCode;

        public string ErrorStr => Code.ToString();


        /// <summary>
        ///  检查结果返回是否异常
        /// </summary>
        /// <param name="throwException">是否直接抛出异常</param>
        /// <exception cref="Exception"></exception>
        /// <returns>是否有异常</returns>
        public bool CheckError(bool throwException = true)
        {
            var result = ErrorCode != 0;
            if (result && throwException)
            {
                throw new UserFriendlyException($"{ErrorCode.ToString()}:{ErrorMessage}");
            }

            return result;
        }
    }
}