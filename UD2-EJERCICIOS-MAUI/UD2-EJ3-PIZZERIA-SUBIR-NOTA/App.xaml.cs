using Microsoft.Extensions.DependencyInjection;

namespace UD2_EJ3_PIZZERIA_SUBIR_NOTA
{
    public partial class App : Application
    {
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