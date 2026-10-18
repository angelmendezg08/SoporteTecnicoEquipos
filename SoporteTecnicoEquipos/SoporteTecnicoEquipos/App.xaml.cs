using SoporteTecnicoEquipos.Services;

namespace SoporteTecnicoEquipos
{
    public partial class App : Application
    {
        public static SoporteService Servicio { get; } = new SoporteService();

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}


