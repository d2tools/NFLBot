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

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// If the activity is a playlist, this is the definition for a specific entry in the playlist: a single possible combination of Activity and Activity Mode that can be chosen.
	/// </summary>
	public partial class DestinyActivityPlaylistItemDefinition
	{
		[JsonProperty("activityHash")]
		public uint ActivityHash { get; set; }

		[JsonProperty("directActivityModeHash")]
		public uint? DirectActivityModeHash { get; set; }

		[JsonProperty("directActivityModeType")]
		public Destiny.HistoricalStats.Definitions.DestinyActivityModeType? DirectActivityModeType { get; set; }

		[JsonProperty("activityModeHashes")]
		public uint[] ActivityModeHashes { get; set; }

		[JsonProperty("activityModeTypes")]
		public Destiny.HistoricalStats.Definitions.DestinyActivityModeType[] ActivityModeTypes { get; set; }
	}
}