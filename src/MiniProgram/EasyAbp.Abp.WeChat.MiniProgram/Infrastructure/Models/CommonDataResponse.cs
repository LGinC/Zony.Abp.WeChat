namespace EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models
{
    /// <summary>
    /// 包含数据列表的返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CommonDataResponse<T> : MiniProgramCommonResponse
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        public T[] Data { get; set; }
    }
}