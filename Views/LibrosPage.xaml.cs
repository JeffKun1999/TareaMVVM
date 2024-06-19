using MauiApp1.ViewModel;
using MauiApp1.Services;
namespace MauiApp1.Views;

public partial class LibrosPage : ContentPage
{
    private readonly  LibroViewModel _viewModel;
    public LibrosPage()
	{
		InitializeComponent();
        _viewModel = new LibroViewModel();
        var LibroServiceJR = DependencyService.Get<ILibroServiceJR>();
        var libros = LibroServiceJR.ObtenerLibro();
        _viewModel.Libros = libros;
        BindingContext = _viewModel;
    }
}