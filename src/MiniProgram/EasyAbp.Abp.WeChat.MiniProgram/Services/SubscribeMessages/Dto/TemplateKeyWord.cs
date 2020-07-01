using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 模板下的关键词
    /// </summary>
    public class TemplateKeyWord
    {
        /// <summary>
        /// 关键词 id，选用模板时需要
        /// </summary>
        public int Kid { get; set; }

        /// <summary>
        /// 关键词内容
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 关键词内容对应的示例
        /// </summary>
        public string Example { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        public string Rule { get; set; }
    }
}