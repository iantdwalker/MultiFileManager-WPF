using System.Windows.Controls;

using FileRenamer.ViewModel;

namespace FileRenamer.View
{
	/// <summary>
	/// Interaction logic for FileRenamerView.xaml.
	/// </summary>
	public partial class FileRenamerView : UserControl, IFileRenamerView
	{
		#region Construction
		
		/// <summary>
		/// FileRenamerView is the default constructor for
		/// the FileRenamerView XAML control.
		/// </summary>
		public FileRenamerView()
		{
			InitializeComponent();			
		}
		
		/// <summary>
		/// FileRenamerView constructed with a ViewModel instance of IFileRenamerViewModel. 
		/// </summary>
		/// <param name="viewModel"></param>
		public FileRenamerView(IFileRenamerViewModel viewModel) : this()
		{
		    this.DataContext = viewModel;		    
		}	
		
		#endregion		
	}
}
