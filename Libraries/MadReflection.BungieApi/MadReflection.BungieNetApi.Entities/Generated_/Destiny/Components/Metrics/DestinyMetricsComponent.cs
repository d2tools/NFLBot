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

namespace BungieNet.Destiny.Components.Metrics
{
	public partial class DestinyMetricsComponent
	{
		[JsonProperty("metrics")]
		public System.Collections.Generic.Dictionary<uint, Destiny.Components.Metrics.DestinyMetricComponent> Metrics { get; set; }

		[JsonProperty("metricsRootNodeHash")]
		public uint MetricsRootNodeHash { get; set; }
	}
}