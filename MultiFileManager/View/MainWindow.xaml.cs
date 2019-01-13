using System.Windows;
using System.Windows.Controls;

using MultiFileManager.Commands;
using MultiFileManager.Logic.ViewModel.FileRenamer;

namespace MultiFileManager.View
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml.
	/// </summary>
	public partial class MainWindow : Window
	{
		#region Construction
		
		/// <summary>
		/// Default constructor for MainWindow. 
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();			
		}
		
		/// <summary>
		/// MainWindow constructed with a ViewModel instance of IFileRenamerViewModel.
		/// </summary>
		/// <param name="fileRenamerView"></param>
		/// <param name="fileRenamerViewModel"></param>
		public MainWindow(IFileRenamerView fileRenamerView, IFileRenamerViewModel fileRenamerViewModel) : this()
		{
			_tabItemFileRenaming.Content = (UserControl) fileRenamerView;
			
			//we need to re-evaluate CanExecute here as the FileRenamerView XAML class is instantiated before the
			//MainWindow due to Unity IoC. At the time of FileRenamerView XAML class instantiating the ExitCommand
			//CanExecute evaluates to false because the MainWindow has not been created yet.
			ViewCommands.ExitCommand.EvaluateCanExecuteChanged();
		}	
		
		#endregion
	}
}
