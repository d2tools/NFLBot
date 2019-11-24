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

namespace BungieNet.Destiny.Definitions.Director
{
	/// <summary>
	/// This describes links between the current graph and others, as well as when that link is relevant.
	/// </summary>
	public partial class DestinyLinkedGraphDefinition
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("unlockExpression")]
		public Destiny.Definitions.DestinyUnlockExpressionDefinition UnlockExpression { get; set; }

		[JsonProperty("linkedGraphId")]
		public uint LinkedGraphId { get; set; }

		[JsonProperty("linkedGraphs")]
		public Destiny.Definitions.Director.DestinyLinkedGraphEntryDefinition[] LinkedGraphs { get; set; }

		[JsonProperty("overview")]
		public string Overview { get; set; }
	}
}