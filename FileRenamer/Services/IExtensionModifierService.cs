using FileRenamer.Model;

namespace FileRenamer.Services
{
	/// <summary>
	/// An interface for objects
	/// that can modify a file name extension.
	/// </summary>
	public interface IExtensionModifierService
	{
		/// <summary>
		/// ModifyFileNameExtension modifies the file name extension.
		/// </summary>
		/// <param name="extension"></param>
		/// <param name="extensionType"></param>
		/// <param name="exactExtension"></param>
		/// <returns>The modified file name extension</returns>
		string ModifyFileNameExtension(string extension, ExtensionType extensionType, string exactExtension);
	}
}
