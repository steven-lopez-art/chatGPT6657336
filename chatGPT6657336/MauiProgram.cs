using chatGPT6657336.Services;
using chatGPT6657336.ViewModels;
using chatGPT6657336.Views;
using Microsoft.Extensions.Logging;

namespace chatGPT6657336
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

            builder.Services.AddSingleton<IOpenIAService, OpenIAService>();

            builder.Services.AddTransient<ConversationViewModel>();
            builder.Services.AddTransient<ConversationView>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
