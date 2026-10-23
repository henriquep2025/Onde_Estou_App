using Microsoft.Extensions.Logging;
using Onde_Estou_App.Services;
using Onde_Estou_App.ViewModels;
using Onde_Estou_App.Views;

namespace Onde_Estou_App
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<LocalPage>();
            builder.Services.AddTransient<LocalViewModel>();
            builder.Services.AddTransient<IGeoService, GeoService>();

            return builder.Build();
        }
    }
}
