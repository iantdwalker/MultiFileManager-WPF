using System;

using NUnit.Framework;

using MultiFileManager.Common.Events;

namespace MultiFileManager.Common.Tests.Events
{
	/// <summary>
	/// Tests the functionality	of the ReportProgressEventArgs class.
	/// </summary>
	[TestFixture]
	public class TestReportProgressEventArgs
	{
		#region Construction Tests
		
		/// <summary>
		/// Tests the constructor throws an exception
		/// with a negative progress parameter.
		/// </summary>
		[Test]
		public void Constructor_ShouldThrowWithNegativeProgress()
		{
			// Test / Analysis
			Assert.Throws<ArgumentException>(delegate
			{
				var reportProgressEventArgs = new ReportProgressEventArgs(-1);
			});
		}
		
		/// <summary>
		/// Tests the constructor with a 0 progress parameter.
		/// </summary>
		[Test]
		public void Constructor_ShouldReportZeroProgress()
		{
			// Setup / Test
			var reportProgressEventArgs = new ReportProgressEventArgs(0);

			// Analysis
			Assert.IsNotNull(reportProgressEventArgs);
			Assert.AreEqual(0, reportProgressEventArgs.Progress);
		}
		
		/// <summary>
		/// Tests the constructor with a positive progress parameter.
		/// </summary>
		[Test]
		public void Constructor_ShouldReportPositiveProgress()
		{
			// Setup / Test
			var reportProgressEventArgs = new ReportProgressEventArgs(10);

			// Analysis
			Assert.IsNotNull(reportProgressEventArgs);
			Assert.AreEqual(10, reportProgressEventArgs.Progress);
		}
		
		#endregion
		
		#region IReportProgressEventArgs Tests
		
		/// <summary>
		/// Tests the Progress property can get/set as expected.
		/// </summary>
		[Test]
		public void Progress_ShouldGetAndSetProgress()
		{
			// Setup
			var reportProgressEventArgs = new ReportProgressEventArgs(75);

			// Test
			Assert.AreEqual(75, reportProgressEventArgs.Progress);
			reportProgressEventArgs.Progress = 100;

			// Analysis
			Assert.AreEqual(100, reportProgressEventArgs.Progress);
		}
		
		#endregion	
	}
}
