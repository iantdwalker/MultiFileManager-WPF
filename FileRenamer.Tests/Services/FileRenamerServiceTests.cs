using System;
using System.Collections.Generic;
using System.IO;

using Moq;
using NUnit.Framework;

using FileRenamer.Model;
using FileRenamer.Services;
using MultiFileManager.Common.Events;

namespace FileRenamer.Tests.Services
{
	/// <summary>
	/// Provides test functionality for the FileRenamerService class.
	/// </summary>
	[TestFixture]
	public class FileRenamerServiceTests
	{
		#region Private Members

		//private Mock<ITrimService>				_mockTrimService;
		//private Mock<IModifyExtensionService>	_mockModifyExtensionService;
		//private Mock<ICasingService>			_mockCasingService;
		//private Mock<IDirectoryInfoWrapper>		_mockDirectoryInfo;
		
		//private IList<string> 					_onReportStatusEventCalls;
		//private IList<int> 						_onReportProgressEventCalls;

		#endregion
		
		#region Setup/Teardown
		
		///// <summary>
		///// FixtureSetUp.
		///// </summary>
		//public override void FixtureSetUp()
		//{
		//	base.FixtureSetUp();
			
		//	_onReportStatusEventCalls 	= new List<string>();
		//	_onReportProgressEventCalls = new List<int>();
		//}
		
		///// <summary>
		///// SetupTestPreconditions.
		///// </summary>
		//protected override void SetupTestPreconditions()
		//{
		//	base.SetupTestPreconditions();
			
		//	_mockTrimService				= new Mock<ITrimService>();
		//	_mockModifyExtensionService 	= new Mock<IModifyExtensionService>();
		//	_mockCasingService				= new Mock<ICasingService>();
		//	_mockDirectoryInfo				= new Mock<IDirectoryInfoWrapper>();
		//}
		
		///// <summary>
		///// SetupTestPostconditions.
		///// </summary>
		//protected override void SetupTestPostconditions()
		//{
		//	base.SetupTestPostconditions();
			
		//	TestSubject.ReportStatus 	+= new EventHandler<ReportStatusEventArgs>(TestSubject_ReportStatus);
		//	TestSubject.ReportProgress 	+= new EventHandler<ReportProgressEventArgs>(TestSubject_ReportProgress);
		//}
		
		///// <summary>
		///// TestTearDown.
		///// </summary>
		//public override void TestTearDown()
		//{
		//	base.TestTearDown();
			
		//	ReportStatusEventCalls.Clear();
		//	ReportProgressEventCalls.Clear();			

		//	TestSubject.ReportStatus 	-= TestSubject_ReportStatus;
		//	TestSubject.ReportProgress 	-= TestSubject_ReportProgress;
		//}

		///// <summary>
		///// Create the TestSubject.
		///// </summary>
		///// <returns></returns>
		//protected override IFileRenamerService CreateTestSubject()
		//{
		//	return new FileRenamerService(_mockTrimService.Object, _mockModifyExtensionService.Object, _mockCasingService.Object, _mockDirectoryInfo.Object);
		//}
		
		#endregion
		
		#region Construction Tests
		
		///// <summary>
		///// Tests the constructor of the FileRenamerService with a null ITrimService parameter.
		///// </summary>
		//[Test()]
		//public void TestConstructor_NullITrimService()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		IFileRenamerService fileRenamerService = new FileRenamerService(null, new ModifyExtensionService(), new CasingService(), new DirectoryInfoWrapper());
		//	});
		//}
		
		///// <summary>
		///// Tests the constructor of the FileRenamerService with a null IModifyExtensionService parameter.
		///// </summary>
		//[Test()]
		//public void TestConstructor_NullIModifyExtensionService()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		IFileRenamerService fileRenamerService = new FileRenamerService(new TrimService(), null, new CasingService(), new DirectoryInfoWrapper());
		//	});
		//}
		
		///// <summary>
		///// Tests the constructor of the FileRenamerService with a null ICasingService parameter.
		///// </summary>
		//[Test()]
		//public void TestConstructor_NullICasingService()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		IFileRenamerService fileRenamerService = new FileRenamerService(new TrimService(), new ModifyExtensionService(), null, new DirectoryInfoWrapper());
		//	});
		//}
		
