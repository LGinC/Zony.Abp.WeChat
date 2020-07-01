using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 获取帐号所属类目下的公共模板标题请求
    /// </summary>
    public class GetPubTemplateTitleListRequest :  PagedResultRequestDto  
    {
        /// <summary>
        /// 模版标题 id列表
        /// </summary>
        public long[] Ids { get; set; }
    }

    
    public class GetPubTemplateTitleListInput : MiniProgramCommonRequest
    {
        /// <summary>
        /// 模版标题 id列表
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 最大返回条数
        /// </summary>
        public int Limit { get; set; }
        
        /// <summary>
        /// 跳过数
        /// </summary>
        public int Start { get; set; }
    }
}