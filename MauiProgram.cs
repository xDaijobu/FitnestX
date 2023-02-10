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
        List<(string, string)> poppinsFonts = new List<(string, string)>()
        {
			("Poppins-Bold.ttf", "PoppinsBold"),
			("Poppins-BoldItalic.ttf", "PoppinsBoldItalic"),
			("Poppins-Italic.ttf", "PoppinsItalic"),
			("Poppins-Light.ttf", "PoppinsLight"),
			("Poppins-LightItalic.ttf", "PoppinsLightItalic"),
			("Poppins-Medium.ttf", "PoppinsMedium"),
			("Poppins-MediumItalic.ttf", "PoppinsMediumItalic"),
			("Poppins-Regular.ttf", "PoppinsRegular"),
			("Poppins-SemiBold.ttf", "PoppinsSemiBold"),
			("Poppins-SemiBoldItalic.ttf", "PoppinsSemiBoldItalic"),
        };
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

				foreach(var font in poppinsFonts)
					fonts.AddFont(font.Item1, font.Item2);

				fonts.AddMaterialIconFonts();
            });

		builder.Services.AddMopupsDialogs();
		return builder.Build();
	}
}
