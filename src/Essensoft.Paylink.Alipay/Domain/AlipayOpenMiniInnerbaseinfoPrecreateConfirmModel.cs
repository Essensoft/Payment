﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoPrecreateConfirmModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoPrecreateConfirmModel : AlipayObject
    {
        /// <summary>
        /// 小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
