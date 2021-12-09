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
namespace Elastic.Clients.Elasticsearch.IndexManagement.Stats
{
	public partial class IndexStats
	{
		[JsonInclude]
		[JsonPropertyName("completion")]
		public Elastic.Clients.Elasticsearch.CompletionStats? Completion { get; init; }

		[JsonInclude]
		[JsonPropertyName("docs")]
		public Elastic.Clients.Elasticsearch.DocStats? Docs { get; init; }

		[JsonInclude]
		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.FielddataStats? Fielddata { get; init; }

		[JsonInclude]
		[JsonPropertyName("flush")]
		public Elastic.Clients.Elasticsearch.FlushStats? Flush { get; init; }

		[JsonInclude]
		[JsonPropertyName("get")]
		public Elastic.Clients.Elasticsearch.GetStats? Get { get; init; }

		[JsonInclude]
		[JsonPropertyName("indexing")]
		public Elastic.Clients.Elasticsearch.IndexingStats? Indexing { get; init; }

		[JsonInclude]
		[JsonPropertyName("merges")]
		public Elastic.Clients.Elasticsearch.MergesStats? Merges { get; init; }

		[JsonInclude]
		[JsonPropertyName("query_cache")]
		public Elastic.Clients.Elasticsearch.QueryCacheStats? QueryCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("recovery")]
		public Elastic.Clients.Elasticsearch.RecoveryStats? Recovery { get; init; }

		[JsonInclude]
		[JsonPropertyName("refresh")]
		public Elastic.Clients.Elasticsearch.RefreshStats? Refresh { get; init; }

		[JsonInclude]
		[JsonPropertyName("request_cache")]
		public Elastic.Clients.Elasticsearch.RequestCacheStats? RequestCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("search")]
		public Elastic.Clients.Elasticsearch.SearchStats? Search { get; init; }

		[JsonInclude]
		[JsonPropertyName("segments")]
		public Elastic.Clients.Elasticsearch.SegmentsStats? Segments { get; init; }

		[JsonInclude]
		[JsonPropertyName("store")]
		public Elastic.Clients.Elasticsearch.StoreStats? Store { get; init; }

		[JsonInclude]
		[JsonPropertyName("translog")]
		public Elastic.Clients.Elasticsearch.TranslogStats? Translog { get; init; }

		[JsonInclude]
		[JsonPropertyName("warmer")]
		public Elastic.Clients.Elasticsearch.WarmerStats? Warmer { get; init; }

		[JsonInclude]
		[JsonPropertyName("bulk")]
		public Elastic.Clients.Elasticsearch.BulkStats? Bulk { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardsTotalStats? Shards { get; init; }
	}
}