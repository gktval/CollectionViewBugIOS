using Microsoft.Extensions.Logging;

namespace ScrollBarBug;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

//The handler will only be called if the target platform is iOS
#if IOS
       EntryHandler.AddDone();
		SearchBarHandler.AddDone();
#endif



#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