		///// <summary>
		///// Tests the constructor of the FileRenamerService with a null IDirectoryInfo parameter.
		///// </summary>
		//[Test()]
		//public void TestConstructor_NullIDirectoryInfo()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		IFileRenamerService fileRenamerService = new FileRenamerService(new TrimService(), new ModifyExtensionService(), new CasingService(), null);
		//	});
		//}
		
		///// <summary>
		///// Tests the constructor of the FileRenamerService.
		///// </summary>
		//[Test()]
		//public void TestConstructor()
		//{		
		//	IFileRenamerService fileRenamerService 	= new FileRenamerService(new TrimService(), new ModifyExtensionService(), new CasingService(), new DirectoryInfoWrapper());
		//	Assert.IsNotNull(fileRenamerService, "The FileRenamerService should not be null after construction.");
		//}
		
		#endregion
		
		#region IFileRenamerService Tests
		
		///// <summary>
		///// Tests the RenameFiles method with a null path parameter.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_NullPath()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		TestSubject.RenameFiles(null, new TrimSettings(), new ExtensionModifierSettings(), new CasingSettings());
		//	});
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with an empty path parameter.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_EmptyPath()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		TestSubject.RenameFiles(string.Empty, new TrimSettings(), new ExtensionModifierSettings(), new CasingSettings());
		//	});
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with a null TrimSettings parameter.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_NullTrimSettings()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		TestSubject.RenameFiles("dummyPath", null, new ExtensionModifierSettings(), new CasingSettings());
		//	});
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with a null ExtensionModifierSettings parameter.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_NullExtensionModifierSettings()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		TestSubject.RenameFiles("dummyPath", new TrimSettings(), null, new CasingSettings());
		//	});
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with a null CasingSettings parameter.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_NullCasingSettingsSettings()
		//{
		//	Assert.Throws<ArgumentNullException>(delegate 
		//	{
		//		TestSubject.RenameFiles("dummyPath", new TrimSettings(), new ExtensionModifierSettings(), null);
		//	});
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with directory path that doesn't exist.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_DirectoryPathInvalid()
		//{
		//	//expectations
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesntExist"));
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.Exists).Returns(false);			
						
		//	Assert.Throws<InvalidOperationException>(delegate 
		//	{
		//		TestSubject.RenameFiles("dummyPathDoesntExist", new TrimSettings(), new ExtensionModifierSettings(), new CasingSettings());
		//	});
			
		//	//verify expectations
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesntExist"), Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.Exists, Times.Exactly(1));
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with directory path that is valid but contains 0 files.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_DirectoryPathValid_0Files()
		//{
		//	IFileInfoWrapper[] emptyFiles = new IFileInfoWrapper[0];
			
