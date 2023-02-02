using FitnestX.Views;
using UraniumUI.Material.Resources;

namespace FitnestX;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //Register Syncfusion license
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTAyNzY5NUAzMjMwMmUzNDJlMzBMMk5oQnJodGZweGlCcUh2RHBEdWJxT2w0NGozWkIzNzdQTlhQSzYrVnJVPQ==");
        
        MainPage = new GettingStartedView();
		//MainPage = new AppShell();
	}
}
