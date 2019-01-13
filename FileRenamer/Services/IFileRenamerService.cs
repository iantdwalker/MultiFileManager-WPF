using System;

using FileRenamer.Model;
using MultiFileManager.Common.Events;

namespace FileRenamer.Services
{
	/// <summary>
	/// An interface for services
	/// that can rename files.
	/// </summary>
	public interface IFileRenamerService
	{
		/// <summary>
		/// Rename all the files contained under the specified path using
		/// the specified settings.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="trimSettings"></param>
		/// <param name="extensionModifierSettings"></param>
		/// <param name="casingSettings"></param>
		void RenameFiles(string path, ITrimSettings trimSettings, IExtensionModifierSettings extensionModifierSettings, ICasingSettings casingSettings);
		
		/// <summary>
		/// An event for reporting the status of the file renaming service operation.
		/// </summary>
		event EventHandler<ReportStatusEventArgs> ReportStatus;

		/// <summary>
		/// An event for reporting the progress of the file renaming service operation.
		/// </summary>
		event EventHandler<ReportProgressEventArgs> ReportProgress;
	}
}
