using System.ComponentModel;

namespace EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models
{
    /// <summary>
    /// 小程序状态
    /// </summary>
    public enum MiniProgramState
    {
        /// <summary>
        /// 正式版
        /// </summary>
        [Description("正式版")]
        Formal,
        
        /// <summary>
        /// 开发版
        /// </summary>
        [Description("开发版")]
        Developer,
        
        /// <summary>
        /// 体验版
        /// </summary>
        [Description("体验版")]
        Trial,
        
        
    }
}