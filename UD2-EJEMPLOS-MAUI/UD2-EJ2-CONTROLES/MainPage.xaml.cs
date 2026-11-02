namespace UD2_EJ2_CONTROLES
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Prueba", "prueba", "ok");
        }
    }
}
