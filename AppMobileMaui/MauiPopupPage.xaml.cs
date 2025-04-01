// MauiPopupPage.xaml.cs in AppMobileMaui/MauiPages
using CommunityToolkit.Maui.Views;

namespace MauiMixBlazorSample.MauiPages;

public partial class MauiPopupPage : Popup
{
    public MauiPopupPage()
    {
        InitializeComponent();
    }

    private void scanner_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        scanner.IsDetecting = false;

        // 👇 Garanta que sempre retorne um valor
        CloseAsync(e.Results.FirstOrDefault()?.Value ?? string.Empty);
    }

    // 👇 Adicione este método para cancelamento manual
    private void CloseButton_Clicked(object sender, EventArgs e)
    {
        CloseAsync(string.Empty);
    }
}