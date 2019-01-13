using FileRenamer.Model;

namespace FileRenamer.ViewModel
{
	/// <summary>
	/// An interface for view models that provide
	///	file name extension settings.
	/// </summary>
	public interface IExtensionSettingsViewModel
	{
		/// <summary>
		/// Whether or not to modify the file name extension.
		/// </summary>
		bool ModifyExtension { get; set; }
		
		/// <summary>
		/// The actual string extension value (minus the '.') that will be set.
		/// </summary>
		string ExactExtensionString { get; set; }

		/// <summary>
		/// How the file name extension will be set.
		/// </summary>
		ExtensionType ExtensionType { get; set; }
	}
}
