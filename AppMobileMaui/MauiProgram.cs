﻿using AppMobileMaui.Data;
using Microsoft.Extensions.Logging;
using ProdutosLibrary.Data;

namespace AppMobileMaui
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<IProdutosService, ProdutoService>();
            builder.Services.AddTransient<IPedidosService, PedidoService>();

            return builder.Build();
        }

    }
}
