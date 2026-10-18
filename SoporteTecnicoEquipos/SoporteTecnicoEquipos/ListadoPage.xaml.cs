
namespace SoporteTecnicoEquipos
{
    public partial class ListadoPage : ContentPage
    {
        public ListadoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ReportesCollectionView.ItemsSource = null;
            ReportesCollectionView.ItemsSource = App.Servicio.Reportes;
        }

        private async void OnCrearReporteClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//FormularioPage");
        }
    }
}
