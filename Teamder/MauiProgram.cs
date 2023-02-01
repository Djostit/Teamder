using Teamder.Services;

namespace Teamder;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Comfortaa.ttf", "Comfortaa");
			}).UseMauiCommunityToolkit();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		#region View
		builder.Services.AddSingleton<ViewPage>();
        #endregion

        #region ViewModel
        builder.Services.AddTransient<ViewPage>();
        #endregion

        #region Service
		builder.Services.AddTransient<UserService>();
        #endregion
        return builder.Build();
	}
}
