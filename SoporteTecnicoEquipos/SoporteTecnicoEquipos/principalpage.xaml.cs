namespace SoporteTecnicoEquipos
{
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        private async void OnVerReportesClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ListadoPage");
        }

        private async void OnCrearReporteClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//FormularioPage");
        }

        private async void OnCerrarSesionClicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
