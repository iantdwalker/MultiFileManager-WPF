using System.Configuration;
using System.Windows;
using System.Windows.Threading;

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

using MultiFileManager.Logic.Model.FileRenamer;
using MultiFileManager.Logic.Services;
using MultiFileManager.Logic.Services.FileRenamer;
using MultiFileManager.Logic.ViewModel.FileRenamer;
using MultiFileManager.View;
using MultiFileManager.Services;

namespace MultiFileManager
{
	/// <summary>
	/// Interaction logic for App.xaml.
	/// </summary>
	public partial class App : Application
	{
		#region Application Event Handlers
		
		/// <summary>
		/// Application_Startup is called when the application first starts up.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			UnityContainer unityContainer = new UnityContainer();
			
			if (ConfigurationManager.GetSection("unity") != null)
            {
				unityContainer.LoadConfiguration();              
            }
			else
			{
				unityContainer.RegisterType<ITrimSettings, 					TrimSettings>();
				unityContainer.RegisterType<IExtensionModifierSettings, 	ExtensionModifierSettings>();
				unityContainer.RegisterType<ICasingSettings, 				CasingSettings>();
				unityContainer.RegisterType<ISelectInputFolderService,		SelectInputFolderService>();
				unityContainer.RegisterType<ITrimService,					TrimService>();
				unityContainer.RegisterType<IModifyExtensionService,		ModifyExtensionService>();
				unityContainer.RegisterType<ICasingService,					CasingService>();
				unityContainer.RegisterType<IFileRenamerService, 			FileRenamerService>();
				unityContainer.RegisterType<IFileRenamerView,				FileRenamerView>();
				unityContainer.RegisterType<IFileRenamerViewModel,			FileRenamerViewModel>();
			}		
						
			MainWindow mainWindow = unityContainer.Resolve<MainWindow>();
        	mainWindow.Show();       	
		}
		
		/// <summary>
		/// Application_DispatcherUnhandledException handles all unhandled exceptions in the application.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			MessageBox.Show(string.Format("An unhandled exception has occurred: {0}\n{1}", new object[] { e.Exception.Message, e.Exception.StackTrace }), "Unhandled Exception", MessageBoxButton.OK, MessageBoxImage.Error);
		}
		
		#endregion
	}
}
