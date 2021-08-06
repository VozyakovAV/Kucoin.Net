﻿using CryptoExchange.Net.Converters;
using Kucoin.Net.Enums;
using Kucoin.Net.Objects;
using System.Collections.Generic;

namespace Kucoin.Net.Converts
{
    internal class FuturesOrderStatusConverter : BaseConverter<FuturesOrderStatus>
    {
        public FuturesOrderStatusConverter() : this(true) { }
        public FuturesOrderStatusConverter(bool quotes) : base(quotes) { }
        protected override List<KeyValuePair<FuturesOrderStatus, string>> Mapping => new List<KeyValuePair<FuturesOrderStatus, string>>
        {
            new KeyValuePair<FuturesOrderStatus, string>(FuturesOrderStatus.Match, "match"),
            new KeyValuePair<FuturesOrderStatus, string>(FuturesOrderStatus.Open, "open"),
            new KeyValuePair<FuturesOrderStatus, string>(FuturesOrderStatus.Done, "done"),
        };
    }
}
