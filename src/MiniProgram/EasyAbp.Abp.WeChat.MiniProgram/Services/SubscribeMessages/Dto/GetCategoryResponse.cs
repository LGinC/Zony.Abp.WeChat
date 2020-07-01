using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto
{
    /// <summary>
    /// 获取小程序账号的类目请求
    /// </summary>
    public class GetCategoryResponse : MiniProgramCommonResponse
    {
        /// <summary>
        /// 类目数据
        /// </summary>
        public Category[] Data { get; set; }
        
        /// <summary>
        /// 类目
        /// </summary>
        public class Category
        {
            /// <summary>
            /// 类目id
            /// </summary>
            public long Id { get; set; }

            /// <summary>
            /// 类目名称
            /// </summary>
            public string Name { get; set; }
        }
    }
}