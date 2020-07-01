using System.Threading.Tasks;
using EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages;
using EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace EasyAbp.Abp.WeChat.MiniProgram.Tests.Services
{
    /// <summary>
    /// 订阅消息服务测试
    /// </summary>
    public class SubscribeMessageService_Tests: AbpWeChatMiniProgramTestBase
    {
        private readonly SubscribeMessageService _service;
        private readonly ITestOutputHelper Output;
        
        public SubscribeMessageService_Tests(ITestOutputHelper output)
        {
            Output = output;
            _service = GetRequiredService<SubscribeMessageService>();
        }

        [Fact]
        public async Task AddTemplateTest()
        {
            var result = await _service.AddTemplateAsync(new AddTemplateRequest
            {
                Tid = "",
                KidList = new[] {1},
                SceneDesc = ""
            });
            Output.WriteLine($"{result.ErrorCode.ToString()}:{result.ErrorStr}");
            result.ShouldNotBeNull();
            result.ErrorCode.ShouldBe(0);
        }
    }
}