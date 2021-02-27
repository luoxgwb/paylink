﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain
{
    /// <summary>
    ///  微信支付分 - 解除用户授权关系（openid）
    ///  <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter6_1_6.shtml">解除用户授权关系（openid）API</a></para>
    /// </summary>
    public class WeChatPayScorePermissionsTerminateForOpenIdModel : WeChatPayObject
    {
        /// <summary>
        /// 支付分服务ID
        /// </summary>
        /// <remarks>
        /// 服务ID有本接口对应产品的权限。
        /// 示例值：500001
        /// </remarks>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 撤销原因
        /// </summary>
        /// <remarks>
        /// 解除授权原因 
        /// 示例值：撤销原因
        /// </remarks>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
