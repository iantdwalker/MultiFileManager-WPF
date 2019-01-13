using System;
using System.Collections.Generic;
using System.ComponentModel;

using Moq;
using NUnit.Framework;

using FileRenamer.Model;
using FileRenamer.Services;
using FileRenamer.ViewModel;

using WPFHelpers.DataBinding;
using WPFHelpers.Commands;
using WPFHelpers.Services;
using WPFHelpers.Tests.DataBinding;

using MultiFileManager.Common.Events;

namespace MultiFileManager.Logic.Tests.ViewModel.FileRenamer
{
	/// <summary>
	/// Tests the functionality of the FileRenamerViewModel class. 
	/// </summary>
	[TestFixture]
	public class TestFileRenamerViewModel : BaseNotifyPropertyChangedTests<IFileRenamerViewModel>
	{
		#region Private Members
		
		private ITrimSettings 						_trimSettings;
		private IExtensionModifierSettings 			_extensionModifierSettings;
		private ICasingSettings						_casingSettings;
		private Mock<ISelectFolderService> 			_mockSelectFolderService;
		private Mock<IFileRenamerService> 			_mockFileRenamerService;
		
		#endregion
		
		#region Setup/Teardown
		
		///// <summary>
		///// SetupTestPreconditions.
		///// </summary>
		//protected override void SetupTestPreconditions()
		//{
		//	base.SetupTestPreconditions();
			
		//	_trimSettings 					= new TrimSettings();
		//	_extensionModifierSettings 		= new ExtensionModifierSettings();
		//	_casingSettings					= new CasingSettings();
		//	_mockSelectInputFolderService 	= new Mock<ISelectInputFolderService>();
		//	_mockFileRenamerService 		= new Mock<IFileRenamerService>();
		//}
		
		/// <summary>
		/// Create the TestSubject.
		/// </summary>
		/// <returns></returns>
		//protected override IFileRenamerViewModel CreateTestSubject()
		//{		
		//	IFileRenamerViewModel fileRenamerViewModel 	= new FileRenamerViewModel(_trimSettings,
		//	                                                                       _extensionModifierSettings,
		//	                                                                       _mockSelectInputFolderService.Object,
		//	                                                                       _mockFileRenamerService.Object);
			
		//	((INotifyPropertyChanged)fileRenamerViewModel).PropertyChanged += base.TestSubject_PropertyChanged;
			
		//	return fileRenamerViewModel;
		//}
		
		/// <summary>
		/// Test tear down.
		/// </summary>
		//public override void TestTearDown()
		//{
		//	base.TestTearDown();
		//	((INotifyPropertyChanged)TestSubject).PropertyChanged -= base.TestSubject_PropertyChanged;			
		//}
		
		#endregion	
		
		#region Test Construction
		
		/// <summary>
		/// Tests the constructor with a null ITrimSettings instance parameter.
		/// </summary>
		[Test]
		public void TestConstructor_NullITrimSettings()
		{
			Assert.Throws<ArgumentNullException>(delegate
			{
				IFileRenamerViewModel fileRenamerViewModel = new FileRenamerViewModel(null,
			                                     	                                  _extensionModifierSettings,
			                                     	                                  _mockSelectFolderService.Object,
			                                     	                                  _mockFileRenamerService.Object);
            });
		}

		/// <summary>
		/// Tests the constructor with a null IExtensionModifierSettings instance parameter.
		/// </summary>
		[Test]
		public void TestConstructor_NullIExtensionModifierSettings()
		{
			Assert.Throws<ArgumentNullException>(delegate
			{
				IFileRenamerViewModel fileRenamerViewModel = new FileRenamerViewModel(_trimSettings,
              	                                                                      null,
																						_mockSelectFolderService.Object,
              	                                                                      _mockFileRenamerService.Object);
			});
		}
		
		/// <summary>
		/// Tests the constructor with a null ISelectFolderService instance parameter.
		/// </summary>
		[Test]
		public void TestConstructor_NullISelectFolderService()
		{
			Assert.Throws<ArgumentNullException>(delegate
			{
				IFileRenamerViewModel fileRenamerViewModel = new FileRenamerViewModel(_trimSettings,
              	                                                                      _extensionModifierSettings,
              	                                                                      null,
              	                                                                      _mockFileRenamerService.Object);
			});
		}
		
