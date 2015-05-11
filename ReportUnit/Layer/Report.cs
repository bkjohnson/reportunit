﻿namespace ReportUnit.Layer
{
	using System.Collections.Generic;

	/// <summary>
	/// Data for a file generated by a test runner (TextResult.xml)
	/// </summary>
	internal class Report
	{
		public Report()
		{
			RunInfo = new RunInfo();
			TestFixtures = new List<TestSuite>();
		}

		/// <summary>
		/// File name generated that this data is for
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// Name of the assembly that the tests are for
		/// </summary>
		public string AssemblyName { get; set; }

		/// <summary>
		/// Overall result of the test run (eg Passed, Failed)
		/// </summary>
		public Status Status { get; set; }

		/// <summary>
		/// How long the test suite took to run (in milliseconds)
		/// </summary>
		public double Duration { get; set; }

		/// <summary>
		/// Total number of tests run
		/// </summary>
		public int Total { get; set; }

		public int Passed { get; set; }

		public int Failed { get; set; }

		public int Inconclusive { get; set; }

		public int Skipped { get; set; }

		public int Errors { get; set; }

		public RunInfo RunInfo { get; private set; }

		public List<TestSuite> TestFixtures { get; private set; }
	}
}
