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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Sql
{
	public partial class ClearCursorResponse : ResponseBase
	{
		[JsonPropertyName("succeeded")]
		public bool Succeeded
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class QueryResponse : ResponseBase
	{
		[JsonPropertyName("columns")]
		public IReadOnlyCollection<Nest.Sql.Query.Column>? Columns
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cursor")]
		public string? Cursor
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("rows")]
		public IReadOnlyCollection<Nest.Sql.Query.Row> Rows
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TranslateResponse : ResponseBase
	{
		[JsonPropertyName("fields")]
		public IReadOnlyCollection<Dictionary<Nest.Field, string>> Fields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("size")]
		public long Size
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sort")]
		public Nest.Global.Search.Sort Sort
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_source")]
		public OneOf<bool, Fields, Global.Search.SourceFilter> Source
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}