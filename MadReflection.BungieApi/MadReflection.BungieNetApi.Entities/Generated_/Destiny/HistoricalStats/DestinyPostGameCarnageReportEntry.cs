﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.HistoricalStats
{
	public partial class DestinyPostGameCarnageReportEntry
	{
		[JsonProperty("standing")]
		public int Standing { get; set; }

		[JsonProperty("score")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsValue Score { get; set; }

		[JsonProperty("player")]
		public Destiny.HistoricalStats.DestinyPlayer Player { get; set; }

		[JsonProperty("characterId")]
		public long CharacterId { get; set; }

		[JsonProperty("values")]
		public System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsValue> Values { get; set; }

		[JsonProperty("extended")]
		public Destiny.HistoricalStats.DestinyPostGameCarnageReportExtendedData Extended { get; set; }
	}
}