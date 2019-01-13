using System;
using System.Globalization;

using FileRenamer.Model;

namespace FileRenamer.Services
{
	/// <summary>
	/// The default implementation
	/// of the IModifyExtensionService interface.
	/// </summary>
	public class ExtensionModifierService : IExtensionModifierService
	{
		#region IModifyExtensionService Members

		/// <summary>
		/// ModifyFileNameExtension modifies the file name extension.
		/// </summary>
		/// <param name="extension"></param>
		/// <param name="extensionType"></param>
		/// <param name="exactExtension"></param>
		/// <returns>The modified file name extension</returns>
		public string ModifyFileNameExtension(string extension, ExtensionType extensionType, string exactExtension)
		{
			throw new NotImplementedException();
			
			//if (extensionType == ExtensionType.LowerCaseExtension)
			//{		
			//	if (string.IsNullOrEmpty(extension)) throw new ArgumentNullException("extension");
			//	return extension.ToLower(CultureInfo.CurrentCulture);
			//}
			//else if (extensionType == ExtensionType.UpperCaseExtension)
			//{		
			//	if (string.IsNullOrEmpty(extension)) throw new ArgumentNullException("extension");
			//	return extension.ToUpper(CultureInfo.CurrentCulture);
			//}			
			//else if (extensionType == ExtensionType.RemoveExtension)
			//{
			//	return string.Empty;
			//}
			//else if (extensionType == ExtensionType.ExactExtension)
			//{
			//	if (string.IsNullOrEmpty(exactExtension)) throw new ArgumentNullException("exactExtension");
				
			//	if (exactExtension.StartsWith("."))
			//	{
			//		return exactExtension;	
			//	}
			//	else
			//	{
			//		//add the extension dot if it hasn't been entered
			//		return string.Format("{0}{1}", new object[] { ".", exactExtension });
			//	}
			//}
			
			//throw new InvalidOperationException("An unknown enum value for FileNameExtensionType was passed to the ModifyExtensionService.ModifyFileNameExtension method");
		}	
		
		#endregion
	}
}
