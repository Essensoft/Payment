﻿using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 基础支付（服务商）- 关闭订单
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter5_6.shtml">关单API</a> - 最新更新时间：2020.05.26</para>
    /// </remarks>
    public class WeChatPayPartnerTransactionsOutTradeNoCloseRequest : IWeChatPayPostRequest<WeChatPayPartnerTransactionsOutTradeNoCloseResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号，只能是数字、大小写字母_-*且在同一个商户号下唯一，详见【商户订单号】。
        /// 特殊规则：最小字符长度为6
        /// <para>示例值：1217752501201407033233368018</para>
        /// </remarks>
        public string OutTradeNo { get; set; }

        private WeChatPayObject bodyModel;

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/pay/partner/transactions/out-trade-no/{OutTradeNo}/close";
        }

        public WeChatPayObject GetBodyModel()
        {
            return bodyModel;
        }

        public void SetBodyModel(WeChatPayObject bodyModel)
        {
            this.bodyModel = bodyModel;
        }
    }
}
