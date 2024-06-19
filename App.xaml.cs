using MauiApp1.Services;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ILibroServiceJR, LibroServiceJR>();

            MainPage = new AppShell();
        }
    }
}
