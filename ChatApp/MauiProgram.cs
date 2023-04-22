namespace ChatApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Metropolis-Black.otf", "Metropolis Black");
                fonts.AddFont("Metropolis-Ligh.otf", "Metropolis Ligh");
                fonts.AddFont("Metropolis-Medium.otf", "Metropolis Medium");
                fonts.AddFont("Metropolis-Regular.otf", "Metropolis Regular");
            });

		return builder.Build();
	}
}
