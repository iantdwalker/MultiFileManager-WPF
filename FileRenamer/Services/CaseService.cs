using System;

using FileRenamer.Model;
using System.Globalization;
using System.Threading;

namespace FileRenamer.Services
{
	/// <summary>
	/// The default implementation of the ICaseService interface.
	/// </summary>
	public class CaseService : ICaseService
	{
		#region Private Members

		private TextInfo _textInfo;

		#endregion

		#region ICaseService Members

		/// <summary>
		/// Modify the case of an input string and return the new value.
		/// </summary>
		/// <param name="value"></param>
		/// <param name="caseType"></param>
		/// <returns>The new string value with the CaseType applied</returns>
		public string ModifyCase(string value, CaseType caseType)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentNullException("value");
			}

			if (caseType == CaseType.UpperCase)
			{
				return value.ToUpper();
			}
			else if (caseType == CaseType.LowerCase)
			{
				return value.ToLower();
			}
			else if (caseType == CaseType.PascalCase)
			{
				return TextInfo.ToTitleCase(value.ToLower());
			}

			throw new InvalidOperationException("An unknown enum value for CaseType was passed to the CasingService.ModifyCase method");			
		}

		#endregion

		#region Private Members

		private TextInfo TextInfo
		{
			get
			{
				if (_textInfo == null)
				{
					_textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
				}

				return _textInfo;
			}
		}

		#endregion
	}
}
