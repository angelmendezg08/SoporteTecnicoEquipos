
using SoporteTecnicoEquipos.Models;

namespace SoporteTecnicoEquipos
{
    public partial class FormularioPage : ContentPage
    {
        public FormularioPage()
        {
            InitializeComponent();
            EstadoPicker.SelectedIndex = 0;
        }

        private async void OnGuardarReporteClicked(object sender, EventArgs e)
        {
            string equipo = EquipoEntry.Text?.Trim() ?? "";
            string problema = ProblemaEntry.Text?.Trim() ?? "";
            string descripcion = DescripcionEditor.Text?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(equipo) ||
                string.IsNullOrWhiteSpace(problema) ||
                string.IsNullOrWhiteSpace(descripcion))
            {
                await DisplayAlert(
                    "Campos obligatorios",
                    "Completa el equipo, el problema y la descripción antes de guardar.",
                    "Aceptar");

                return;
            }

            string estado = EstadoPicker.SelectedItem?.ToString() ?? "Pendiente";

            App.Servicio.AgregarReporte(new ReporteSoporte
            {
                Equipo = equipo,
                Problema = problema,
                Descripcion = descripcion,
                Estado = estado
            });

            await DisplayAlert(
                "Reporte guardado",
                "El reporte se guardó correctamente.",
                "Aceptar");

            EquipoEntry.Text = string.Empty;
            ProblemaEntry.Text = string.Empty;
            DescripcionEditor.Text = string.Empty;
            EstadoPicker.SelectedIndex = 0;

            await Shell.Current.GoToAsync("//ListadoPage");
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//PrincipalPage");
        }
    }
}
