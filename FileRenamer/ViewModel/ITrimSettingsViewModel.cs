using FileRenamer.Model;

namespace FileRenamer.ViewModel
{
	/// <summary>
	/// An interface for view models that provide
	///	file name trim settings.
	/// </summary>
	public interface ITrimSettingsViewModel
	{
		/// <summary>
		/// Whether or not to trim the file name.
		/// </summary>
		bool Trim { get; set; }
		
		/// <summary>
		/// The actual string value that will be trimmed.
		/// </summary>
		string TrimString { get; set; }

		/// <summary>
		/// How the file name trim will be performed.
		/// </summary>
		TrimType TrimType { get; set; }
	}
}
