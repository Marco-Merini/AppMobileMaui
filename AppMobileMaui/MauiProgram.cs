using AppMobileMaui.Data;
using AppMobileMaui.Services;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ProdutosLibrary.Data;
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
                .UseBarcodeReader()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IScannerService, MauiScannerService>();
            builder.Services.AddTransient<IProdutosService, ProdutoService>();
            builder.Services.AddTransient<IPedidosService, PedidoService>();

            return builder.Build();
        }

    }
}