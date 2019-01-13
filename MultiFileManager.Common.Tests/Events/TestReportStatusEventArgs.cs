using System;

using NUnit.Framework;

using MultiFileManager.Common.Events;

namespace MultiFileManager.Common.Tests.Events
{
	/// <summary>
	/// Tests the functionality of the ReportStatusEventArgs class.
	/// </summary>
	[TestFixture]
	public class TestReportStatusEventArgs
	{
		#region Construction Tests
		
		/// <summary>
		/// Tests the constructor throws an exception
		/// with a null string status parameter.
		/// </summary>
		[Test]
		public void Constructor_ShouldThrowWithNullStatus()
		{
			// Test / Analysis
			Assert.Throws<ArgumentNullException>(delegate
			{
				var reportStatusEventArgs = new ReportStatusEventArgs(null);
			});
		}
		
		/// <summary>
		/// Tests the constructor with an empty string status parameter.
		/// </summary>
		[Test]
		public void Constructor_ShouldAcceptEmptyStatus()
		{
			// Test
			var reportStatusEventArgs = new ReportStatusEventArgs(string.Empty);

			// Analysis
			Assert.IsNotNull(reportStatusEventArgs);
			Assert.AreEqual(string.Empty, reportStatusEventArgs.Status);
		}
		
		/// <summary>
		/// Tests the constructor with a string status parameter.
		/// </summary>
		[Test]
		public void Constructor_ShouldSetStatus()
		{
			// Test
			var reportStatusEventArgs = new ReportStatusEventArgs("test status");

			// Analysis
			Assert.IsNotNull(reportStatusEventArgs);
			Assert.AreEqual("test status", reportStatusEventArgs.Status);
		}
		
		#endregion
		
		#region IReportStatusEventArgs Tests
		
		/// <summary>
		/// Tests the Status property can get/set as expected.
		/// </summary>
		[Test]
		public void Status_ShouldGetAndSetStatus()
		{
			// Setup
			var reportStatusEventArgs = new ReportStatusEventArgs("test status");

			// Test
			Assert.AreEqual("test status", reportStatusEventArgs.Status);
			reportStatusEventArgs.Status = "new test status";

			// Analysis
			Assert.AreEqual("new dummy status", reportStatusEventArgs.Status);
		}
		
		#endregion	
	}
}
