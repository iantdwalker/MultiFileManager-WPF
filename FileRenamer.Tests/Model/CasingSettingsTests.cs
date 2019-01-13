using System.ComponentModel;

using NUnit.Framework;

using FileRenamer.Model;
using WPFHelpers.Tests.DataBinding;

namespace FileRenamer.Tests.Model
{
	/// <summary>
	/// Tests the functionality of the CasingSettings class. 
	/// </summary>
	[TestFixture]
	public class CasingSettingsTests : BaseNotifyPropertyChangedTests<ICasingSettings>
	{
		#region Private Members

		private ICasingSettings _casingSettings;

		#endregion

		#region Setup/Teardown

		[SetUp]
		public void Setup()
		{
			base.SetUp();
			_casingSettings = new CasingSettings();
			((INotifyPropertyChanged)_casingSettings).PropertyChanged += OnPropertyChanged;
		}

		[TearDown]
		public void Teardown()
		{
			base.TestTearDown();
			((INotifyPropertyChanged)_casingSettings).PropertyChanged -= OnPropertyChanged;
		}		
		
		#endregion
		
		#region Constructor Tests
		
		/// <summary>
		/// Tests the default constructor of the CasingSettings class.
		/// </summary>
		[Test]
		public void Constructor_ShouldConstructCasingSettingsWithExpectedDefaults()
		{
			// Setup
			ICasingSettings casingSettings = new CasingSettings();

			// Analysis
			Assert.AreEqual(CasingType.PascalCase, casingSettings.CasingType);
		}
		
		#endregion
		
		#region ICasingSettings Tests
		
		/// <summary>
		/// Tests that the ModifyCase property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void ModifyCase_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsFalse(_casingSettings.ModifyCase);

			// Test
			_casingSettings.ModifyCase = true;

			// Analysis
			Assert.IsTrue(_casingSettings.ModifyCase);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("ModifyCase", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the ModifyCase property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void ModifyCase_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.IsFalse(_casingSettings.ModifyCase);

			// Test
			_casingSettings.ModifyCase = false;

			// Analysis
			Assert.IsFalse(_casingSettings.ModifyCase);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}

		/// <summary>
		/// Tests that the CasingType property will fire PropertyChanged
		/// events when the value changes.
		/// </summary>
		[Test]
		public void CasingType_ShouldFirePropertyChangedEventWhenSetToNewValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.AreEqual(CasingType.PascalCase, _casingSettings.CasingType);

			// Test
			_casingSettings.CasingType = CasingType.LowerCase;

			// Analysis
			Assert.AreEqual(CasingType.LowerCase, _casingSettings.CasingType);
			Assert.AreEqual(1, PropertyChangedEventCalls.Count);
			Assert.AreEqual("CasingType", PropertyChangedEventCalls[0]);
		}

		/// <summary>
		/// Tests that the CasingType property will not fire PropertyChanged
		/// events when the value changes to the same value.
		/// </summary>
		[Test]
		public void CasingType_ShouldNotFirePropertyChangedEventWhenSetToSameValue()
		{
			// Setup
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
			Assert.AreEqual(CasingType.PascalCase, _casingSettings.CasingType);

			// Test
			_casingSettings.CasingType = CasingType.PascalCase;

			// Analysis
			Assert.AreEqual(CasingType.PascalCase, _casingSettings.CasingType);
			Assert.AreEqual(0, PropertyChangedEventCalls.Count);
		}
		
		#endregion
	}
}
