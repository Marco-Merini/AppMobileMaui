using Application = Microsoft.Maui.Controls.Application;

namespace AppMobileMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }
    }
}
