using Practica5.View;
namespace Practica5.View;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
   
	}


    private async void IrListaContactos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContactosPage());
    }

    private async void IrCrearContacto(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CrearContactoPage());
    }

    private async void IrConfiguracion(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConfiguracionPage());
    }
}