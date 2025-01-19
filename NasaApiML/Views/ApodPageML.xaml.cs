using NasaApiML.ViewModels;

namespace NasaApiML.Views;

public partial class ApodPageML : ContentPage
{
	public ApodPageML()
	{
        InitializeComponent();
        BindingContext = new ApodViewModelsML();
    }
}