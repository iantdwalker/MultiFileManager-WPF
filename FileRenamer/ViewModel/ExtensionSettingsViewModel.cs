using FileRenamer.Model;

using WPFHelpers.DataBinding;

namespace FileRenamer.ViewModel
{
	/// <summary>
	/// The default implementation of the IExtensionSettingsViewModel interface.
	/// </summary>
	public class ExtensionSettingsViewModel : BaseNotifyPropertyChanged, IExtensionSettingsViewModel
	{
		#region Private Members
		
		private bool _modifyExtension;
		private string _exactExtensionString;
		private ExtensionType _extensionType;
		
		#endregion
		
		#region Construction
		
		public ExtensionSettingsViewModel()
		{
			_extensionType = ExtensionType.LowerCaseExtension;
		}

		#endregion

		#region IExtensionSettingsViewModel Members

		/// <summary>
		/// Whether or not to modify the file name extension.
		/// </summary>
		public bool ModifyExtension
		{
			get
			{
				return _modifyExtension;
			}
			set
			{
				if (_modifyExtension != value)
				{
					_modifyExtension = value;
					OnPropertyChanged("ModifyExtension");
				}
			}
		}

		/// <summary>
		/// The actual string extension value (minus the '.') that will be set.
		/// </summary>
		public string ExactExtensionString
		{
			get
			{
				return _exactExtensionString;
			}
			set
			{
				if (_exactExtensionString != value)
				{
					_exactExtensionString = value;
					OnPropertyChanged("ExactExtensionString");
				}
			}
		}

		/// <summary>
		/// How the file name extension will be set.
		/// </summary>
		public ExtensionType ExtensionType
		{
			get 
			{
				return _extensionType;
			}
			set 
			{
				if (_extensionType != value)
				{
					_extensionType = value;
					OnPropertyChanged("ExtensionType");
				}
			}
		}
		
		#endregion
	}
}
