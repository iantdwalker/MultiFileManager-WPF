using System;
using System.Globalization;
using System.IO;

using FileRenamer.Model;
using MultiFileManager.Common.Events;

namespace FileRenamer.Services
{
	/// <summary>
	/// Default implementation of the
	///	IFileRenamerService interface.
	/// </summary>
	public class FileRenamerService : IFileRenamerService
	{
		#region Private Members		

		//private ITrimService				_trimService;
		//private IModifyExtensionService 	_modifyExtensionService;
		//private ICasingService				_casingService;
		//private IDirectoryInfoWrapper		_directoryInfoWrapper;

		#endregion

		#region Construction

		///// <summary>
		///// Constructs an instance of the FileRenamerService class.
		///// </summary>
		///// <param name="trimService"></param>
		///// <param name="modifyExtension"></param>
		///// <param name="casingService"></param>
		///// <param name="directoryInfoWrapper"></param>
		//public FileRenamerService(ITrimService trimService, IModifyExtensionService modifyExtensionService,
		//	ICasingService casingService, IDirectoryInfoWrapper directoryInfoWrapper)
		//{
		//	if (trimService				== null) throw new ArgumentNullException("trimService");
		//	if (modifyExtensionService 	== null) throw new ArgumentNullException("modifyExtensionService");
		//	if (casingService 			== null) throw new ArgumentNullException("casingService");
		//	if (directoryInfoWrapper 	== null) throw new ArgumentNullException("directoryInfoWrapper");

		//	_trimService				= trimService;
		//	_modifyExtensionService		= modifyExtensionService;
		//	_casingService				= casingService;
		//	_directoryInfoWrapper 		= directoryInfoWrapper;
		//}		

		#endregion

		#region IFileRenamerService Members

		/// <summary>
		/// Rename all the files contained under the specified path using
		/// the specified settings.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="trimSettings"></param>
		/// <param name="extensionModifierSettings"></param>
		/// <param name="casingSettings"></param>
		public void RenameFiles(string path, ITrimSettings trimSettings, IExtensionModifierSettings extensionModifierSettings, ICasingSettings casingSettings)
		{
			throw new NotImplementedException();
			//if (string.IsNullOrEmpty(path)) 			throw new ArgumentNullException("path");
			//if (trimSettings 				== null) 	throw new ArgumentNullException("trimSettings");
			//if (extensionModifierSettings 	== null) 	throw new ArgumentNullException("extensionModifierSettings");
			//if (casingSettings 				== null) 	throw new ArgumentNullException("casingSettings");
			
			//_directoryInfoWrapper.SetDirectoryPath(path);
			//if (_directoryInfoWrapper.Exists)
			//{
			//	IFileInfoWrapper[] files;
				
				//***uncomment once recursive and file type filter options have been added
				//ReplaceUnderscoresWithSpace??
//					if (fileRenamerOptions.Recursive)
//					{
//						if (fileRenamerOptions.FileTypeFilter != null)
//						{
//							files = fileDirectory.GetFiles(string.Format("*.{0}", fileRenamerOptions.FileTypeFilter.FileTypeExtension), SearchOption.AllDirectories);
//						}
//						else
//						{
//							files = fileDirectory.GetFiles("*.*", SearchOption.AllDirectories);
//						}
//					}
				//else 
				//{
//						if (fileRenamerOptions.FileTypeFilter != null)
//						{
//							files = fileDirectory.GetFiles(string.Format("*.{0}", fileRenamerOptions.FileTypeFilter.FileTypeExtension), SearchOption.TopDirectoryOnly);
//						}
//						else
//						{
						//files = _directoryInfoWrapper.GetFiles("*.*", SearchOption.TopDirectoryOnly);
				//}
				//}
				//***uncomment once recursive and file type filter options have been added

			//	OnReportStatus(string.Format("{0} file(s) will be processed in total.\n", new object[] { files.Length }));

			//	for (int x = 0; x < files.Length; x++)
			//	{
			//		var file				= files[x];
			//		var	originalFileName	= file.Name;					
					
			//		RenameFile(file, trimSettings, extensionModifierSettings, casingSettings, path);
					
			//		var counter 					= x + 1;
			//		var runningPercentageComplete 	= ((int)(x / (decimal)files.Length * 100));
			//		OnReportProgress(runningPercentageComplete);
			//		OnReportStatus(string.Format("{0}: Finished renaming file: '{1}'. The new file name is: '{2}'.\n", new object[] { counter.ToString(CultureInfo.CurrentCulture), originalFileName, file.Name }));
			//	}

			//	OnReportProgress(100);				
			//}
			//else
			//{
			//	throw new InvalidOperationException("The directory path supplied cannot be found.");
			//}
		}

		/// <summary>
		/// An event for reporting the status of the file renaming service operation.
		/// </summary>
		public event EventHandler<ReportStatusEventArgs> ReportStatus;

		/// <summary>
		/// An event for reporting the progress of the file renaming service operation.
		/// </summary>
		public event EventHandler<ReportProgressEventArgs> ReportProgress;
		
		#endregion
		
		#region Protected Members
		
		///// <summary>
		///// OnReportStatus fires the ReportStatus event.
		///// </summary>
		///// <param name="status"></param>
		//protected void OnReportStatus(string status)
		//{ 
		//	if (ReportStatus != null) 
		//    {
		//		ReportStatus(this, new ReportStatusEventArgs(status));
		//    } 
		//}
		
		///// <summary>
		///// OnReportProgress fires the ReportProgress event.
		///// </summary>
		///// <param name="progress"></param>
		//protected void OnReportProgress(int progress)
		//{ 
		//	if (ReportProgress != null) 
		//    {
		//		ReportProgress(this, new ReportProgressEventArgs(progress));
		//    } 
		//}

		#endregion
		
		#region Private Methods
		
		//private void RenameFile(IFileInfoWrapper file, ITrimSettings trimSettings,
		//	IExtensionModifierSettings extensionModifierSettings, ICasingSettings casingSettings, string path)
		//{			
		//	var fileNameOnly = file.Name;
		//	if (file.Extension != string.Empty)
		//	{
		//		fileNameOnly = file.Name.Substring(0, file.Name.IndexOf(file.Extension));
		//	}
			
		//	//Trim the file name?
		//	if (trimSettings.Trim)
		//	{
		//		fileNameOnly = _trimService.TrimFileName(fileNameOnly, trimSettings.TrimType, trimSettings.TrimString);				
		//	}
			
		//	//Modify the file's extension?
		//	string newExtension = null;
		//	if (extensionModifierSettings.ModifyExtension)
		//	{
		//		newExtension = _modifyExtensionService.ModifyFileNameExtension(file.Extension,
		//		                                                        extensionModifierSettings.ExtensionType,
		//		                                                        extensionModifierSettings.ExactExtensionString);
		//	}
		//	else
		//	{
		//		newExtension = file.Extension;
		//	}
			
		//	//Modify the file name's casing?
		//	if (casingSettings.ModifyCase)
		//	{
		//		fileNameOnly = _casingService.ChangeFileNameCase(fileNameOnly, casingSettings.CasingType);
		//	}
			
		//	//Finalise and commit the new file name
		//	file.MoveTo(string.Format("{0}\\{1}{2}", new object[] { path, fileNameOnly, newExtension }));
		//}
		
		#endregion
	}
}
