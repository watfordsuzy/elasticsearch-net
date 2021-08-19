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
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Tasks
{
	[ConvertAs(typeof(CancelRequest))]
	public partial interface ICancelRequest : IRequest<CancelRequestParameters>
	{
	}

	public partial class CancelRequest : PlainRequestBase<CancelRequestParameters>, ICancelRequest
	{
		protected ICancelRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksCancel;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_tasks/_cancel</summary>
        public CancelRequest() : base()
		{
		}

		///<summary>/_tasks/{task_id}/_cancel</summary>
        public CancelRequest(Nest.TaskId? task_id) : base(r => r.Optional("task_id", task_id))
		{
		}

		[JsonIgnore]
		public Union<string, IEnumerable<string>>? Actions { get => Q<Union<string, IEnumerable<string>>?>("actions"); set => Q("actions", value); }

		[JsonIgnore]
		public IEnumerable<string>? Nodes { get => Q<IEnumerable<string>?>("nodes"); set => Q("nodes", value); }

		[JsonIgnore]
		public string? ParentTaskId { get => Q<string?>("parent_task_id"); set => Q("parent_task_id", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	[ConvertAs(typeof(GetRequest))]
	public partial interface IGetRequest : IRequest<GetRequestParameters>
	{
	}

	public partial class GetRequest : PlainRequestBase<GetRequestParameters>, IGetRequest
	{
		protected IGetRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_tasks/{task_id}</summary>
        public GetRequest(Nest.Id task_id) : base(r => r.Required("task_id", task_id))
		{
		}

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	[ConvertAs(typeof(ListRequest))]
	public partial interface IListRequest : IRequest<ListRequestParameters>
	{
	}

	public partial class ListRequest : PlainRequestBase<ListRequestParameters>, IListRequest
	{
		protected IListRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksList;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_tasks</summary>
        public ListRequest() : base()
		{
		}

		[JsonIgnore]
		public Union<string, IEnumerable<string>>? Actions { get => Q<Union<string, IEnumerable<string>>?>("actions"); set => Q("actions", value); }

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }

		[JsonIgnore]
		public Nest.GroupBy? GroupBy { get => Q<Nest.GroupBy?>("group_by"); set => Q("group_by", value); }

		[JsonIgnore]
		public IEnumerable<string>? Nodes { get => Q<IEnumerable<string>?>("nodes"); set => Q("nodes", value); }

		[JsonIgnore]
		public Nest.Id? ParentTaskId { get => Q<Nest.Id?>("parent_task_id"); set => Q("parent_task_id", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}
}