		/// <summary>
		/// Tests the constructor with a null IFileRenamerService instance parameter.
		/// </summary>
		[Test]
		public void TestConstructor_NullIFileRenamerService()
		{
			Assert.Throws<ArgumentNullException>(delegate
			{
				IFileRenamerViewModel fileRenamerViewModel = new FileRenamerViewModel(_trimSettings,
               	                                                                      _extensionModifierSettings,
               	                                                                      _mockSelectFolderService.Object,
               	                                                                      null);
			});
		}			
		
		/// <summary>
		/// Tests the default constructor of the FileRenamerViewModel class.
		/// </summary>
		[Test]
		public void TestConstructor()
		{
			IFileRenamerViewModel fileRenamerViewModel = new FileRenamerViewModel(_trimSettings,
               	                                                                  _extensionModifierSettings,
               	                                                                  _mockSelectFolderService.Object,
               	                                                                  _mockFileRenamerService.Object);
			
			Assert.IsNotNull(fileRenamerViewModel, 								"The FileRenamerViewModel should not be null after construction.");
			Assert.IsNotNull(fileRenamerViewModel.TrimSettings, 				"The TrimSettings property should not be null after construction.");
			Assert.IsNotNull(fileRenamerViewModel.ExtensionModifierSettings, 	"The ExtensionModifierSettings property should not be null after construction.");
			Assert.IsNotNull(fileRenamerViewModel.SelectFolderService, 	"The SelectInputFolderService property should not be null after construction.");
			Assert.IsNotNull(fileRenamerViewModel.FileRenamerService, 			"The FileRenamerService property should not be null after construction.");
			
			Assert.AreEqual(_trimSettings, fileRenamerViewModel.TrimSettings, 										"The TrimSettings property is not as expected after construction.");
			Assert.AreEqual(_extensionModifierSettings, fileRenamerViewModel.ExtensionModifierSettings, 			"The ExtensionModifierSettings property is not as expected after construction.");
			Assert.AreEqual(_mockSelectFolderService.Object, fileRenamerViewModel.SelectFolderService, 	"The SelectInputFolderService property is not as expected after construction.");
			Assert.AreEqual(_mockFileRenamerService.Object, fileRenamerViewModel.FileRenamerService, 				"The FileRenamerService property is not as expected after construction.");			
			
			Assert.IsNotNull(fileRenamerViewModel.FileRenamerProcessCommand,								"The FileRenamerService property should not be null after construction.");
			Assert.AreEqual(typeof(RelayCommand), fileRenamerViewModel.FileRenamerProcessCommand.GetType(), "The ICommand instance type is not as expected.");
			Assert.IsNotNull(fileRenamerViewModel.ClearCommand,												"The ClearCommand property should not be null after construction.");
			Assert.AreEqual(typeof(RelayCommand), fileRenamerViewModel.ClearCommand.GetType(), 				"The ICommand instance type is not as expected.");
			Assert.IsNotNull(fileRenamerViewModel.SelectInputFolderCommand,									"The SelectInputFolderCommand property should not be null after construction.");
			Assert.AreEqual(typeof(RelayCommand), fileRenamerViewModel.SelectInputFolderCommand.GetType(), 	"The ICommand instance type is not as expected.");
			
			Assert.AreEqual("Select a folder of files to rename or insert a path here...", fileRenamerViewModel.InputFolderPath, "The InputFolderPath property value is not as expected after construction.");
			Assert.AreEqual("File renaming process logging will appear here...", fileRenamerViewModel.Logging, "The Logging property value is not as expected after construction.");
			
			//check that the ReportStatus/ReportProgress event handlers are attached
			fileRenamerViewModel.Logging = string.Empty;
			_mockFileRenamerService.Raise(fileRenamerService => fileRenamerService.ReportStatus += null, new ReportStatusEventArgs("test status"));
			Assert.AreEqual("test status", fileRenamerViewModel.Logging, "The ReportStatus event handler is not attached as expected.");
			_mockFileRenamerService.Raise(fileRenamerService => fileRenamerService.ReportProgress += null, new ReportProgressEventArgs(40));
			Assert.AreEqual(40, fileRenamerViewModel.ProcessingProgress, "The ReportProgress event handler is not attached as expected.");
			
			//check that the TrimSettings/ExtensionModifierSettings PropertyChanged event handlers are attached
			IList<string> propertyChangedEvents = new List<string>();
			((BaseNotifyPropertyChanged)fileRenamerViewModel).PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
			{
				propertyChangedEvents.Add(e.PropertyName);
			};
			
			_trimSettings.TrimString 							= "test string";
			_extensionModifierSettings.ExactExtensionString 	= "another test string";
			Assert.AreEqual(2, propertyChangedEvents.Count, 					"The expected number of property changed events were not fired.");
			Assert.AreEqual("TrimString", propertyChangedEvents[0], 			"The expected property changed event was not fired.");
			Assert.AreEqual("ExactExtensionString", propertyChangedEvents[1], 	"The expected property changed event was not fired.");
		}	
		
