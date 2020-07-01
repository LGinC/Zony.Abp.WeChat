using System.ComponentModel;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 公共模板标题
    /// </summary>
    public class PubTemplateTitle
    {
        /// <summary>
        /// 模版标题 id
        /// </summary>
        public long Tid { get; set; }

        /// <summary>
        /// 模版标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 模版类型
        /// </summary>
        public PubTemplateType Type { get; set; }

        /// <summary>
        /// 模版所属类目 id
        /// </summary>
        public string CategoryId { get; set; }
    }

    public enum PubTemplateType
    {
        /// <summary>
        /// 一次性
        /// </summary>
        [Description("一次性")]
        Once = 2,
        
        /// <summary>
        /// 长期
        /// </summary>
        [Description("长期")]
        Long = 3,
    }
}