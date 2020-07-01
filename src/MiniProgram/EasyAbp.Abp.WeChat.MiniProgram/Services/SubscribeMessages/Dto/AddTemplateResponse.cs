using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 添加订阅消息模板结果
    /// </summary>
    public class AddTemplateResultDto : MiniProgramCommonResponse
    {
        /// <summary>
        /// 添加至帐号下的模板id，发送小程序订阅消息时所需
        /// </summary>
        public string PriTmplId { get; set; }
    }
}