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

namespace BungieNet.Destiny.Responses
{
	public partial class DestinyItemChangeResponse
	{
		[JsonProperty("item")]
		public Destiny.Responses.DestinyItemResponse Item { get; set; }

		[JsonProperty("addedInventoryItems")]
		public Destiny.Entities.Items.DestinyItemComponent[] AddedInventoryItems { get; set; }

		[JsonProperty("removedInventoryItems")]
		public Destiny.Entities.Items.DestinyItemComponent[] RemovedInventoryItems { get; set; }
	}
}