﻿using System;
using Elastic.Stack.ArtifactsApi;
using Tests.Configuration;

namespace Tests.Domain.Helpers
{
	public static class TestValueHelper
	{
		public const string ProjectsIndex = "project";

		public static DateTime FixedDate { get; } = new DateTime(2015, 06, 06, 12, 01, 02, 123);

		public static string PercolatorType => InRange("<5.0.0-alpha1") ? ".percolator" : "query";

		// internal because other projects should offload to TestConfiguration.Instance.InRange instead
		internal static bool InRange(string range) => ElasticVersion.From(TestConfiguration.Instance.ElasticsearchVersion).InRange(range);

		public static object Dependant(object builtin, object source) => TestConfiguration.Instance.Random.SourceSerializer ? source : builtin;
	}
}
