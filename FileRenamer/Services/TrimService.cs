using System;

using FileRenamer.Model;

namespace FileRenamer.Services
{
	/// <summary>
	/// The default implementation of the ITrimService interface.
	/// </summary>
	public class TrimService : ITrimService
	{
		#region ITrimService Members

		/// <summary>
		/// Trim the file name.
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="trimType"></param>
		/// <param name="trimString"></param>
		/// <returns>The new file name after trimming has been applied</returns>
		public string TrimFileName(string fileName, TrimType trimType, string trimString)
		{
			throw new NotImplementedException();
			
			//if (string.IsNullOrEmpty(fileName)) 	throw new ArgumentNullException("fileName");
			//if (string.IsNullOrEmpty(trimString)) 	throw new ArgumentNullException("trimString");
			
			//if (trimType == TrimType.RemoveExactTrimString)
			//{
			//	//remove trim string itself
			//	var trimStringStartIndex = fileName.IndexOf(trimString, 0, StringComparison.CurrentCultureIgnoreCase);
			//	if (trimStringStartIndex >= 0)
			//	{						
			//		return fileName.Remove(trimStringStartIndex, trimString.Length);
			//	}
			//	else
			//	{
			//		return fileName;
			//	}
			//}
			//else if (trimType == TrimType.TrimBeforeTrimString)
			//{
			//	//remove all chars before the trim string
			//	var trimStringStartIndex = fileName.IndexOf(trimString, 0, StringComparison.CurrentCultureIgnoreCase);
			//	if (trimStringStartIndex >= 0)
			//	{					
			//		var desiredLength = fileName.Length - trimStringStartIndex;
			//		return fileName.Substring(trimStringStartIndex, desiredLength);
			//	}
			//	else
			//	{
			//		return fileName;
			//	}
			//}
			//else if (trimType == TrimType.TrimAfterTrimString)
			//{
			//	//remove all chars after the trim string
			//	var trimStringLength		= trimString.Length;
			//	var trimStringStartIndex	= fileName.IndexOf(trimString, 0, StringComparison.CurrentCultureIgnoreCase);
			//	if (trimStringStartIndex >= 0)
			//	{				
			//		var length = trimStringStartIndex + trimStringLength;
			//		return fileName.Substring(0, length);
			//	}
			//	else
			//	{
			//		return fileName;
			//	}
			//}			
			
			//throw new InvalidOperationException("An unknown enum value for FileNameTrimType was passed to the TrimService.TrimFileName method");
		}
		
		#endregion		
	}
}
