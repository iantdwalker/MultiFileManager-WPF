using System;

using NUnit.Framework;

using FileRenamer.Model;
using FileRenamer.Services;

namespace MultiFileManager.Logic.Tests.Services.FileRenamer
{
	/// <summary>
	/// Provides test functionality for the TrimService class.
	/// </summary>
	[TestFixture]
	public class TrimServiceTests
	{
		#region Setup/Teardown
		
		///// <summary>
		///// Create the TestSubject.
		///// </summary>
		///// <returns></returns>
		//protected override ITrimService CreateTestSubject()
		//{
		//	return new TrimService();
		//}
		
		#endregion
		
		#region ITrimService Tests
		
		///// <summary>
		///// Tests the TrimFileName method with a null fileName parameter.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_NullFileName()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.TrimFileName(null, TrimType.TrimBeforeTrimString, "trimString");
		//	});
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with an empty fileName parameter.
		//[Test]
		//public void TestTrimFileName_EmptyFileName()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.TrimFileName(string.Empty, TrimType.TrimBeforeTrimString, "trimString");
		//	});
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with a null trimString parameter.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_NullTrimString()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.TrimFileName("fileName", TrimType.TrimBeforeTrimString, null);
		//	});
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with an empty trimString parameter.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_EmptyTrimString()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.TrimFileName("fileName", TrimType.TrimBeforeTrimString, string.Empty);
		//	});
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with RemoveExactTrimString specified but the supplied trim string cannot be found.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_RemoveExactTrimString_TrimStringNotFound()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.RemoveExactTrimString, "dummy");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("fileName", trimmedFileName, 	"The trimmed file name value is not as expected.");
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with RemoveExactTrimString specified.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_RemoveExactTrimString()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.RemoveExactTrimString, "leN");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("fiame", trimmedFileName, 		"The trimmed file name value is not as expected.");
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with RemoveExactTrimString specified.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_RemoveExactTrimString_WholeStringRemoved()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.RemoveExactTrimString, "fileName");
		//	Assert.AreEqual(string.Empty, trimmedFileName, 		"The trimmed file name value is not as expected.");
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with TrimBeforeTrimString specified but the supplied trim string cannot be found.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_TrimBeforeTrimString_TrimStringNotFound()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.TrimBeforeTrimString, "dummy");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("fileName", trimmedFileName, 	"The trimmed file name value is not as expected.");
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with TrimBeforeTrimString specified.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_TrimBeforeTrimString()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.TrimBeforeTrimString, "Name");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("Name", trimmedFileName, 		"The trimmed file name value is not as expected.");
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with TrimBeforeTrimString specified.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_TrimBeforeTrimString_WholeStringSpecified()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.TrimBeforeTrimString, "fileName");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("fileName", trimmedFileName, 		"The trimmed file name value is not as expected.");
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with TrimAfterTrimString specified but the supplied trim string cannot be found.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_TrimAfterTrimString_TrimStringNotFound()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.TrimAfterTrimString, "dummy");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("fileName", trimmedFileName, 	"The trimmed file name value is not as expected.");
		//}		

		///// <summary>
		///// Tests the TrimFileName method with TrimAfterTrimString specified.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_TrimAfterTrimString()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.TrimAfterTrimString, "file");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("file", trimmedFileName, 		"The trimmed file name value is not as expected.");
		//}
		
		///// <summary>
		///// Tests the TrimFileName method with TrimAfterTrimString specified.
		///// </summary>
		//[Test]
		//public void TestTrimFileName_TrimAfterTrimString_WholeStringSpecified()
		//{			
		//	string trimmedFileName = TestSubject.TrimFileName("fileName", TrimType.TrimAfterTrimString, "fileName");
		//	Assert.IsNotNullOrEmpty(trimmedFileName, 		"The trimmed file name should not be null or empty");
		//	Assert.AreEqual("fileName", trimmedFileName, 		"The trimmed file name value is not as expected.");
		//}
		
		#endregion
	}
}
