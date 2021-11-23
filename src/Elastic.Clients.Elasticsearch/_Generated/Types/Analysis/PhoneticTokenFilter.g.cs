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
	public partial class PhoneticTokenFilter : Analysis.TokenFilterBase, ITokenFilterDefinitionsVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "phonetic";
		[JsonInclude]
		[JsonPropertyName("encoder")]
		public Elastic.Clients.Elasticsearch.Analysis.PhoneticEncoder Encoder { get; init; }

		[JsonInclude]
		[JsonPropertyName("languageset")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Analysis.PhoneticLanguage> Languageset { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_code_len")]
		public int? MaxCodeLen { get; init; }

		[JsonInclude]
		[JsonPropertyName("name_type")]
		public Elastic.Clients.Elasticsearch.Analysis.PhoneticNameType NameType { get; init; }

		[JsonInclude]
		[JsonPropertyName("replace")]
		public bool? Replace { get; init; }

		[JsonInclude]
		[JsonPropertyName("rule_type")]
		public Elastic.Clients.Elasticsearch.Analysis.PhoneticRuleType RuleType { get; init; }
	}
}