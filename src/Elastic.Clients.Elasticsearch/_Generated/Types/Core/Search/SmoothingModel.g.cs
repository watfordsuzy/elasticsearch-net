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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Core.Search;
[JsonConverter(typeof(SmoothingModelConverter))]
public sealed partial class SmoothingModel
{
	internal SmoothingModel(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }

	internal string VariantName { get; }

	public static SmoothingModel Laplace(Elastic.Clients.Elasticsearch.Core.Search.LaplaceSmoothingModel laplaceSmoothingModel) => new SmoothingModel("laplace", laplaceSmoothingModel);
	public static SmoothingModel LinearInterpolation(Elastic.Clients.Elasticsearch.Core.Search.LinearInterpolationSmoothingModel linearInterpolationSmoothingModel) => new SmoothingModel("linear_interpolation", linearInterpolationSmoothingModel);
	public static SmoothingModel StupidBackoff(Elastic.Clients.Elasticsearch.Core.Search.StupidBackoffSmoothingModel stupidBackoffSmoothingModel) => new SmoothingModel("stupid_backoff", stupidBackoffSmoothingModel);
}

internal sealed partial class SmoothingModelConverter : JsonConverter<SmoothingModel>
{
	public override SmoothingModel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		reader.Read();
		if (reader.TokenType != JsonTokenType.PropertyName)
		{
			throw new JsonException("Expected a property name token representing the variant held within this container.");
		}

		var propertyName = reader.GetString();
		reader.Read();
		if (propertyName == "laplace")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.LaplaceSmoothingModel?>(ref reader, options);
			reader.Read();
			return new SmoothingModel(propertyName, variant);
		}

		if (propertyName == "linear_interpolation")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.LinearInterpolationSmoothingModel?>(ref reader, options);
			reader.Read();
			return new SmoothingModel(propertyName, variant);
		}

		if (propertyName == "stupid_backoff")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.StupidBackoffSmoothingModel?>(ref reader, options);
			reader.Read();
			return new SmoothingModel(propertyName, variant);
		}

		throw new JsonException();
	}

	public override void Write(Utf8JsonWriter writer, SmoothingModel value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName(value.VariantName);
		switch (value.VariantName)
		{
			case "laplace":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.LaplaceSmoothingModel>(writer, (Elastic.Clients.Elasticsearch.Core.Search.LaplaceSmoothingModel)value.Variant, options);
				break;
			case "linear_interpolation":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.LinearInterpolationSmoothingModel>(writer, (Elastic.Clients.Elasticsearch.Core.Search.LinearInterpolationSmoothingModel)value.Variant, options);
				break;
			case "stupid_backoff":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.StupidBackoffSmoothingModel>(writer, (Elastic.Clients.Elasticsearch.Core.Search.StupidBackoffSmoothingModel)value.Variant, options);
				break;
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SmoothingModelDescriptor<TDocument> : SerializableDescriptor<SmoothingModelDescriptor<TDocument>>
{
	internal SmoothingModelDescriptor(Action<SmoothingModelDescriptor<TDocument>> configure) => configure.Invoke(this);
	public SmoothingModelDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private SmoothingModelDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private SmoothingModelDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public SmoothingModelDescriptor<TDocument> Laplace(LaplaceSmoothingModel laplaceSmoothingModel) => Set(laplaceSmoothingModel, "laplace");
	public SmoothingModelDescriptor<TDocument> Laplace(Action<LaplaceSmoothingModelDescriptor> configure) => Set(configure, "laplace");
	public SmoothingModelDescriptor<TDocument> LinearInterpolation(LinearInterpolationSmoothingModel linearInterpolationSmoothingModel) => Set(linearInterpolationSmoothingModel, "linear_interpolation");
	public SmoothingModelDescriptor<TDocument> LinearInterpolation(Action<LinearInterpolationSmoothingModelDescriptor> configure) => Set(configure, "linear_interpolation");
	public SmoothingModelDescriptor<TDocument> StupidBackoff(StupidBackoffSmoothingModel stupidBackoffSmoothingModel) => Set(stupidBackoffSmoothingModel, "stupid_backoff");
	public SmoothingModelDescriptor<TDocument> StupidBackoff(Action<StupidBackoffSmoothingModelDescriptor> configure) => Set(configure, "stupid_backoff");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}

public sealed partial class SmoothingModelDescriptor : SerializableDescriptor<SmoothingModelDescriptor>
{
	internal SmoothingModelDescriptor(Action<SmoothingModelDescriptor> configure) => configure.Invoke(this);
	public SmoothingModelDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private SmoothingModelDescriptor Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private SmoothingModelDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public SmoothingModelDescriptor Laplace(LaplaceSmoothingModel laplaceSmoothingModel) => Set(laplaceSmoothingModel, "laplace");
	public SmoothingModelDescriptor Laplace(Action<LaplaceSmoothingModelDescriptor> configure) => Set(configure, "laplace");
	public SmoothingModelDescriptor LinearInterpolation(LinearInterpolationSmoothingModel linearInterpolationSmoothingModel) => Set(linearInterpolationSmoothingModel, "linear_interpolation");
	public SmoothingModelDescriptor LinearInterpolation(Action<LinearInterpolationSmoothingModelDescriptor> configure) => Set(configure, "linear_interpolation");
	public SmoothingModelDescriptor StupidBackoff(StupidBackoffSmoothingModel stupidBackoffSmoothingModel) => Set(stupidBackoffSmoothingModel, "stupid_backoff");
	public SmoothingModelDescriptor StupidBackoff(Action<StupidBackoffSmoothingModelDescriptor> configure) => Set(configure, "stupid_backoff");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}