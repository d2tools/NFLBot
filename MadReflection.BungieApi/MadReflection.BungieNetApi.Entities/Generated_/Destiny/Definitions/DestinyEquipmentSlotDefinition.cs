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
	/// Characters can not only have Inventory buckets (containers of items that are generally matched by their type or functionality), they can also have Equipment Slots.
	/// The Equipment Slot is an indicator that the related bucket can have instanced items equipped on the character. For instance, the Primary Weapon bucket has an Equipment Slot that determines whether you can equip primary weapons, and holds the association between its slot and the inventory bucket from which it can have items equipped.
	/// An Equipment Slot must have a related Inventory Bucket, but not all inventory buckets must have Equipment Slots.
	/// </summary>
	public partial class DestinyEquipmentSlotDefinition : Destiny.Definitions.DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		[JsonProperty("equipmentCategoryHash")]
		public uint EquipmentCategoryHash { get; set; }

		[JsonProperty("bucketTypeHash")]
		public uint BucketTypeHash { get; set; }

		[JsonProperty("applyCustomArtDyes")]
		public bool ApplyCustomArtDyes { get; set; }

		[JsonProperty("artDyeChannels")]
		public Destiny.Definitions.DestinyArtDyeReference[] ArtDyeChannels { get; set; }
	}
}