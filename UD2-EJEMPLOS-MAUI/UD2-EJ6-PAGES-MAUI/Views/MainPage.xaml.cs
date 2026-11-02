namespace UD2_EJ6_PAGES_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void IBtnTyre_Clicked(object sender, EventArgs e)
        {
            //navegamos hacia la página de neumáticos
            await Shell.Current.GoToAsync(nameof(Views.TyrePage));
        }

        private async void IBtnDate_Clicked(object sender, EventArgs e)
        {
            //navegamos hacia la página de citas
            await Shell.Current.GoToAsync(nameof(Views.DatePage));
        }

        private async void IBtnContact_Clicked(object sender, EventArgs e)
        {
            //navegamos hacia la página de contactos
            await Shell.Current.GoToAsync(nameof(Views.ContactPage));
        }

    }
}
