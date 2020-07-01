using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using JetBrains.Annotations;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 添加模板请求
    /// </summary>
    public class AddTemplateRequest : MiniProgramCommonRequest
    {
        /// <summary>
        /// 模板标题 id，可通过接口获取，也可登录小程序后台查看获取 必填
        /// </summary>
        [NotNull]
        public string Tid { get; set; }

        /// <summary>
        /// 开发者自行组合好的模板关键词列表，关键词顺序可以自由搭配（例如 [3,5,4] 或 [4,5,3]），最多支持5个，最少2个关键词组合 必填
        /// </summary>
        [NotNull]
        public int[] KidList { get; set; }

        /// <summary>
        /// 服务场景描述，15个字以内
        /// </summary>
        public string SceneDesc { get; set; }
    }
}