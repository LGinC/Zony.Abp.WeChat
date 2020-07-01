namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 订阅消息模板
    /// </summary>
    public class Template
    {
        /// <summary>
        /// 添加至帐号下的模板 id，发送小程序订阅消息时所需
        /// </summary>
        public string PriTmplId { get; set; }

        /// <summary>
        /// 模版标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 模版内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 模板内容示例
        /// </summary>
        public string Example { get; set; }

        /// <summary>
        /// 模版类型
        /// </summary>
        public PubTemplateType Type { get; set; }
    }
}