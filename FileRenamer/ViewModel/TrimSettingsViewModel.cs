using FileRenamer.Model;

using WPFHelpers.DataBinding;

namespace FileRenamer.ViewModel
{
	/// <summary>
	/// TrimSettings is the default implementation of the ITrimSettingsViewModel interface.
	/// </summary>
	public class TrimSettingsViewModel : BaseNotifyPropertyChanged, ITrimSettingsViewModel
	{
		#region Private Members
		
		private bool _trim;
		private string _trimString;
		private TrimType _trimType;
		
		#endregion
		
		#region Construction
		
		public TrimSettingsViewModel()
		{
			_trimType = TrimType.RemoveExactTrimString;
		}

		#endregion

		#region ITrimSettingsViewModel Members

		/// <summary>
		/// Whether or not to trim the file name.
		/// </summary>
		public bool Trim
		{
			get
			{
				return _trim;
			}
			set
			{
				if (_trim != value)
				{
					_trim = value;
					OnPropertyChanged("Trim");
				}
			}
		}

		/// <summary>
		/// The actual string value that will be trimmed.
		/// </summary>
		public string TrimString
		{
			get
			{
				return _trimString;
			}
			set
			{
				if (_trimString != value)
				{
					_trimString = value;
					OnPropertyChanged("TrimString");
				}
			}
		}

		/// <summary>
		/// How the file name trim will be performed.
		/// </summary>
		public TrimType TrimType
		{
			get 
			{
				return _trimType;
			}
			set 
			{
				if (_trimType != value)
				{
					_trimType = value;
					OnPropertyChanged("TrimType");
				}
			}
		}
		
		#endregion
	}
}
