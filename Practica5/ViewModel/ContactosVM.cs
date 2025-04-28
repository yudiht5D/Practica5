using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Practica5.Model;
using System.Threading.Tasks;

namespace Practica5.ViewModel
{
    internal class ContactosVM : BaseVM
    {
        public static ObservableCollection<Contacto> ListaContactos { get; } = new ObservableCollection<Contacto>
        {

        };

        public ObservableCollection<Contacto> Contactos => ListaContactos;
    }
}
