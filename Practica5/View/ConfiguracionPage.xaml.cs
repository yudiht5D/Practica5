using Practica5.ViewModel;

namespace Practica5.View;

public partial class ConfiguracionPage : ContentPage
{
	public ConfiguracionPage()
	{
       
        BindingContext = new ConfiguracionVM();
    }
}