using System.Windows.Input;

using FileRenamer.Model;
using FileRenamer.Services;
using WPFHelpers.Services;

namespace FileRenamer.ViewModel
{
	/// <summary>
	/// IFileRenamerViewModel declares the methods and properties
	///	for view model objects of the file renamer view.
	/// </summary>
	public interface IFileRenamerViewModel
	{
		/// <summary>
		/// A path to the input folder of files.
		/// </summary>
		string InputFolderPath { get; set; }
		
		/// <summary>
		/// TrimSettings model.
		/// </summary>
		ITrimSettings TrimSettings { get; }
		
		/// <summary>
		/// Gets the ExtensionModifierSettings model.
		/// </summary>
		IExtensionModifierSettings ExtensionModifierSettings { get; }
		
		/// <summary>
		/// Gets the SelectFolderService service.
		/// </summary>
		ISelectFolderService SelectFolderService { get; }
		
		/// <summary>
		/// Gets the FileRenamerService service.
		/// </summary>
		IFileRenamerService FileRenamerService { get; }
		
		/// <summary>
		/// Gets and sets the logging message.
		/// </summary>
		string Logging { get; set; }
		
		/// <summary>
		/// Gets and sets the percentage value for
		///	progress complete of the Process operation.
		/// </summary>
		int ProcessingProgress { get; set; }
		
		/// <summary>
		/// Gets the FileRenamerProcessCommand.
		/// </summary>
		ICommand FileRenamerProcessCommand { get; }
		
		/// <summary>
		/// Gets the ClearCommand.
		/// </summary>
		ICommand ClearCommand { get; }
		
		/// <summary>
		/// Gets the SelectInputFolderCommand.
		/// </summary>
		ICommand SelectInputFolderCommand { get; }
	}
}
