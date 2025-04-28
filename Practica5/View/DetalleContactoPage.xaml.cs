namespace Practica5.View;

public partial class DetalleContactoPage : ContentPage
{
	public DetalleContactoPage()
	{
        BindingContext = new DetalleContactoPage();
    }
    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}