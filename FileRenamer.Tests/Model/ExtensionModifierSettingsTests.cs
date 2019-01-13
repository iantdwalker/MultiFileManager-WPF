using System.ComponentModel;

using NUnit.Framework;

using FileRenamer.Model;
using WPFHelpers.Tests.DataBinding;

namespace FileRenamer.Tests.Model
{
	/// <summary>
	/// Tests the functionality of the ExtensionModifierSettings class. 
	/// </summary>
	[TestFixture]
	public class ExtensionModifierSettingsTests : BaseNotifyPropertyChangedTests<IExtensionModifierSettings>
	{
		#region Private Members

		private IExtensionModifierSettings _extensionModifierSettings;

		#endregion

		#region Setup/Teardown

		[SetUp]
		public void Setup()
		{
			base.SetUp();
			_extensionModifierSettings = new ExtensionModifierSettings();
			((INotifyPropertyChanged)_extensionModifierSettings).PropertyChanged += OnPropertyChanged;
		}

		[TearDown]
		public void Teardown()
		{
			base.TestTearDown();
			((INotifyPropertyChanged)_extensionModifierSettings).PropertyChanged -= OnPropertyChanged;
		}

		#endregion

		#region Constructor Tests

		/// <summary>
		/// Tests the default constructor of the ExtensionModifierSettings class.
		/// </summary>
		[Test]
		public void Constructor_ShouldConstructExtensionModifierSettingsWithExpectedDefaults()
		{
			// Setup
			IExtensionModifierSettings extensionModifierSettings = new ExtensionModifierSettings();

			// Analysis
			Assert.AreEqual(ExtensionType.LowerCaseExtension, extensionModifierSettings.ExtensionType);
		}

		#endregion

		#region IExtensionModifierSettings Tests

		/// <summary>
		/// Tests that the ModifyExtension property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void ModifyExtension_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsFalse(_extensionModifierSettings.ModifyExtension);

			// Test
			_extensionModifierSettings.ModifyExtension = true;

			// Analysis
			Assert.IsTrue(_extensionModifierSettings.ModifyExtension);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("ModifyExtension", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the ModifyExtension property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void ModifyExtension_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsFalse(_extensionModifierSettings.ModifyExtension);

			// Test
			_extensionModifierSettings.ModifyExtension = false;

			// Analysis
			Assert.IsFalse(_extensionModifierSettings.ModifyExtension);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}

		/// <summary>
		/// Tests that the ExactExtensionString property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void ExactExtensionString_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsNull(_extensionModifierSettings.ExactExtensionString);

			// Test
			_extensionModifierSettings.ExactExtensionString = "jpg";

			// Analysis
			Assert.AreEqual("jpg", _extensionModifierSettings.ExactExtensionString);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("ExactExtensionString", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the ExactExtensionString property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void ExactExtensionString_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsNull(_extensionModifierSettings.ExactExtensionString);

			// Test
			_extensionModifierSettings.ExactExtensionString = null;

			// Analysis
			Assert.IsNull(_extensionModifierSettings.ExactExtensionString);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}

		/// <summary>
		/// Tests that the ExtensionType property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void ExtensionType_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.AreEqual(ExtensionType.LowerCaseExtension, _extensionModifierSettings.ExtensionType);

			// Test
			_extensionModifierSettings.ExtensionType = ExtensionType.UpperCaseExtension;

			// Analysis
			Assert.AreEqual(ExtensionType.UpperCaseExtension, _extensionModifierSettings.ExtensionType);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("ExtensionType", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the ExtensionType property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void ExtensionType_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.AreEqual(ExtensionType.LowerCaseExtension, _extensionModifierSettings.ExtensionType);

			// Test
			_extensionModifierSettings.ExtensionType = ExtensionType.LowerCaseExtension;

			// Analysis
			Assert.AreEqual(ExtensionType.LowerCaseExtension, _extensionModifierSettings.ExtensionType);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}

		#endregion
	}
}
