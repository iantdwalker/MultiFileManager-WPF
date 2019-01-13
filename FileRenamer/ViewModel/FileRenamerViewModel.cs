using System;
using System.ComponentModel;
using System.Windows.Input;

using FileRenamer.Model;
using FileRenamer.Services;

using MultiFileManager.Common.Events;
using WPFHelpers.DataBinding;
using WPFHelpers.Services;
using WPFHelpers.Commands;

namespace FileRenamer.ViewModel
{
	/// <summary>
	/// FileRenamerViewModel is the default implementation
	/// of the IFileRenamerViewModel interface.
	/// </summary>
	public class FileRenamerViewModel : BaseNotifyPropertyChanged, IFileRenamerViewModel
	{
		#region Private Members
		
		private string						_inputFolderPath;
		private ITrimSettings 				_trimSettings;
		private IExtensionModifierSettings	_extensionModifierSettings;
		//private ICasingSettings				_casingSettings;
		private string						_logging;
		private int							_processingProgress;
		private ISelectFolderService		_selectFolderService;
		private IFileRenamerService			_fileRenamerService;
		private ICommand					_fileRenamerProcessCommand;
		private ICommand					_clearCommand;
		private ICommand					_selectInputFolderCommand;

		private const string SelectAFolder = "Select a folder of files to rename or insert a path here...";
		private const string LoggingWillAppear = "File renaming process logging will appear here...";

		#endregion

		#region Construction

		/// <summary>
		/// Constructs a new instance of the FileRenamerViewModel with the specified parameters.
		/// </summary>
		/// <param name="trimSettings"></param>
		/// <param name="extensionModifierSettings"></param>
		/// <param name="selectInputFolderService"></param>
		/// <param name="fileRenamerService"></param>
		public FileRenamerViewModel(ITrimSettings trimSettings, IExtensionModifierSettings extensionModifierSettings,
			ISelectFolderService selectFolderService, IFileRenamerService fileRenamerService)	: base()
		{
			if (trimSettings 				== null) throw new ArgumentNullException("trimSettings");
			if (extensionModifierSettings 	== null) throw new ArgumentNullException("extensionModifierSettings");
			if (selectFolderService == null) throw new ArgumentNullException("selectFolderService");
			if (fileRenamerService		 	== null) throw new ArgumentNullException("fileRenamerService");
			
			_trimSettings 				= trimSettings;
			_extensionModifierSettings 	= extensionModifierSettings;
			_selectFolderService		= selectFolderService;
			_fileRenamerService			= fileRenamerService;
						
			//Commands
			_fileRenamerProcessCommand 	= new RelayCommand(param => OnFileRenamerProcessCommandExecute());
			_clearCommand				= new RelayCommand(param => OnClearRequested());		
			_selectInputFolderCommand	= new RelayCommand(param => OnSelectInputFolderRequested());			
			
			//Event handlers
			_fileRenamerService.ReportStatus										+= new EventHandler<ReportStatusEventArgs>(FileRenamerService_StatusReported);
			_fileRenamerService.ReportProgress										+= new EventHandler<ReportProgressEventArgs>(FileRenamerService_ProgressReported);
			((INotifyPropertyChanged)_trimSettings).PropertyChanged 				+= FileRenamerViewModel_PropertyChanged;
			((INotifyPropertyChanged)_extensionModifierSettings).PropertyChanged 	+= FileRenamerViewModel_PropertyChanged;

			InputFolderPath = SelectAFolder;
			Logging			= LoggingWillAppear;
		}
		
		#endregion
		
		#region IFileRenamerViewModel Members		
		
		/// <summary>
		/// A path to the input folder of files.
		/// </summary>
		public string InputFolderPath
		{
			get
			{
				return _inputFolderPath;
			}
			set
			{
				if (_inputFolderPath != value)
				{
					_inputFolderPath = value;
					OnPropertyChanged("InputFolderPath");
				}
			}
		}
		
		/// <summary>
		/// TrimSettings model.
		/// </summary>
		public ITrimSettings TrimSettings
		{
			get
			{
				return _trimSettings;
			}
		}
		
		/// <summary>
		/// Gets the ExtensionModifierSettings model.
		/// </summary>
		public IExtensionModifierSettings ExtensionModifierSettings
		{
			get
			{
				return _extensionModifierSettings;
			}
		}
		
		/// <summary>
		/// Gets the CasingSettings model.
		/// </summary>
		public ICasingSettings CasingSettings
		{
			get
			{
				//return _casingSettings;
				throw new NotImplementedException();
			}
		}
		
		/// <summary>
		/// Gets the SelectFolderService service.
		/// </summary>
		public ISelectFolderService SelectFolderService
		{
			get
			{
				return _selectFolderService;
			}
		}
		
		/// <summary>
		/// Gets the FileRenamerService service.
		/// </summary>
		public IFileRenamerService FileRenamerService
		{
			get
			{
				return _fileRenamerService;
			}
		}
		
		/// <summary>
		/// Gets and sets the logging message.
		/// </summary>
		public string Logging
		{
			get
			{
				return _logging;
			}
			set
			{
				if (_logging != value)
				{
					_logging = value;
					OnPropertyChanged("Logging");
				}
			}
		}
		
		/// <summary>
		/// Gets and sets the percentage value for
		///	progress complete of the Process operation.
		/// </summary>
		public int ProcessingProgress
		{
			get
			{
				return _processingProgress;
			}
			set
			{
				if (_processingProgress != value)
				{
					_processingProgress = value;
					OnPropertyChanged("ProcessingProgress");
				}
			}
		}
		
		/// <summary>
		/// Gets the FileRenamerProcessCommand.
		/// </summary>
		public ICommand FileRenamerProcessCommand
		{
			get
			{
				return _fileRenamerProcessCommand;
			}		
		}
		
		/// <summary>
		/// Gets the ClearCommand.
		/// </summary>
		public ICommand ClearCommand
		{
			get
			{
				return _clearCommand;
			}		
		}
		
		/// <summary>
		/// Gets the SelectInputFolderCommand.
		/// </summary>
		public ICommand SelectInputFolderCommand
		{
			get
			{
				return _selectInputFolderCommand;
			}		
		}
		
		#endregion
		
		#region Private Methods

		private void FileRenamerViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			OnPropertyChanged(e.PropertyName);
		}
		
		private void FileRenamerService_StatusReported(object sender, ReportStatusEventArgs e)
		{
			Logging = string.Format("{0}{1}", new object[] { Logging, e.Status });
		}
		
		private void FileRenamerService_ProgressReported(object sender, ReportProgressEventArgs e)
		{
			ProcessingProgress = e.Progress;
		}
		
		#endregion
		
		#region Private Command Actions

		private void OnFileRenamerProcessCommandExecute()
		{
			Clear();
			_fileRenamerService.RenameFiles(InputFolderPath, TrimSettings, ExtensionModifierSettings, CasingSettings);
		}
		
		private void OnClearRequested()
		{
			Clear();
		}
		
		private void Clear()
		{
			ProcessingProgress	= 0;
			Logging 			= string.Empty;
		}
		
		private void OnSelectInputFolderRequested()
		{
			InputFolderPath = _selectFolderService.SelectFolder("desc", true, Environment.SpecialFolder.Desktop);
		}
		
		#endregion		
	}
}