		#endregion
		
		#region Test IFileRenamerViewModel Members
		
		///// <summary>
		///// Tests that the InputFolderPath property can get/set as expected.
		///// </summary>
		//[Test]
		//public void TestInputFolderPath()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 					"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.InputFolderPath = "a new InputFolderPath";
		//	Assert.AreEqual("a new InputFolderPath", TestSubject.InputFolderPath, 	"The InputFolderPath property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 					"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("InputFolderPath", PropertyChangedEventCalls[0], 		"The Property that changed is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the InputFolderPath property can get/set as expected
		///// when the value is the same.
		///// </summary>
		//[Test]
		//public void TestInputFolderPath_SameValueSet()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 					"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.InputFolderPath = "a new InputFolderPath";
		//	Assert.AreEqual("a new InputFolderPath", TestSubject.InputFolderPath, 	"The InputFolderPath property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 					"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("InputFolderPath", PropertyChangedEventCalls[0], 		"The Property that changed is not as expected.");
			
		//	TestSubject.InputFolderPath = "a new InputFolderPath";
		//	Assert.AreEqual("a new InputFolderPath", TestSubject.InputFolderPath, 	"The InputFolderPath property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 					"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("InputFolderPath", PropertyChangedEventCalls[0], 		"The Property that changed is not as expected.");			
		//}
		
		///// <summary>
		///// Tests that the TrimSettings property can get as expected.
		///// </summary>
		//[Test]
		//public void TestTrimSettings()
		//{
		//	Assert.IsNotNull(TestSubject.TrimSettings, "The TrimSettings property should not be null.");
		//	Assert.AreEqual(_trimSettings, TestSubject.TrimSettings, "The TrimSettings property is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the ExtensionModifierSettings property can get as expected.
		///// </summary>
		//[Test]
		//public void TestExtensionModifierSettings()
		//{
		//	Assert.IsNotNull(TestSubject.ExtensionModifierSettings, "The ExtensionModifierSettings property should not be null.");
		//	Assert.AreEqual(_extensionModifierSettings, TestSubject.ExtensionModifierSettings, "The ExtensionModifierSettings property is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the SelectInputFolderService property can get as expected.
		///// </summary>
		//[Test]
		//public void TestSelectInputFolderService()
		//{
		//	Assert.IsNotNull(TestSubject.SelectInputFolderService, "The SelectInputFolderService property should not be null.");
		//	Assert.AreEqual(_mockSelectInputFolderService.Object, TestSubject.SelectInputFolderService, "The SelectInputFolderService property is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the FileRenamerService property can get as expected.
		///// </summary>
		//[Test]
		//public void TestFileRenamerService()
		//{
		//	Assert.IsNotNull(TestSubject.FileRenamerService, "The FileRenamerService property should not be null.");
		//	Assert.AreEqual(_mockFileRenamerService.Object, TestSubject.FileRenamerService, "The FileRenamerService property is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the Logging property can get/set as expected.
		///// </summary>
		//[Test]
		//public void TestLogging()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 		"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.Logging = "a new Logging";
		//	Assert.AreEqual("a new Logging", TestSubject.Logging, 		"The Logging property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 		"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("Logging", PropertyChangedEventCalls[0], 	"The Property that changed is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the Logging property can get/set as expected
		///// when the value is the same.
		///// </summary>
		//[Test]
		//public void TestLogging_SameValueSet()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 		"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.Logging = "a new Logging";
		//	Assert.AreEqual("a new Logging", TestSubject.Logging, 		"The Logging property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 		"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("Logging", PropertyChangedEventCalls[0], 	"The Property that changed is not as expected.");
			
