﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceLinkamtBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceLinkamtBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// Ar对账单发票关联明细集合
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ArInvoiceBillLinkOpenApiResponse> ResultSet { get; set; }
    }
}
