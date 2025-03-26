using AppMobileMaui.Data;
using Microsoft.Extensions.Logging;
using ProdutosLibrary.Data;
using CommunityToolkit.Maui;
using ZXing.Net.Maui.Controls;

namespace AppMobileMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseBarcodeReader();

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<IProdutosService, ProdutoService>();
            builder.Services.AddTransient<IPedidosService, PedidoService>();

            return builder.Build();
        }

    }
}