		//	TestSubject.Logging = "a new Logging";
		//	Assert.AreEqual("a new Logging", TestSubject.Logging, 		"The Logging property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 		"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("Logging", PropertyChangedEventCalls[0], 	"The Property that changed is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the ProcessingProgress property can get/set as expected.
		///// </summary>
		//[Test]
		//public void TestProcessingProgress()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 				"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.ProcessingProgress = 50;
		//	Assert.AreEqual(50, TestSubject.ProcessingProgress, 				"The ProcessingProgress property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 				"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("ProcessingProgress", PropertyChangedEventCalls[0],	"The Property that changed is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the ProcessingProgress property can get/set as expected
		///// when the value is the same.
		///// </summary>
		//[Test]
		//public void TestProcessingProgress_SameValueSet()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 				"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.ProcessingProgress = 50;
		//	Assert.AreEqual(50, TestSubject.ProcessingProgress, 				"The ProcessingProgress property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 				"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("ProcessingProgress", PropertyChangedEventCalls[0],	"The Property that changed is not as expected.");
			
		//	TestSubject.ProcessingProgress = 50;
		//	Assert.AreEqual(50, TestSubject.ProcessingProgress, 				"The ProcessingProgress property is not as expected.");
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 				"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("ProcessingProgress", PropertyChangedEventCalls[0],	"The Property that changed is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the FileRenamerProcessCommand property can get as expected.
		///// </summary>
		//[Test]
		//public void TestFileRenamerProcessCommand()
		//{
		//	Assert.IsNotNull(TestSubject.FileRenamerProcessCommand, "The FileRenamerProcessCommand property should not be null.");
		//	Assert.AreEqual(typeof(RelayCommand), TestSubject.FileRenamerProcessCommand.GetType(), "The ICommand instance type is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the ClearCommand property can get as expected.
		///// </summary>
		//[Test]
		//public void TestClearCommand()
		//{
		//	Assert.IsNotNull(TestSubject.ClearCommand, "The ClearCommand property should not be null.");
		//	Assert.AreEqual(typeof(RelayCommand), TestSubject.ClearCommand.GetType(), "The ICommand instance type is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the SelectInputFolderCommand property can get as expected.
		///// </summary>
		//[Test]
		//public void TestSelectInputFolderCommand()
		//{
		//	Assert.IsNotNull(TestSubject.SelectInputFolderCommand, "The SelectInputFolderCommand property should not be null.");
		//	Assert.AreEqual(typeof(RelayCommand), TestSubject.SelectInputFolderCommand.GetType(), "The ICommand instance type is not as expected.");
		//}
		
		#endregion		
		
		#region Test Event Handlers
		
		///// <summary>
		///// Tests that a TrimSetting's property changing event
		///// triggers the FileRenamerViewModel's property changed event, in reaction.
		///// </summary>
		//[Test]
		//public void TestFileRenamerViewModel_PropertyChanged_TrimSettings()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 				"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.TrimSettings.TrimString = "a new trim string";
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 				"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("TrimString", PropertyChangedEventCalls[0], 		"The Property that changed is not as expected.");
		//}
		
		///// <summary>
		///// Tests that a ExtensionModifierSettings's property changing event
		///// triggers the FileRenamerViewModel's property changed event, in reaction.
		///// </summary>
		//[Test]
		//public void TestFileRenamerViewModel_PropertyChanged_ExtensionModifierSettings()
		//{
		//	Assert.AreEqual(0, PropertyChangedEventCalls.Count, 									"There shouldn't have been any calls to OnPropertyChanged yet.");
		//	TestSubject.ExtensionModifierSettings.ExactExtensionString = "a new extension string";
		//	Assert.AreEqual(1, PropertyChangedEventCalls.Count, 									"There should have been 1 call to OnPropertyChanged.");
		//	Assert.AreEqual("ExactExtensionString", PropertyChangedEventCalls[0],					"The Property that changed is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the FileRenamerViewModel handles the FileRenamerService's
		/////	StatusReported event as expected.
		///// </summary>
		//[Test]
		//public void TestFileRenamerViewModel_HandlesStatusReportedEvent()
		//{
		//	//clear current Logging value to begin with
		//	TestSubject.Logging = string.Empty;
			
