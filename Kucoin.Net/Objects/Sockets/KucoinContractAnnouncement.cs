﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kucoin.Net.Objects.Sockets
{
    /// <summary>
    /// Contract announcement
    /// </summary>
    public class KucoinContractAnnouncement
    {
        /// <summary>
        /// Event type
        /// </summary>
        public string Event { get; set; } = string.Empty;
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Funding rate
        /// </summary>
        public decimal FundingRate { get; set; }
        /// <summary>
        /// Funding time
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime FundingTime { get; set; }
        /// <summary>
        /// Event time
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime Timestamp { get; set; }
    }
}
