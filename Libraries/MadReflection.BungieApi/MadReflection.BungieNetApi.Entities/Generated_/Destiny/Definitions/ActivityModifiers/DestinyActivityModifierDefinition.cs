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

namespace BungieNet.Destiny.Definitions.ActivityModifiers
{
	/// <summary>
	/// Modifiers - in Destiny 1, these were referred to as "Skulls" - are changes that can be applied to an Activity.
	/// </summary>
	public partial class DestinyActivityModifierDefinition : Destiny.Definitions.DestinyDefinition
	{
		[JsonProperty("displayProperties")]
		public Destiny.Definitions.Common.DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
	}
}