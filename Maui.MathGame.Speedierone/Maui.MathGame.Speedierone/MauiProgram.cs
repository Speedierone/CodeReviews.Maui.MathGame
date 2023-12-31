using Maui.MathGame.Speedierone.Data;
using Microsoft.Extensions.Logging;

namespace Maui.MathGame.Speedierone
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Pacifico-Regular.ttf", "PacificoRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "game.db");

            builder.Services.AddSingleton(s =>
            new GameRepository(dbPath));

            return builder.Build();
        }
    }
}
