using Onde_Estou_App.ViewModels;

namespace Onde_Estou_App.Views;

public partial class LocalPage : ContentPage
{
    public LocalPage(LocalViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}