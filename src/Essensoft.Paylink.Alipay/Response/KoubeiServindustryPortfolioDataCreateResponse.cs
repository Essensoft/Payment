﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioDataCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品集ID
        /// </summary>
        [JsonPropertyName("portfolio_id")]
        public string PortfolioId { get; set; }
    }
}
