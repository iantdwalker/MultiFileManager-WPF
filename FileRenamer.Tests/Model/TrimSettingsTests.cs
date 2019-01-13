using System.ComponentModel;

using NUnit.Framework;

using FileRenamer.Model;
using WPFHelpers.Tests.DataBinding;

namespace FileRenamer.Tests.Model
{
	/// <summary>
	/// Tests the functionality of the TrimSettings class. 
	/// </summary>
	[TestFixture]
	public class TrimSettingsTests : BaseNotifyPropertyChangedTests<ITrimSettings>
	{
		#region Private Members

		private ITrimSettings _trimSettings;

		#endregion

		#region Setup/Teardown

		[SetUp]
		public void Setup()
		{
			base.SetUp();
			_trimSettings = new TrimSettings();
			((INotifyPropertyChanged)_trimSettings).PropertyChanged += OnPropertyChanged;
		}

		[TearDown]
		public void Teardown()
		{
			base.TestTearDown();
			((INotifyPropertyChanged)_trimSettings).PropertyChanged -= OnPropertyChanged;
		}

		#endregion

		#region Constructor Tests

		/// <summary>
		/// Tests the default constructor of the TrimSettings class.
		/// </summary>
		[Test]
		public void Constructor_ShouldConstructTrimSettingsWithExpectedDefaults()
		{
			// Setup
			ITrimSettings trimSettings = new TrimSettings();

			// Analysis
			Assert.AreEqual(TrimType.RemoveExactTrimString, trimSettings.TrimType);
		}

		#endregion

		#region ITrimSettings Tests

		/// <summary>
		/// Tests that the Trim property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void Trim_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsFalse(_trimSettings.Trim);

			// Test
			_trimSettings.Trim = true;

			// Analysis
			Assert.IsTrue(_trimSettings.Trim);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("Trim", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the Trim property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void Trim_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsFalse(_trimSettings.Trim);

			// Test
			_trimSettings.Trim = false;

			// Analysis
			Assert.IsFalse(_trimSettings.Trim);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}

		/// <summary>
		/// Tests that the TrimString property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void TrimString_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsNull(_trimSettings.TrimString);

			// Test
			_trimSettings.TrimString = "jpg";

			// Analysis
			Assert.AreEqual("trim here", _trimSettings.TrimString);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("TrimString", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the TrimString property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void TrimString_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsNull(_trimSettings.TrimString);

			// Test
			_trimSettings.TrimString = null;

			// Analysis
			Assert.IsNull(_trimSettings.TrimString);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}

		/// <summary>
		/// Tests that the TrimType property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void TrimType_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.AreEqual(TrimType.RemoveExactTrimString, _trimSettings.TrimType);

			// Test
			_trimSettings.TrimType = TrimType.TrimAfterTrimString;

			// Analysis
			Assert.AreEqual(TrimType.TrimAfterTrimString, _trimSettings.TrimType);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("TrimType", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the TrimType property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void TrimType_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.AreEqual(TrimType.RemoveExactTrimString, _trimSettings.TrimType);

			// Test
			_trimSettings.TrimType = TrimType.RemoveExactTrimString;

			// Analysis
			Assert.AreEqual(TrimType.RemoveExactTrimString, _trimSettings.TrimType);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}

		#endregion
	}
}
