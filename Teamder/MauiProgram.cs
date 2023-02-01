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
		RegisterViewsAndViewModels(builder.Services);
        #region Service
        #endregion
        return builder.Build();
	}

    static void RegisterViewsAndViewModels(in IServiceCollection services)
	{
        services.AddSingleton<SignInPage, SingInVM>();
    }
}
