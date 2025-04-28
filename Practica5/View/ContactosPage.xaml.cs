using Practica5.ViewModel;

namespace Practica5.View;

public partial class ContactosPage : ContentPage
{
	public ContactosPage()
	{
        BindingContext = new ContactosVM();
    }

    private async void OnContactoSeleccionado(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is  Contact contactoSeleccionado)
        {
            await Shell.Current.GoToAsync(nameof(DetalleContactoPage), new Dictionary<string, object>
            {
                { "Contacto", contactoSeleccionado }
            });
        }
      ((CollectionView)sender).SelectedItem = null;
    }
}