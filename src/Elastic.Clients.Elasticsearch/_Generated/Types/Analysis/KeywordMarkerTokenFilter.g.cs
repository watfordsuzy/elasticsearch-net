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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class KeywordMarkerTokenFilter : Analysis.TokenFilterBase, ITokenFilterDefinitionsVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "keyword_marker";
		[JsonInclude]
		[JsonPropertyName("ignore_case")]
		public bool? IgnoreCase { get; init; }

		[JsonInclude]
		[JsonPropertyName("keywords")]
		public IReadOnlyCollection<string>? Keywords { get; init; }

		[JsonInclude]
		[JsonPropertyName("keywords_path")]
		public string? KeywordsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("keywords_pattern")]
		public string? KeywordsPattern { get; init; }
	}
}