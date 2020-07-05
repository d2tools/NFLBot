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

namespace BungieNet.User
{
	/// <summary>
	/// Very basic info about a user as returned by the Account server, but including CrossSave information. Do NOT use as a request contract.
	/// </summary>
	public partial class CrossSaveUserMembership
	{
		[JsonProperty("crossSaveOverride")]
		public BungieMembershipType CrossSaveOverride { get; set; }

		[JsonProperty("applicableMembershipTypes")]
		public BungieMembershipType[] ApplicableMembershipTypes { get; set; }

		[JsonProperty("isPublic")]
		public bool IsPublic { get; set; }

		[JsonProperty("membershipType")]
		public BungieMembershipType MembershipType { get; set; }

		[JsonProperty("membershipId")]
		public long MembershipId { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }
	}
}