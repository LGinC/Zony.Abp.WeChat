using System.Collections.Generic;
using System.Text.Json.Serialization;
using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using JetBrains.Annotations;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 发送订阅消息请求
    /// </summary>
    public class SendSubscribeMessageInput : MiniProgramCommonRequest
    {
        /// <summary>
        /// 接收者（用户）的 openid    
        /// </summary>
        [JsonPropertyName("touser")]
        [NotNull]
        public string ToUser { get; set; }

        /// <summary>
        /// 所需下发的订阅模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        [NotNull]
        public string TemplateId { get; set; }

        /// <summary>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转。
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [NotNull]
        public Dictionary<string, MessageValue> Data { get; set; }

        /// <summary>
        /// 跳转小程序类型：developer为开发版；trial为体验版；formal为正式版；默认为正式版
        /// </summary>
        [JsonPropertyName("miniprogram_state")]
        public string MiniProgramState { get; set; }

        /// <summary>
        /// 进入小程序查看”的语言类型，支持zh_CN(简体中文)、en_US(英文)、zh_HK(繁体中文)、zh_TW(繁体中文)，默认为zh_CN
        /// </summary>
        public string Lang { get; set; }
        
        /// <summary>
        /// 消息值
        /// </summary>
        public class MessageValue
        {
            /// <summary>
            /// 值
            /// </summary>
            public object Value { get; set; }
        }
    }


    public class SendSubscribeMessageRequest 
    {
        /// <summary>
        /// 接收者（用户）的 openid    
        /// </summary>
        [NotNull]
        public string ToUser { get; set; }

        /// <summary>
        /// 所需下发的订阅模板id
        /// </summary>
        [NotNull]
        public string TemplateId { get; set; }

        /// <summary>
        /// 点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转。
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [NotNull]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// 跳转小程序类型：developer为开发版；trial为体验版；formal为正式版；默认为正式版
        /// </summary>
        public MiniProgramState? MiniProgramState { get; set; }

        /// <summary>
        /// 进入小程序查看”的语言类型，支持zh_CN(简体中文)、en_US(英文)、zh_HK(繁体中文)、zh_TW(繁体中文)，默认为zh_CN
        /// </summary>
        public Languege? Lang { get; set; }
    }
}