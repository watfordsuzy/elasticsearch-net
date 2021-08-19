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

#nullable restore
namespace Nest.SearchableSnapshots
{
	public partial class ClearCacheDescriptor : RequestDescriptorBase<ClearCacheDescriptor, ClearCacheRequestParameters, IClearCacheRequest>, IClearCacheRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SearchableSnapshotsClearCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_searchable_snapshots/cache/clear</summary>
        public ClearCacheDescriptor() : base()
		{
		}

		///<summary>/{index}/_searchable_snapshots/cache/clear</summary>
        public ClearCacheDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class MountDescriptor : RequestDescriptorBase<MountDescriptor, MountRequestParameters, IMountRequest>, IMountRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SearchableSnapshotsMount;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_snapshot/{repository}/{snapshot}/_mount</summary>
        public MountDescriptor(Nest.Name repository, Nest.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}
	}
}