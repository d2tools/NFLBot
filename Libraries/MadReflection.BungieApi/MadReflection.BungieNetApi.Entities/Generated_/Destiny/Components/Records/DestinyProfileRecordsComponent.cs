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

namespace BungieNet.Destiny.Components.Records
{
	public partial class DestinyProfileRecordsComponent
	{
		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("trackedRecordHash")]
		public uint? TrackedRecordHash { get; set; }

		[JsonProperty("records")]
		public System.Collections.Generic.Dictionary<uint, Destiny.Components.Records.DestinyRecordComponent> Records { get; set; }
	}
}