namespace UD2_EJ6_PAGES_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.ContactPage), typeof(Views.ContactPage));
            Routing.RegisterRoute(nameof(Views.TyrePage), typeof(Views.TyrePage));
            Routing.RegisterRoute(nameof(Views.DatePage), typeof(Views.DatePage));
        }
    }
}
