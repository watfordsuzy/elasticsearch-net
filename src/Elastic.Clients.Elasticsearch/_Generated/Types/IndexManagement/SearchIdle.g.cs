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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class SearchIdle
	{
		[JsonInclude]
		[JsonPropertyName("after")]
		public Elastic.Clients.Elasticsearch.Time? After { get; set; }
	}

	public sealed partial class SearchIdleDescriptor : DescriptorBase<SearchIdleDescriptor>
	{
		public SearchIdleDescriptor()
		{
		}

		internal SearchIdleDescriptor(Action<SearchIdleDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Time? AfterValue { get; private set; }

		public SearchIdleDescriptor After(Elastic.Clients.Elasticsearch.Time? after) => Assign(after, (a, v) => a.AfterValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AfterValue is not null)
			{
				writer.WritePropertyName("after");
				JsonSerializer.Serialize(writer, AfterValue, options);
			}

			writer.WriteEndObject();
		}
	}
}