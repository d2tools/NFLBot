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

namespace BungieNet.GroupsV2
{
	public partial class GroupSearchResponse
	{
		[JsonProperty("results")]
		public GroupsV2.GroupV2Card[] Results { get; set; }

		[JsonProperty("totalResults")]
		public int TotalResults { get; set; }

		[JsonProperty("hasMore")]
		public bool HasMore { get; set; }

		[JsonProperty("query")]
		public Queries.PagedQuery Query { get; set; }

		[JsonProperty("replacementContinuationToken")]
		public string ReplacementContinuationToken { get; set; }

		[JsonProperty("useTotalResults")]
		public bool UseTotalResults { get; set; }
	}
}