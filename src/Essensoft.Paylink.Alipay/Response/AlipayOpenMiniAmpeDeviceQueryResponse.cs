﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDeviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 设备列表
        /// </summary>
        [JsonPropertyName("device_list")]
        public List<AmpeDeviceVO> DeviceList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
