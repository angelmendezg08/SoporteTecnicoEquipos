
using SoporteTecnicoEquipos.Models;

namespace SoporteTecnicoEquipos
{
    public partial class EquiposPage : ContentPage
    {
        public EquiposPage()
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
            EquiposCollectionView.ItemsSource = null;
            EquiposCollectionView.ItemsSource = App.Servicio.Equipos;
        }

        private async void OnGuardarEquipoClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text?.Trim() ?? "";
            string tipo = TipoEntry.Text?.Trim() ?? "";
            string marca = MarcaEntry.Text?.Trim() ?? "";
            string modelo = ModeloEntry.Text?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(tipo) ||
                string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(modelo))
            {
                await DisplayAlert(
                    "Campos obligatorios",
                    "Completa el nombre, tipo, marca y modelo del equipo.",
                    "Aceptar");

                return;
            }

            App.Servicio.AgregarEquipo(new Equipo
            {
                Nombre = nombre,
                Tipo = tipo,
                Marca = marca,
                Modelo = modelo
            });

            ActualizarLista();

            await DisplayAlert(
                "Equipo guardado",
                "El equipo se registró correctamente.",
                "Aceptar");

            NombreEntry.Text = string.Empty;
            TipoEntry.Text = string.Empty;
            MarcaEntry.Text = string.Empty;
            ModeloEntry.Text = string.Empty;
        }
    }
}
