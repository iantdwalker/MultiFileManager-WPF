using FileRenamer.Model;

using WPFHelpers.DataBinding;

namespace FileRenamer.ViewModel
{
	/// <summary>
	///  The default implementation of the ICaseSettingsViewModel interface.
	/// </summary>
	public class CaseSettingsViewModel : BaseNotifyPropertyChanged, ICaseSettingsViewModel
	{
		#region Private Members
		
		private bool _modifyCase;
		private CaseType _caseType;

		#endregion

		#region Construction

		public CaseSettingsViewModel()
		{
			_caseType = CaseType.PascalCase;
		}

		#endregion

		#region ICaseSettingsViewModel Members

		/// <summary>
		/// Whether or not to modify the file name's case.
		/// </summary>
		public bool ModifyCase
		{
			get
			{
				return _modifyCase;
			}
			set
			{
				if (_modifyCase != value)
				{
					_modifyCase = value;
					OnPropertyChanged("ModifyCase");
				}
			}
		}

		/// <summary>
		/// How the file name case will be set.
		/// </summary>
		public CaseType CaseType
		{
			get
			{
				return _caseType;
			}
			set
			{
				if (_caseType != value)
				{
					_caseType = value;
					OnPropertyChanged("CaseType");
				}
			}
		}
		
		#endregion
	}
}
