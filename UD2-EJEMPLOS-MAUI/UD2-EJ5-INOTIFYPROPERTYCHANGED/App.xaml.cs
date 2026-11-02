using Microsoft.Extensions.DependencyInjection;

namespace UD2_EJ5_INOTIFYPROPERTYCHANGED
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