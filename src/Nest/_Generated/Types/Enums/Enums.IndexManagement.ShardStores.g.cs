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

using System.Runtime.Serialization;

#nullable restore
namespace Nest.IndexManagement.ShardStores
{
	public readonly partial struct ShardStoreAllocation
	{
		public ShardStoreAllocation(string value) => Value = value;
		public string Value { get; }

		public static ShardStoreAllocation Unused { get; } = new ShardStoreAllocation("unused");
		public static ShardStoreAllocation Replica { get; } = new ShardStoreAllocation("replica");
		public static ShardStoreAllocation Primary { get; } = new ShardStoreAllocation("primary");
	}
}