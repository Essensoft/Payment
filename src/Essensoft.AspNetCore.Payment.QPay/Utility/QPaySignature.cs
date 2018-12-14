﻿using System.Collections.Generic;
using System.Text;
using Essensoft.AspNetCore.Payment.Security;

namespace Essensoft.AspNetCore.Payment.QPay.Utility
{
    /// <summary>
    /// QPay 签名类。
    /// </summary>
    public class QPaySignature
    {
        public static string SignWithKey(SortedDictionary<string, string> dictionary, string key, bool excludeSignType = true)
        {
            var content = new StringBuilder();
            foreach (var iter in dictionary)
            {
                if (!string.IsNullOrEmpty(iter.Value) && iter.Key != "sign" && (excludeSignType ? iter.Key != "sign_type" : true))
                {
                    content.Append(iter.Key).Append('=').Append(iter.Value).Append("&");
                }
            }
            var signContent = content.Append("key=").Append(key).ToString();
            return MD5.Compute(signContent).ToUpper();
        }
    }
}
