using CommunityToolkit.Maui;
using Mopups.Hosting;
using InputKit.Shared.Controls;
using UraniumUI;
//using LocalNotifications;
using Syncfusion.Maui.Core.Hosting;

namespace FitnestX;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureMopups()
            .UseUraniumUI()
			.UseUraniumUIMaterial()
            .ConfigureSyncfusionCore()
//#if ANDROID || IOS
//            .UseLocalNotifications(false, false)
//#endif
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

				fonts.AddMaterialIconFonts();
            });

		builder.Services.AddMopupsDialogs();
		return builder.Build();
	}
}
