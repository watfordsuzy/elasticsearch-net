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
namespace Nest.Migration
{
	public class MigrationNamespace : NamespacedClientProxy
	{
		internal MigrationNamespace(ElasticClient client) : base(client)
		{
		}

		public DeprecationsResponse Deprecations(IDeprecationsRequest request)
		{
			return DoRequest<IDeprecationsRequest, DeprecationsResponse>(request, request.RequestParameters);
		}

		public Task<DeprecationsResponse> DeprecationsAsync(IDeprecationsRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeprecationsRequest, DeprecationsResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeprecationsResponse Deprecations(Func<DeprecationsDescriptor, IDeprecationsRequest> selector = null)
		{
			return Deprecations(selector.InvokeOrDefault(new DeprecationsDescriptor()));
		}

		public Task<DeprecationsResponse> DeprecationsAsync(Func<DeprecationsDescriptor, IDeprecationsRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return DeprecationsAsync(selector.InvokeOrDefault(new DeprecationsDescriptor()), cancellationToken);
		}
	}
}