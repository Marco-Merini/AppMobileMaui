// MauiPopupPage.xaml.cs in AppMobileMaui/MauiPages
using CommunityToolkit.Maui.Views;
using ZXing.Net.Maui;

namespace MauiMixBlazorSample.MauiPages;

public partial class MauiPopupPage : Popup
{
    public MauiPopupPage()
    {
        InitializeComponent();

        scanner.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.All,
            AutoRotate = true,
            Multiple = true
        };
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