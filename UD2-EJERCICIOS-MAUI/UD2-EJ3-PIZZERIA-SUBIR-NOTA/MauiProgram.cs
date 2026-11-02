using Microsoft.Extensions.Logging;
using UD2_EJ3_PIZZERIA_SUBIR_NOTA.Views;

namespace UD2_EJ3_PIZZERIA_SUBIR_NOTA
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

            // Registrar rutas
            Routing.RegisterRoute("typeSelection", typeof(TypeSelectionPage));
            Routing.RegisterRoute("personalization", typeof(PersonalizationPage));
            Routing.RegisterRoute("delivery", typeof(DeliveryPage));

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
