using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 查询代金券批次
    /// </summary>
    public class WeChatPayQueryCouponStockRequest : WeChatPayRequest<WeChatPayQueryCouponStockResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 代金券批次id
        /// </summary>
        public string CouponStockId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 协议版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        public string Type { get; set; }

        #region IWeChatPayRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/mmpaymkttransfers/query_coupon_stock";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_coupon_stock_id, CouponStockId },
                { ConstKey.Key_op_user_id, OpUserId },
                { ConstKey.Key_device_info, DeviceInfo },
                { ConstKey.Key_version, Version },
                { ConstKey.Key_type, Type }
            };
            return parameters;
        }

        #endregion
    }
}
