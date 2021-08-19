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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.TransformManagement
{
	public class TransformManagementNamespace : NamespacedClientProxy
	{
		internal TransformManagementNamespace(ElasticClient client) : base(client)
		{
		}

		public DeleteTransformResponse DeleteTransform(IDeleteTransformRequest request)
		{
			return DoRequest<IDeleteTransformRequest, DeleteTransformResponse>(request, request.RequestParameters);
		}

		public Task<DeleteTransformResponse> DeleteTransformAsync(IDeleteTransformRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteTransformRequest, DeleteTransformResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeleteTransformResponse DeleteTransform(Nest.Name transform_id, Func<DeleteTransformDescriptor, IDeleteTransformRequest> selector = null)
		{
			return DeleteTransform(selector.InvokeOrDefault(new DeleteTransformDescriptor(transform_id)));
		}

		public Task<DeleteTransformResponse> DeleteTransformAsync(Nest.Name transform_id, Func<DeleteTransformDescriptor, IDeleteTransformRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return DeleteTransformAsync(selector.InvokeOrDefault(new DeleteTransformDescriptor(transform_id)), cancellationToken);
		}

		public GetTransformResponse GetTransform(IGetTransformRequest request)
		{
			return DoRequest<IGetTransformRequest, GetTransformResponse>(request, request.RequestParameters);
		}

		public Task<GetTransformResponse> GetTransformAsync(IGetTransformRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetTransformRequest, GetTransformResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetTransformResponse GetTransform(Func<GetTransformDescriptor, IGetTransformRequest> selector = null)
		{
			return GetTransform(selector.InvokeOrDefault(new GetTransformDescriptor()));
		}

		public Task<GetTransformResponse> GetTransformAsync(Func<GetTransformDescriptor, IGetTransformRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return GetTransformAsync(selector.InvokeOrDefault(new GetTransformDescriptor()), cancellationToken);
		}

		public GetTransformStatsResponse GetTransformStats(IGetTransformStatsRequest request)
		{
			return DoRequest<IGetTransformStatsRequest, GetTransformStatsResponse>(request, request.RequestParameters);
		}

		public Task<GetTransformStatsResponse> GetTransformStatsAsync(IGetTransformStatsRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetTransformStatsRequest, GetTransformStatsResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetTransformStatsResponse GetTransformStats(Nest.Name transform_id, Func<GetTransformStatsDescriptor, IGetTransformStatsRequest> selector = null)
		{
			return GetTransformStats(selector.InvokeOrDefault(new GetTransformStatsDescriptor(transform_id)));
		}

		public Task<GetTransformStatsResponse> GetTransformStatsAsync(Nest.Name transform_id, Func<GetTransformStatsDescriptor, IGetTransformStatsRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return GetTransformStatsAsync(selector.InvokeOrDefault(new GetTransformStatsDescriptor(transform_id)), cancellationToken);
		}

		public PreviewTransformResponse<TTransform> PreviewTransform<TTransform>(IPreviewTransformRequest request)
		{
			return DoRequest<IPreviewTransformRequest, PreviewTransformResponse<TTransform>>(request, request.RequestParameters);
		}

		public Task<PreviewTransformResponse<TTransform>> PreviewTransformAsync<TTransform>(IPreviewTransformRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPreviewTransformRequest, PreviewTransformResponse<TTransform>>(request, request.RequestParameters, cancellationToken);
		}

		public PreviewTransformResponse<TTransform> PreviewTransform<TTransform>(Func<PreviewTransformDescriptor, IPreviewTransformRequest> selector = null)
		{
			return PreviewTransform<TTransform>(selector.InvokeOrDefault(new PreviewTransformDescriptor()));
		}

		public Task<PreviewTransformResponse<TTransform>> PreviewTransformAsync<TTransform>(Func<PreviewTransformDescriptor, IPreviewTransformRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return PreviewTransformAsync<TTransform>(selector.InvokeOrDefault(new PreviewTransformDescriptor()), cancellationToken);
		}

		public PutTransformResponse PutTransform(IPutTransformRequest request)
		{
			return DoRequest<IPutTransformRequest, PutTransformResponse>(request, request.RequestParameters);
		}

		public Task<PutTransformResponse> PutTransformAsync(IPutTransformRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPutTransformRequest, PutTransformResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PutTransformResponse PutTransform(Nest.Id transform_id, Func<PutTransformDescriptor, IPutTransformRequest> selector = null)
		{
			return PutTransform(selector.InvokeOrDefault(new PutTransformDescriptor(transform_id)));
		}

		public Task<PutTransformResponse> PutTransformAsync(Nest.Id transform_id, Func<PutTransformDescriptor, IPutTransformRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return PutTransformAsync(selector.InvokeOrDefault(new PutTransformDescriptor(transform_id)), cancellationToken);
		}

		public StartTransformResponse StartTransform(IStartTransformRequest request)
		{
			return DoRequest<IStartTransformRequest, StartTransformResponse>(request, request.RequestParameters);
		}

		public Task<StartTransformResponse> StartTransformAsync(IStartTransformRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IStartTransformRequest, StartTransformResponse>(request, request.RequestParameters, cancellationToken);
		}

		public StartTransformResponse StartTransform(Nest.Name transform_id, Func<StartTransformDescriptor, IStartTransformRequest> selector = null)
		{
			return StartTransform(selector.InvokeOrDefault(new StartTransformDescriptor(transform_id)));
		}

		public Task<StartTransformResponse> StartTransformAsync(Nest.Name transform_id, Func<StartTransformDescriptor, IStartTransformRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return StartTransformAsync(selector.InvokeOrDefault(new StartTransformDescriptor(transform_id)), cancellationToken);
		}

		public StopTransformResponse StopTransform(IStopTransformRequest request)
		{
			return DoRequest<IStopTransformRequest, StopTransformResponse>(request, request.RequestParameters);
		}

		public Task<StopTransformResponse> StopTransformAsync(IStopTransformRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IStopTransformRequest, StopTransformResponse>(request, request.RequestParameters, cancellationToken);
		}

		public StopTransformResponse StopTransform(Nest.Name transform_id, Func<StopTransformDescriptor, IStopTransformRequest> selector = null)
		{
			return StopTransform(selector.InvokeOrDefault(new StopTransformDescriptor(transform_id)));
		}

		public Task<StopTransformResponse> StopTransformAsync(Nest.Name transform_id, Func<StopTransformDescriptor, IStopTransformRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return StopTransformAsync(selector.InvokeOrDefault(new StopTransformDescriptor(transform_id)), cancellationToken);
		}

		public UpdateTransformResponse UpdateTransform(IUpdateTransformRequest request)
		{
			return DoRequest<IUpdateTransformRequest, UpdateTransformResponse>(request, request.RequestParameters);
		}

		public Task<UpdateTransformResponse> UpdateTransformAsync(IUpdateTransformRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IUpdateTransformRequest, UpdateTransformResponse>(request, request.RequestParameters, cancellationToken);
		}
	}
}