		//	//expectations
		//	Assert.AreEqual(0, ReportStatusEventCalls.Count, 	"There shouldn't have been any calls to OnReportStatus yet.");
		//	Assert.AreEqual(0, ReportProgressEventCalls.Count, 	"There shouldn't have been any calls to OnReportProgress yet.");
			
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"));
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.Exists).Returns(true);
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)).Returns(emptyFiles);			
						
		//	TestSubject.RenameFiles("dummyPathDoesExist", new TrimSettings(), new ExtensionModifierSettings(), new CasingSettings());
			
		//	//verify expectations
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"), Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.Exists, Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly), Times.Exactly(1));
			
		//	Assert.AreEqual(1, ReportStatusEventCalls.Count, 										"The number of calls to OnReportStatus is not as expected.");
		//	Assert.AreEqual("0 file(s) will be processed in total.\n", ReportStatusEventCalls[0], 	"The reported status is not as expected.");
		//	Assert.AreEqual(1, ReportProgressEventCalls.Count, 										"The number of calls to OnReportProgress is not as expected.");
		//	Assert.AreEqual(100, ReportProgressEventCalls[0], 										"The reported progress is not as expected.");
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with directory path that is valid and contains a file.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_DirectoryPathValid_1File_HasExtension_WithTrim()
		//{
		//	//expectations
		//	IFileInfoWrapper[] 	files 			= new IFileInfoWrapper[1];
		//	Mock<IFileInfoWrapper>	mockFileInfo 	= new Mock<IFileInfoWrapper>();
		//	mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("originalFileName.jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.Extension).Returns(".jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\FileName.jpg")).Callback(()
  //          	=> mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("FileName.jpg"));			
			
		//	files[0] = mockFileInfo.Object;			
			
		//	Assert.AreEqual(0, ReportStatusEventCalls.Count, 	"There shouldn't have been any calls to OnReportStatus yet.");
		//	Assert.AreEqual(0, ReportProgressEventCalls.Count, 	"There shouldn't have been any calls to OnReportProgress yet.");
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"));
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.Exists).Returns(true);
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)).Returns(files);
		//	_mockTrimService.Setup(trim => trim.TrimFileName("originalFileName", TrimType.RemoveExactTrimString, "original")).Returns("FileName");
						
		//	//setup test parameters
		//	ITrimSettings trimSettings 	= new TrimSettings();
		//	trimSettings.Trim 			= true;
		//	trimSettings.TrimType 		= TrimType.RemoveExactTrimString;
		//	trimSettings.TrimString 	= "original";
			
		//	TestSubject.RenameFiles("dummyPathDoesExist", trimSettings, new ExtensionModifierSettings(), new CasingSettings());
			
		//	//verify expectations
		//	mockFileInfo.Verify(fileInfo => fileInfo.Name, Times.Exactly(5));
		//	mockFileInfo.Verify(fileInfo => fileInfo.Extension, Times.Exactly(3));
		//	mockFileInfo.Verify(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\FileName.jpg"), Times.Exactly(1));
			
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"), Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.Exists, Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly), Times.Exactly(1));
			
		//	Assert.AreEqual(2, ReportStatusEventCalls.Count, "The number of calls to OnReportStatus is not as expected.");
		//	Assert.AreEqual("1 file(s) will be processed in total.\n", ReportStatusEventCalls[0], "The reported status is not as expected.");
		//	Assert.AreEqual("1: Finished renaming file: 'originalFileName.jpg'. The new file name is: 'FileName.jpg'.\n", ReportStatusEventCalls[1], "The reported status is not as expected.");
			
		//	Assert.AreEqual(2, 		ReportProgressEventCalls.Count, "The number of calls to OnReportProgress is not as expected.");
		//	Assert.AreEqual(0, 		ReportProgressEventCalls[0], 	"The reported progress is not as expected.");
		//	Assert.AreEqual(100, 	ReportProgressEventCalls[1], 	"The reported progress is not as expected.");
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with directory path that is valid and contains a file.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_DirectoryPathValid_1File_NoExtension_WithTrim()
		//{
		//	//expectations
		//	IFileInfoWrapper[] 	files 			= new IFileInfoWrapper[1];
		//	Mock<IFileInfoWrapper>	mockFileInfo 	= new Mock<IFileInfoWrapper>();
		//	mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("originalFileName");
		//	mockFileInfo.Setup(fileInfo => fileInfo.Extension).Returns(string.Empty);
		//	mockFileInfo.Setup(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\FileName")).Callback(()
  //          	=> mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("FileName"));			
			
		//	files[0] = mockFileInfo.Object;			
			
		//	Assert.AreEqual(0, ReportStatusEventCalls.Count, 	"There shouldn't have been any calls to OnReportStatus yet.");
		//	Assert.AreEqual(0, ReportProgressEventCalls.Count, 	"There shouldn't have been any calls to OnReportProgress yet.");
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"));
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.Exists).Returns(true);
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)).Returns(files);
		//	_mockTrimService.Setup(trim => trim.TrimFileName("originalFileName", TrimType.RemoveExactTrimString, "original")).Returns("FileName");
						
		//	//setup test parameters
		//	ITrimSettings trimSettings 	= new TrimSettings();
		//	trimSettings.Trim 			= true;
		//	trimSettings.TrimType 		= TrimType.RemoveExactTrimString;
		//	trimSettings.TrimString 	= "original";
			
		//	TestSubject.RenameFiles("dummyPathDoesExist", trimSettings, new ExtensionModifierSettings(), new CasingSettings());
			
		//	//verify expectations
		//	mockFileInfo.Verify(fileInfo => fileInfo.Name, Times.Exactly(3));
		//	mockFileInfo.Verify(fileInfo => fileInfo.Extension, Times.Exactly(2));
		//	mockFileInfo.Verify(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\FileName"), Times.Exactly(1));
			
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"), Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.Exists, Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly), Times.Exactly(1));
			
		//	Assert.AreEqual(2, ReportStatusEventCalls.Count, "The number of calls to OnReportStatus is not as expected.");
		//	Assert.AreEqual("1 file(s) will be processed in total.\n", ReportStatusEventCalls[0], "The reported status is not as expected.");
		//	Assert.AreEqual("1: Finished renaming file: 'originalFileName'. The new file name is: 'FileName'.\n", ReportStatusEventCalls[1], "The reported status is not as expected.");
			
		//	Assert.AreEqual(2, 		ReportProgressEventCalls.Count, "The number of calls to OnReportProgress is not as expected.");
		//	Assert.AreEqual(0, 		ReportProgressEventCalls[0], 	"The reported progress is not as expected.");
		//	Assert.AreEqual(100, 	ReportProgressEventCalls[1], 	"The reported progress is not as expected.");
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with directory path that is valid and contains a file.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_DirectoryPathValid_1File_HasExtension_WithModifyExtension()
		//{
		//	//expectations
		//	IFileInfoWrapper[] 	files 			= new IFileInfoWrapper[1];
		//	Mock<IFileInfoWrapper>	mockFileInfo 	= new Mock<IFileInfoWrapper>();
		//	mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("originalFileName.jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.Extension).Returns(".jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\originalFileName.txt")).Callback(()
  //          	=> mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("originalFileName.txt"));			
			
		//	files[0] = mockFileInfo.Object;			
			
		//	Assert.AreEqual(0, ReportStatusEventCalls.Count, 	"There shouldn't have been any calls to OnReportStatus yet.");
		//	Assert.AreEqual(0, ReportProgressEventCalls.Count, 	"There shouldn't have been any calls to OnReportProgress yet.");
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"));
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.Exists).Returns(true);
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)).Returns(files);
		//	_mockModifyExtensionService.Setup(fileInfo => fileInfo.ModifyFileNameExtension(".jpg", FileNameExtensionType.ExactExtension, ".txt")).Returns(".txt");
						
		//	//setup test parameters
		//	IExtensionModifierSettings extensionModifierSettings 	= new ExtensionModifierSettings();
		//	extensionModifierSettings.ModifyExtension 				= true;
		//	extensionModifierSettings.ExtensionType 				= FileNameExtensionType.ExactExtension;
		//	extensionModifierSettings.ExactExtensionString 			= ".txt";
			
		//	TestSubject.RenameFiles("dummyPathDoesExist", new TrimSettings(), extensionModifierSettings, new CasingSettings());
			
		//	//verify expectations
		//	mockFileInfo.Verify(fileInfo => fileInfo.Name, Times.Exactly(5));
		//	mockFileInfo.Verify(fileInfo => fileInfo.Extension, Times.Exactly(3));
		//	mockFileInfo.Verify(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\originalFileName.txt"), Times.Exactly(1));
			
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"), Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.Exists, Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly), Times.Exactly(1));
			
		//	Assert.AreEqual(2, ReportStatusEventCalls.Count, "The number of calls to OnReportStatus is not as expected.");
		//	Assert.AreEqual("1 file(s) will be processed in total.\n", ReportStatusEventCalls[0], "The reported status is not as expected.");
		//	Assert.AreEqual("1: Finished renaming file: 'originalFileName.jpg'. The new file name is: 'originalFileName.txt'.\n", ReportStatusEventCalls[1], "The reported status is not as expected.");
			
		//	Assert.AreEqual(2, 		ReportProgressEventCalls.Count, "The number of calls to OnReportProgress is not as expected.");
		//	Assert.AreEqual(0, 		ReportProgressEventCalls[0], 	"The reported progress is not as expected.");
		//	Assert.AreEqual(100, 	ReportProgressEventCalls[1], 	"The reported progress is not as expected.");
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with directory path that is valid and contains a file.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_DirectoryPathValid_1File_HasExtension_WithTrimAndModifyExtension()
		//{
		//	//expectations
		//	IFileInfoWrapper[] 	files 			= new IFileInfoWrapper[1];
		//	Mock<IFileInfoWrapper>	mockFileInfo 	= new Mock<IFileInfoWrapper>();
		//	mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("originalFileName.jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.Extension).Returns(".jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\FileName.txt")).Callback(()
  //          	=> mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("FileName.txt"));			
			
		//	files[0] = mockFileInfo.Object;			
			
		//	Assert.AreEqual(0, ReportStatusEventCalls.Count, 	"There shouldn't have been any calls to OnReportStatus yet.");
		//	Assert.AreEqual(0, ReportProgressEventCalls.Count, 	"There shouldn't have been any calls to OnReportProgress yet.");
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"));
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.Exists).Returns(true);
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)).Returns(files);
		//	_mockTrimService.Setup(trim => trim.TrimFileName("originalFileName", TrimType.RemoveExactTrimString, "original")).Returns("FileName");
		//	_mockModifyExtensionService.Setup(fileInfo => fileInfo.ModifyFileNameExtension(".jpg", FileNameExtensionType.ExactExtension, ".txt")).Returns(".txt");
						
		//	//setup test parameters
		//	ITrimSettings trimSettings 	= new TrimSettings();
		//	trimSettings.Trim 			= true;
		//	trimSettings.TrimType 		= TrimType.RemoveExactTrimString;
		//	trimSettings.TrimString 	= "original";
			
		//	IExtensionModifierSettings extensionModifierSettings 	= new ExtensionModifierSettings();
		//	extensionModifierSettings.ModifyExtension 				= true;
		//	extensionModifierSettings.ExtensionType 				= FileNameExtensionType.ExactExtension;
		//	extensionModifierSettings.ExactExtensionString 			= ".txt";
			
		//	TestSubject.RenameFiles("dummyPathDoesExist", trimSettings, extensionModifierSettings, new CasingSettings());
			
		//	//verify expectations
		//	mockFileInfo.Verify(fileInfo => fileInfo.Name, Times.Exactly(5));
		//	mockFileInfo.Verify(fileInfo => fileInfo.Extension, Times.Exactly(3));
		//	mockFileInfo.Verify(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\FileName.txt"), Times.Exactly(1));
			
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"), Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.Exists, Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly), Times.Exactly(1));
			
		//	Assert.AreEqual(2, ReportStatusEventCalls.Count, "The number of calls to OnReportStatus is not as expected.");
		//	Assert.AreEqual("1 file(s) will be processed in total.\n", ReportStatusEventCalls[0], "The reported status is not as expected.");
		//	Assert.AreEqual("1: Finished renaming file: 'originalFileName.jpg'. The new file name is: 'FileName.txt'.\n", ReportStatusEventCalls[1], "The reported status is not as expected.");
			
		//	Assert.AreEqual(2, 		ReportProgressEventCalls.Count, "The number of calls to OnReportProgress is not as expected.");
		//	Assert.AreEqual(0, 		ReportProgressEventCalls[0], 	"The reported progress is not as expected.");
		//	Assert.AreEqual(100, 	ReportProgressEventCalls[1], 	"The reported progress is not as expected.");
		//}
		
		///// <summary>
		///// Tests the RenameFiles method with directory path that is valid and contains a file.
		///// </summary>
		//[Test()]
		//public void TestRenameFiles_DirectoryPathValid_1File_HasExtension_WithCasing()
		//{
		//	//expectations
		//	IFileInfoWrapper[] 	files 			= new IFileInfoWrapper[1];
		//	Mock<IFileInfoWrapper>	mockFileInfo 	= new Mock<IFileInfoWrapper>();
		//	mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("originalFileName.jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.Extension).Returns(".jpg");
		//	mockFileInfo.Setup(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\originalfilename.jpg")).Callback(()
  //          	=> mockFileInfo.Setup(fileInfo => fileInfo.Name).Returns("originalfilename.jpg"));			
			
		//	files[0] = mockFileInfo.Object;			
			
		//	Assert.AreEqual(0, ReportStatusEventCalls.Count, 	"There shouldn't have been any calls to OnReportStatus yet.");
		//	Assert.AreEqual(0, ReportProgressEventCalls.Count, 	"There shouldn't have been any calls to OnReportProgress yet.");
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"));
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.Exists).Returns(true);
		//	_mockDirectoryInfo.Setup(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)).Returns(files);
		//	_mockCasingService.Setup(casing => casing.ChangeFileNameCase("originalFileName", CasingType.LowerCase)).Returns("originalfilename");
									
		//	//setup test parameters
		//	ICasingSettings casingSettings = new CasingSettings();
		//	casingSettings.ModifyCase = true;
		//	casingSettings.CasingType = CasingType.LowerCase;
			
		//	TestSubject.RenameFiles("dummyPathDoesExist", new TrimSettings(), new ExtensionModifierSettings(), casingSettings);
			
		//	//verify expectations
		//	mockFileInfo.Verify(fileInfo => fileInfo.Name, Times.Exactly(5));
		//	mockFileInfo.Verify(fileInfo => fileInfo.Extension, Times.Exactly(3));
		//	mockFileInfo.Verify(fileInfo => fileInfo.MoveTo("dummyPathDoesExist\\originalfilename.jpg"), Times.Exactly(1));
			
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.SetDirectoryPath("dummyPathDoesExist"), Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.Exists, Times.Exactly(1));
		//	_mockDirectoryInfo.Verify(directoryInfo => directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly), Times.Exactly(1));
			
		//	Assert.AreEqual(2, ReportStatusEventCalls.Count, "The number of calls to OnReportStatus is not as expected.");
		//	Assert.AreEqual("1 file(s) will be processed in total.\n", ReportStatusEventCalls[0], "The reported status is not as expected.");
		//	Assert.AreEqual("1: Finished renaming file: 'originalFileName.jpg'. The new file name is: 'originalfilename.jpg'.\n", ReportStatusEventCalls[1], "The reported status is not as expected.");
			
		//	Assert.AreEqual(2, 		ReportProgressEventCalls.Count, "The number of calls to OnReportProgress is not as expected.");
		//	Assert.AreEqual(0, 		ReportProgressEventCalls[0], 	"The reported progress is not as expected.");
		//	Assert.AreEqual(100, 	ReportProgressEventCalls[1], 	"The reported progress is not as expected.");
		//}
		
		#endregion
		
		#region Protected Members
		
		///// <summary>
		///// ReportStatusEventCalls.
		///// </summary>
		//protected IList<string> ReportStatusEventCalls
		//{
		//	get
		//	{
		//		return _onReportStatusEventCalls;
		//	}				
		//}
		
		///// <summary>
		///// ReportProgressEventCalls.
		///// </summary>
		//protected IList<int> ReportProgressEventCalls
		//{
		//	get
		//	{
		//		return _onReportProgressEventCalls;
		//	}				
		//}
		
		#endregion
		
		#region Private Methods
		
		///// <summary>
		///// TestSubject_ReportStatus.
		///// </summary>
		///// <param name="sender"></param>
		///// <param name="e"></param>
		//private void TestSubject_ReportStatus(object sender, ReportStatusEventArgs e)
		//{
		//	_onReportStatusEventCalls.Add(e.Status);
		//}
		
		///// <summary>
		///// TestSubject_ReportProgress.
		///// </summary>
		///// <param name="sender"></param>
		///// <param name="e"></param>
		//private void TestSubject_ReportProgress(object sender, ReportProgressEventArgs e)
		//{
		//	_onReportProgressEventCalls.Add(e.Progress);
		//}
		
		#endregion
	}
}
