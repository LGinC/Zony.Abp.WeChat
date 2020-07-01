using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 删除模板请求
    /// </summary>
    public class DeleteTemplateRequest : MiniProgramCommonRequest
    {
        /// <summary>
        /// 要删除的模板id
        /// </summary>
        public string PriTmplId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="templateId">模板id</param>
        public DeleteTemplateRequest(string templateId)
        {
            PriTmplId = templateId;
        }
    }
}