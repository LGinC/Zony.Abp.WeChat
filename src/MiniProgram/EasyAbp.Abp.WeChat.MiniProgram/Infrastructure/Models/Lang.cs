using System.ComponentModel;

namespace EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models
{
    /// <summary>
    /// 小程序语言
    /// </summary>
    public enum Languege
    {
        /// <summary>
        /// 简体中文
        /// </summary>
        [Description("简体中文")]
        zh_CN,
        /// <summary>
        /// 英文
        /// </summary>
        [Description("英文")]
        en_US,
        /// <summary>
        /// 繁体中文(香港)
        /// </summary>
        [Description("繁体中文(香港)")]
        zh_HK,
        /// <summary>
        /// 繁体中文(台湾)
        /// </summary>
        [Description("繁体中文(台湾)")]
        zh_TW,
    }
}