		//	_mockFileRenamerService.Raise(fileRenamerService => fileRenamerService.ReportStatus += null, new ReportStatusEventArgs("test status"));
		//	Assert.AreEqual("test status", TestSubject.Logging, "The ReportStatus event handler was not handled as expected.");
		//}
		
		///// <summary>
		///// Tests that the FileRenamerViewModel handles the FileRenamerService's
		/////	ProgressReported event as expected.
		///// </summary>
		//[Test]
		//public void TestFileRenamerViewModel_HandlesProgressReportedEvent()
		//{
		//	//clear current ProcessingProgress value to begin with
		//	TestSubject.ProcessingProgress = 0;
			
		//	_mockFileRenamerService.Raise(fileRenamerService => fileRenamerService.ReportProgress += null, new ReportProgressEventArgs(40));
		//	Assert.AreEqual(40, TestSubject.ProcessingProgress, "The ReportProgress event handler is not attached as expected.");
		//}
		
		#endregion
		
		#region Test Command Actions
		
		///// <summary>
		///// Tests that the FileRenamerProcessCommand's Execute
		///// Action is handled as expected.
		///// </summary>
		//[Test]
		//public void TestFileRenamerProcessCommand_Execute()
		//{
		//	//set some random values for Logging/ProcessingProgress/InputFolderPath to begin with
		//	TestSubject.Logging 			= "dummy logging value";
		//	TestSubject.ProcessingProgress 	= 60;
		//	TestSubject.InputFolderPath		= "dummy path";
			
		//	//register an expected call to IFileRenamerService.RenameFiles        
		//	_mockFileRenamerService.Setup(fileRenamerService => fileRenamerService.RenameFiles("dummy path", _trimSettings, _extensionModifierSettings, _casingSettings));
			
		//	TestSubject.FileRenamerProcessCommand.Execute(null);
			
		//	Assert.AreEqual(string.Empty, TestSubject.Logging, 	"The Logging property value is not as expected.");
		//	Assert.AreEqual(0, TestSubject.ProcessingProgress, 	"The ProcessingProgress property value is not as expected.");			
		//}
		
		///// <summary>
		///// Tests that the learCommand's Execute
		///// Action is handled as expected.
		///// </summary>
		//[Test]
		//public void TestClearCommand_Execute()
		//{
		//	//set some random values for Logging/ProcessingProgress to begin with
		//	TestSubject.Logging 			= "dummy logging value";
		//	TestSubject.ProcessingProgress 	= 60;
						
		//	TestSubject.ClearCommand.Execute(null);
			
		//	Assert.AreEqual(string.Empty, TestSubject.Logging, "The Logging property value is not as expected.");
		//	Assert.AreEqual(0, TestSubject.ProcessingProgress, "The ProcessingProgress property value is not as expected.");
		//}
		
		///// <summary>
		///// Tests that the SelectInputFolderCommand's Execute
		///// Action is handled as expected.
		///// </summary>
		//[Test]
		//public void TestSelectInputFolderCommand_Execute()
		//{
		//	//set some random values for InputFolderPath to begin with
		//	TestSubject.InputFolderPath = "dummy path";
			
		//	//register expected call to ISelectInputFolderService.SelectInputFolder
		//	_mockSelectInputFolderService.Setup(selectInputFolderService => selectInputFolderService.SelectInputFolder()).Returns("a new dummy path");
			
		//	TestSubject.SelectInputFolderCommand.Execute(null);
			
		//	Assert.AreEqual("a new dummy path", TestSubject.InputFolderPath, "The InputFolderPath property value is not as expected.");			
		//}
		
		#endregion		
	}
}
