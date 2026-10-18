
using SoporteTecnicoEquipos.Models;

namespace SoporteTecnicoEquipos
{
    public partial class ClientesPage : ContentPage
    {
        public ClientesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            ClientesCollectionView.ItemsSource = null;
            ClientesCollectionView.ItemsSource = App.Servicio.Clientes;
        }

        private async void OnGuardarClienteClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text?.Trim() ?? "";
            string telefono = TelefonoEntry.Text?.Trim() ?? "";
            string correo = CorreoEntry.Text?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(correo))
            {
                await DisplayAlert(
                    "Campos obligatorios",
                    "Completa el nombre, teléfono y correo del cliente.",
                    "Aceptar");
                return;
            }

            if (!correo.Contains('@') || !correo.Contains('.'))
            {
                await DisplayAlert(
                    "Correo no válido",
                    "Escribe un correo electrónico válido.",
                    "Aceptar");
                return;
            }

            App.Servicio.AgregarCliente(new Cliente
            {
                Nombre = nombre,
                Telefono = telefono,
                Correo = correo
            });

            ActualizarLista();

            await DisplayAlert(
                "Cliente guardado",
                "El cliente se registró correctamente.",
                "Aceptar");

            NombreEntry.Text = string.Empty;
            TelefonoEntry.Text = string.Empty;
            CorreoEntry.Text = string.Empty;
        }
    }
}
