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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlDeleteTrainedModelRequestParameters : RequestParameters<MlDeleteTrainedModelRequestParameters>
	{
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
	}

	public partial class MlDeleteTrainedModelRequest : PlainRequestBase<MlDeleteTrainedModelRequestParameters>
	{
		public MlDeleteTrainedModelRequest(Elastic.Clients.Elasticsearch.Id model_id) : base(r => r.Required("model_id", model_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteTrainedModel;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
	}

	public sealed partial class MlDeleteTrainedModelRequestDescriptor : RequestDescriptorBase<MlDeleteTrainedModelRequestDescriptor, MlDeleteTrainedModelRequestParameters>
	{
		internal MlDeleteTrainedModelRequestDescriptor(Action<MlDeleteTrainedModelRequestDescriptor> configure) => configure.Invoke(this);
		public MlDeleteTrainedModelRequestDescriptor(Elastic.Clients.Elasticsearch.Id model_id) : base(r => r.Required("model_id", model_id))
		{
		}

		internal MlDeleteTrainedModelRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteTrainedModel;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public MlDeleteTrainedModelRequestDescriptor Force(bool? force = true) => Qs("force", force);
		public MlDeleteTrainedModelRequestDescriptor ModelId(Elastic.Clients.Elasticsearch.Id model_id)
		{
			RouteValues.Required("model_id", model_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}