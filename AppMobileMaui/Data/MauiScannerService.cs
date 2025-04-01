using CommunityToolkit.Maui.Views;
using MauiMixBlazorSample.MauiPages;
using ProdutosLibrary;
using ProdutosLibrary.Data;

namespace AppMobileMaui.Services;

public class MauiScannerService : IScannerService
{
    public async Task<string> ScanAsync()
    {
        try
        {
            if (Application.Current?.MainPage == null)
                throw new InvalidOperationException("MainPage não inicializado");

            var popup = new MauiPopupPage();

            // 👇 Adicione await e verifique o resultado
            var result = await Application.Current.MainPage.ShowPopupAsync(popup) as string;

            return result ?? string.Empty;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no scanner: {ex}");
            return string.Empty;
        }
    }
}