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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class DateHistogramAggregation : Aggregations.BucketAggregationBase, IAggregationContainerVariant, TransformManagement.IPivotGroupByContainerVariant
	{
		public DateHistogramAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "date_histogram";
		[JsonIgnore]
		string TransformManagement.IPivotGroupByContainerVariant.PivotGroupByContainerVariantName => "date_histogram";
		[JsonInclude]
		[JsonPropertyName("calendar_interval")]
		public Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public string? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("fixed_interval")]
		public Elastic.Clients.Elasticsearch.Time? FixedInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("interval")]
		public Elastic.Clients.Elasticsearch.Time? Interval { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_doc_count")]
		public int? MinDocCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public string? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("offset")]
		public Elastic.Clients.Elasticsearch.Time? Offset { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_zone")]
		public string? TimeZone { get; set; }

		[JsonInclude]
		[JsonPropertyName("keyed")]
		public bool? Keyed { get; set; }
	}

	public sealed partial class DateHistogramAggregationDescriptor<T> : DescriptorBase<DateHistogramAggregationDescriptor<T>>
	{
		public DateHistogramAggregationDescriptor()
		{
		}

		internal DateHistogramAggregationDescriptor(Action<DateHistogramAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarIntervalValue { get; private set; }

		internal string? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Time? FixedIntervalValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Time? IntervalValue { get; private set; }

		internal int? MinDocCountValue { get; private set; }

		internal string? MissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Time? OffsetValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? OrderValue { get; private set; }

		internal Dictionary<string, object>? ParamsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal string? TimeZoneValue { get; private set; }

		internal bool? KeyedValue { get; private set; }

		internal HistogramOrderDescriptor OrderDescriptor { get; private set; }

		internal Action<HistogramOrderDescriptor> OrderDescriptorAction { get; private set; }

		public DateHistogramAggregationDescriptor<T> CalendarInterval(Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? calendarInterval) => Assign(calendarInterval, (a, v) => a.CalendarIntervalValue = v);
		public DateHistogramAggregationDescriptor<T> Field(string? field) => Assign(field, (a, v) => a.FieldValue = v);
		public DateHistogramAggregationDescriptor<T> FixedInterval(Elastic.Clients.Elasticsearch.Time? fixedInterval) => Assign(fixedInterval, (a, v) => a.FixedIntervalValue = v);
		public DateHistogramAggregationDescriptor<T> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public DateHistogramAggregationDescriptor<T> Interval(Elastic.Clients.Elasticsearch.Time? interval) => Assign(interval, (a, v) => a.IntervalValue = v);
		public DateHistogramAggregationDescriptor<T> MinDocCount(int? minDocCount) => Assign(minDocCount, (a, v) => a.MinDocCountValue = v);
		public DateHistogramAggregationDescriptor<T> Missing(string? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public DateHistogramAggregationDescriptor<T> Offset(Elastic.Clients.Elasticsearch.Time? offset) => Assign(offset, (a, v) => a.OffsetValue = v);
		public DateHistogramAggregationDescriptor<T> Order(Elastic.Clients.Elasticsearch.Aggregations.HistogramOrder? order)
		{
			OrderDescriptor = null;
			OrderDescriptorAction = null;
			return Assign(order, (a, v) => a.OrderValue = v);
		}

		public DateHistogramAggregationDescriptor<T> Order(Elastic.Clients.Elasticsearch.Aggregations.HistogramOrderDescriptor descriptor)
		{
			OrderValue = null;
			OrderDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.OrderDescriptor = v);
		}

		public DateHistogramAggregationDescriptor<T> Order(Action<Elastic.Clients.Elasticsearch.Aggregations.HistogramOrderDescriptor> configure)
		{
			OrderValue = null;
			OrderDescriptorAction = null;
			return Assign(configure, (a, v) => a.OrderDescriptorAction = v);
		}

		public DateHistogramAggregationDescriptor<T> Params(Func<FluentDictionary<string?, object?>, FluentDictionary<string?, object?>> selector) => Assign(selector, (a, v) => a.ParamsValue = v?.Invoke(new FluentDictionary<string?, object?>()));
		public DateHistogramAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public DateHistogramAggregationDescriptor<T> TimeZone(string? timeZone) => Assign(timeZone, (a, v) => a.TimeZoneValue = v);
		public DateHistogramAggregationDescriptor<T> Keyed(bool? keyed = true) => Assign(keyed, (a, v) => a.KeyedValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CalendarIntervalValue is not null)
			{
				writer.WritePropertyName("calendar_interval");
				JsonSerializer.Serialize(writer, CalendarIntervalValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (FixedIntervalValue is not null)
			{
				writer.WritePropertyName("fixed_interval");
				JsonSerializer.Serialize(writer, FixedIntervalValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (IntervalValue is not null)
			{
				writer.WritePropertyName("interval");
				JsonSerializer.Serialize(writer, IntervalValue, options);
			}

			if (MinDocCountValue.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(MinDocCountValue.Value);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (OffsetValue is not null)
			{
				writer.WritePropertyName("offset");
				JsonSerializer.Serialize(writer, OffsetValue, options);
			}

			if (OrderDescriptor is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderDescriptor, options);
			}
			else if (OrderDescriptorAction is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, new HistogramOrderDescriptor(OrderDescriptorAction), options);
			}
			else if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (!string.IsNullOrEmpty(TimeZoneValue))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(TimeZoneValue);
			}

			if (KeyedValue.HasValue)
			{
				writer.WritePropertyName("keyed");
				writer.WriteBooleanValue(KeyedValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}