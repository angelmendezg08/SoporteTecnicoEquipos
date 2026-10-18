namespace SoporteTecnicoEquipos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string correo = EmailEntry.Text?.Trim() ?? "";
            string contraseña = PasswordEntry.Text ?? "";

            if (correo == "admin@soporte.com" &&
                contraseña == "1234")
            {
                await DisplayAlert(
                 "Bienvenido",
                 "Inicio de sesión correcto.",
                 "Aceptar");

                Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;

                await Shell.Current.GoToAsync("//PrincipalPage");
            }
            else
            {
                await DisplayAlert(
                    "Error",
                    "El correo o la contraseña son incorrectos.",
                    "Aceptar");
            }
        }
    }
}