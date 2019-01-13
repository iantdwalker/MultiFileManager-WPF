using FileRenamer.Model;

namespace FileRenamer.ViewModel
{
	/// <summary>
	///	An interface for view models that provide
	///	file name case settings.
	/// </summary>
	public interface ICaseSettingsViewModel
	{
		/// <summary>
		/// Whether or not to modify the file name's case.
		/// </summary>
		bool ModifyCase { get; set; }
		
		/// <summary>
		/// How the file name case will be set.
		/// </summary>
		CaseType CaseType { get; set; }
	}
}
