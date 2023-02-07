using FitnestX.Views;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using UraniumUI.Material.Resources;
using Application = Microsoft.Maui.Controls.Application;

namespace FitnestX;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //Register Syncfusion license
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTAyNzY5NUAzMjMwMmUzNDJlMzBMMk5oQnJodGZweGlCcUh2RHBEdWJxT2w0NGozWkIzNzdQTlhQSzYrVnJVPQ==");

        App.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Pan);
        MainPage = new GettingStartedView();
		//MainPage = new AppShell();
	}
}
