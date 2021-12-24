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
	public partial class SoftDeletes
	{
		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }

		[JsonInclude]
		[JsonPropertyName("retention_lease.period")]
		public Elastic.Clients.Elasticsearch.Time? RetentionLeasePeriod { get; set; }
	}

	public sealed partial class SoftDeletesDescriptor : DescriptorBase<SoftDeletesDescriptor>
	{
		public SoftDeletesDescriptor()
		{
		}

		internal SoftDeletesDescriptor(Action<SoftDeletesDescriptor> configure) => configure.Invoke(this);
		internal bool EnabledValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Time? RetentionLeasePeriodValue { get; private set; }

		public SoftDeletesDescriptor Enabled(bool enabled = true) => Assign(enabled, (a, v) => a.EnabledValue = v);
		public SoftDeletesDescriptor RetentionLeasePeriod(Elastic.Clients.Elasticsearch.Time? retentionLeasePeriod) => Assign(retentionLeasePeriod, (a, v) => a.RetentionLeasePeriodValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue);
			if (RetentionLeasePeriodValue is not null)
			{
				writer.WritePropertyName("retention_lease.period");
				JsonSerializer.Serialize(writer, RetentionLeasePeriodValue, options);
			}

			writer.WriteEndObject();
		}
	}
}