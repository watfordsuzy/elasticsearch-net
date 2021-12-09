// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial class ShardProfile
	{
		[JsonInclude]
		[JsonPropertyName("aggregations")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.AggregationProfile> Aggregations { get; init; }

		[JsonInclude]
		[JsonPropertyName("id")]
		public string Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("searches")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.SearchProfile> Searches { get; init; }

		[JsonInclude]
		[JsonPropertyName("fetch")]
		public Elastic.Clients.Elasticsearch.FetchProfile? Fetch { get; init; }
	}
}