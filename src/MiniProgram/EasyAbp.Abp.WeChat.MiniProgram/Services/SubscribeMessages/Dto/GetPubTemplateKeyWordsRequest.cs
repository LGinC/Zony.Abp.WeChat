using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using JetBrains.Annotations;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 获取模板标题下的关键词列表请求
    /// </summary>
    public class GetPubTemplateKeyWordsRequest : MiniProgramCommonRequest
    {
        /// <summary>
        /// 模板标题 id
        /// </summary>
        [NotNull]
        public string Tid { get; set; }
    }
}