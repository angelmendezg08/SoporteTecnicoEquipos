
using SoporteTecnicoEquipos.Models;

namespace SoporteTecnicoEquipos
{
    public partial class TecnicosPage : ContentPage
    {
        public TecnicosPage()
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
            TecnicosCollectionView.ItemsSource = null;
            TecnicosCollectionView.ItemsSource = App.Servicio.Tecnicos;
        }

        private async void OnGuardarTecnicoClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text?.Trim() ?? "";
            string especialidad = EspecialidadEntry.Text?.Trim() ?? "";
            string telefono = TelefonoEntry.Text?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(especialidad) ||
                string.IsNullOrWhiteSpace(telefono))
            {
                await DisplayAlert(
                    "Campos obligatorios",
                    "Completa el nombre, la especialidad y el teléfono del técnico.",
                    "Aceptar");
                return;
            }

            App.Servicio.AgregarTecnico(new Tecnico
            {
                Nombre = nombre,
                Especialidad = especialidad,
                Telefono = telefono
            });

            ActualizarLista();

            await DisplayAlert(
                "Técnico guardado",
                "El técnico se registró correctamente.",
                "Aceptar");

            NombreEntry.Text = string.Empty;
            EspecialidadEntry.Text = string.Empty;
            TelefonoEntry.Text = string.Empty;
        }
    }
}
