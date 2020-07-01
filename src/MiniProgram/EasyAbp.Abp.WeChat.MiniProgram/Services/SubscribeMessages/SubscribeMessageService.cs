using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EasyAbp.Abp.WeChat.MiniProgram.Infrastructure.Models;
using EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages.Dto;

namespace EasyAbp.Abp.WeChat.MiniProgram.Services.SubscribeMessages
{
    /// <summary>
    /// 订阅消息服务
    /// </summary>
    public  class SubscribeMessageService : CommonService
    {
        public SubscribeMessageService()
        {
            BaseUrl = "https://api.weixin.qq.com/wxaapi/newtmpl/";
        }

        /// <summary>
        /// 添加模板
        /// </summary>
        /// <param name="input">模板参数</param>
        /// <returns></returns>
        public Task<AddTemplateResultDto> AddTemplateAsync(AddTemplateRequest input)
        {
            return WeChatMiniProgramApiRequester.RequestAsync<AddTemplateResultDto>(BuildUrl("addtemplate"), HttpMethod.Post, input);
        }


        /// <summary>
        /// 删除模板
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<MiniProgramCommonResponse> DeleteTemplateAsync(DeleteTemplateRequest input)
        {
            return WeChatMiniProgramApiRequester.RequestAsync<MiniProgramCommonResponse>(BuildUrl("deltemplate"), HttpMethod.Post, input);
        }


        /// <summary>
        /// 获取小程序账号的类目    
        /// </summary>
        /// <returns></returns>
        public Task<GetCategoryResponse> GetCategoryAsync()
        {
            return WeChatMiniProgramApiRequester.RequestAsync<GetCategoryResponse>(BuildUrl("getcategory"), HttpMethod.Get);
        }

        /// <summary>
        /// 获取模板标题下的关键词列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<CommonDataResponse<TemplateKeyWord>> GetPubTemplateKeyWordsByIdAsync(GetPubTemplateKeyWordsRequest input)
        {
            return  WeChatMiniProgramApiRequester.RequestAsync<CommonDataResponse<TemplateKeyWord>>(BuildUrl("getpubtemplatekeywords"), HttpMethod.Get, input);
        }


        /// <summary>
        /// 获取帐号所属类目下的公共模板标题
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<CommonDataResponse<PubTemplateTitle>> GetPubTemplateTitleListAsync(
            GetPubTemplateTitleListRequest input)
        {
            var request = new GetPubTemplateTitleListInput
            {
                Ids = input.Ids.JoinAsString(","),
                Limit = input.MaxResultCount,
                Start = input.SkipCount
            };
            return WeChatMiniProgramApiRequester.RequestAsync<CommonDataResponse<PubTemplateTitle>>(BuildUrl("getpubtemplatetitles"), HttpMethod.Get, request);
        }

        /// <summary>
        /// 获取当前帐号下的个人模板列表
        /// </summary>
        /// <returns></returns>
        public Task<CommonDataResponse<Template>> GetTemplateListAsync()
        {
            return WeChatMiniProgramApiRequester.RequestAsync<CommonDataResponse<Template>>(BuildUrl("gettemplate"), HttpMethod.Get);
        }

        /// <summary>
        /// 发送订阅消息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<MiniProgramCommonResponse> SendAsync(SendSubscribeMessageRequest input)
        {
            var request = new SendSubscribeMessageInput
            {
                ToUser = input.ToUser,
                TemplateId = input.TemplateId,
                Page = input.Page,
                Data = input.Data.ToDictionary(d => d.Key,d => new SendSubscribeMessageInput.MessageValue{Value = d.Value}),
                MiniProgramState = input.MiniProgramState.HasValue ? input.MiniProgramState.ToString() : null,
                Lang = input.Lang.HasValue ? input.Lang.ToString() : null,
            };
            BaseUrl = "https://api.weixin.qq.com/cgi-bin/message/subscribe/";
            return WeChatMiniProgramApiRequester.RequestAsync<MiniProgramCommonResponse>(BuildUrl("send"), HttpMethod.Post, request);
        }
    }
}