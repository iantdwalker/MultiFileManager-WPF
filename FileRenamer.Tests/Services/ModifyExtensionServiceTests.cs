using System;

using NUnit.Framework;

using FileRenamer.Model;
using FileRenamer.Services;

namespace FileRenamer.Tests.Services
{
	/// <summary>
	/// Provides test functionality for the ModifyExtensionService class.
	/// </summary>
	[TestFixture]
	public class ModifyExtensionServiceTests
	{
		#region Setup/Teardown
		
		///// <summary>
		///// Create the TestSubject.
		///// </summary>
		///// <returns></returns>
		//protected override IModifyExtensionService CreateTestSubject()
		//{
		//	return new ModifyExtensionService();
		//}
		
		#endregion
		
		#region IModifyExtensionService Tests
		
		///// <summary>
		///// Tests the ModifyFileNameExtension method with a lower case extension
		/////	specified but with a null extension parameter.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_LowerCaseExtension_NullExtension()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.ModifyFileNameExtension(null, FileNameExtensionType.LowerCaseExtension, string.Empty);
		//	});
		//}

		///// <summary>
		///// Tests the ModifyFileNameExtension method with a lower case extension
		/////	specified but with an empty extension parameter.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_LowerCaseExtension_EmptyExtension()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.ModifyFileNameExtension(string.Empty, FileNameExtensionType.LowerCaseExtension, null);
		//	});
		//}
		
		///// <summary>
		///// Tests the ModifyFileNameExtension method with a lower case extension
		/////	specified.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_LowerCaseExtension()
		//{
		//	string returnedValue = TestSubject.ModifyFileNameExtension(".JPG", FileNameExtensionType.LowerCaseExtension, null);
		//	Assert.AreEqual(".jpg", returnedValue, "The modified file name extension returned from the ModifyFileNameExtension call is not as expected.");
		//}
		
		///// <summary>
		///// Tests the ModifyFileNameExtension method with an upper case extension
		/////	specified.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_UpperCaseExtension()
		//{
		//	string returnedValue = TestSubject.ModifyFileNameExtension(".jpg", FileNameExtensionType.UpperCaseExtension, null);
		//	Assert.AreEqual(".JPG", returnedValue, "The modified file name extension returned from the ModifyFileNameExtension call is not as expected.");
		//}
		
		///// <summary>
		///// Tests the ModifyFileNameExtension method with a request to remove the extension specified.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_RemoveExtension()
		//{
		//	string returnedValue = TestSubject.ModifyFileNameExtension(".JPG", FileNameExtensionType.RemoveExtension, null);
		//	Assert.AreEqual(string.Empty, returnedValue, "The modified file name extension returned from the ModifyFileNameExtension call is not as expected.");
		//}
		
		///// <summary>
		///// Tests the ModifyFileNameExtension method with a exact extension
		/////	specified but with a null exactExtension parameter.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_ExactExtension_NullExactExtension()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.ModifyFileNameExtension(".jpeg", FileNameExtensionType.ExactExtension, null);
		//	});
		//}

		///// <summary>
		///// Tests the ModifyFileNameExtension method with a exact extension
		/////	specified but with an empty exactExtension parameter.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_ExactExtension_EmptyExactExtension()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate
		//	{
		//		TestSubject.ModifyFileNameExtension(".jpeg", FileNameExtensionType.ExactExtension, string.Empty);
		//	});
		//}
		
		///// <summary>
		///// Tests the ModifyFileNameExtension method with with a exact extension specified,
		///// starting with a dot.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_ExactExtensionWithDot()
		//{
		//	string returnedValue = TestSubject.ModifyFileNameExtension(".jpeg", FileNameExtensionType.ExactExtension, ".JPG");
		//	Assert.AreEqual(".JPG", returnedValue, "The modified file name extension returned from the ModifyFileNameExtension call is not as expected.");
		//}
		
		///// <summary>
		///// Tests the ModifyFileNameExtension method with with a exact extension specified,
		///// without a dot.
		///// </summary>
		//[Test]
		//public void TestModifyFileNameExtension_ExactExtensionWithoutDot()
		//{
		//	string returnedValue = TestSubject.ModifyFileNameExtension(".jpeg", FileNameExtensionType.ExactExtension, "JPG");
		//	Assert.AreEqual(".JPG", returnedValue, "The modified file name extension returned from the ModifyFileNameExtension call is not as expected.");
		//}
		
		#endregion
	}
}
