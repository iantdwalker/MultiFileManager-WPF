using System;

using NUnit.Framework;

using FileRenamer.Model;
using FileRenamer.Services;

namespace FileRenamer.Tests.Services
{
	/// <summary>
	/// Provides test functionality for the CasingService class.
	/// </summary>
	[TestFixture]
	public class CasingServiceTests
	{
		#region Private Members

		private ICaseService _casingService;

		#endregion

		#region Setup/Teardown

		[SetUp]
		public void SetUp()
		{
			_casingService = new CaseService();
		}

		#endregion

		#region ICasingService Tests

		/// <summary>
		/// Tests that the ChangeCase method throws an exception with a null value parameter.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldThrowWithNullValue()
		{
			// Test / Analysis
			Assert.Throws<ArgumentNullException>(delegate
			{
				_casingService.ChangeCase(null, CasingType.UpperCase);
			});
		}

		/// <summary>
		/// Tests that the ChangeCase method throws an exception with an empty value parameter.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldThrowWithEmptyValue()
		{
			// Test / Analysis
			Assert.Throws<ArgumentNullException>(delegate
			{
				_casingService.ChangeCase(string.Empty, CasingType.UpperCase);
			});
		}

		/// <summary>
		/// Tests that the ChangeCase method returns an upper case value if CasingType.UpperCase is specified.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnUpperCaseValueWhenCasingTypeUpperCaseIsSpecified()
		{
			// Data
			var originalValue = "myfile";
			var expectedValue = "MYFILE";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.UpperCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns an upper case extension value if CasingType.UpperCase is specified.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldConvertExtensionToUpperCaseWhenCasingTypeUpperCaseIsSpecified()
		{
			// Data
			var originalValue = "myfile.txt";
			var expectedValue = "MYFILE.TXT";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.UpperCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a lower case value if CasingType.LowerCase is specified.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnLowerCaseValueWhenCasingTypeLowerCaseIsSpecified()
		{
			// Data
			var originalValue = "MYFILE";
			var expectedValue = "myfile";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.LowerCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a lower case extension value if CasingType.LowerCase is specified.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldConvertExtensionToLowerCaseWhenCasingTypeLowerCaseIsSpecified()
		{
			// Data
			var originalValue = "MYFILE.TXT";
			var expectedValue = "myfile.txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.LowerCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words in lower case.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsInLowerCase()
		{
			// Data
			var originalValue = "my file name";
			var expectedValue = "My File Name";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words in upper case.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsInUpperCase()
		{
			// Data
			var originalValue = "MY FILE NAME";
			var expectedValue = "My File Name";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words in mixed case.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsInMixedCase()
		{
			// Data
			var originalValue = "mY fILe nAmE";
			var expectedValue = "My File Name";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words with an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldConvertExtensionWhenCasingTypePascalCaseIsSpecified_WithMultipleWords()
		{
			// Data
			var originalValue = "mY fILe nAmE.TxT";
			var expectedValue = "My File Name.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains one word in lower case.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithOneWordInLowerCase()
		{
			// Data
			var originalValue = "file";
			var expectedValue = "File";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains one word in upper case.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithOneWordInUpperCase()
		{
			// Data
			var originalValue = "FILE";
			var expectedValue = "File";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains one word with an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldConvertExtensionWhenCasingTypePascalCaseIsSpecified_WithOneWord()
		{
			// Data
			var originalValue = "fILe.txt";
			var expectedValue = "File.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains one word with numbers and an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithNumbers()
		{
			// Data
			var originalValue = "file01.txt";
			var expectedValue = "File01.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains one word with numbers, a dash and an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithNumbersAndDash()
		{
			// Data
			var originalValue = "01-file.txt";
			var expectedValue = "01-File.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words with numbers, a dash and an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsNumbersAndDash()
		{
			// Data
			var originalValue = "01-my file.txt";
			var expectedValue = "01-My File.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words with numbers, a dot and an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsNumbersAndDot()
		{
			// Data
			var originalValue = "01.my file.txt";
			var expectedValue = "01.My File.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words with numbers, a space and an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsNumbersAndASpce()
		{
			// Data
			var originalValue = "01 my file.txt";
			var expectedValue = "01 My File.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words with numbers, square brackets and an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsNumbersAndSquareBrackets()
		{
			// Data
			var originalValue = "01-sample [my] file.txt";
			var expectedValue = "01-Sample [My] File.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		/// <summary>
		/// Tests that the ChangeCase method returns a pascal case value if CasingType.PascalCase is specified.
		/// The value contains multiple words with numbers, brackets and an extension.
		/// </summary>
		[Test]
		public void ChangeCase_ShouldReturnPascalCaseValueWhenCasingTypePascalCaseIsSpecified_WithMultipleWordsNumbersAndBrackets()
		{
			// Data
			var originalValue = "01 - sample (my) file.txt";
			var expectedValue = "01 - Sample (My) File.Txt";

			// Test
			var returnedValue = _casingService.ChangeCase(originalValue, CasingType.PascalCase);

			// Analysis
			Assert.IsNotNull(returnedValue);
			Assert.AreEqual(expectedValue, returnedValue);
		}

		#endregion
	}
}
