namespace SoporteTecnicoEquipos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            FlyoutBehavior = FlyoutBehavior.Disabled;

            await GoToAsync("//MainPage");
        }
    }
}