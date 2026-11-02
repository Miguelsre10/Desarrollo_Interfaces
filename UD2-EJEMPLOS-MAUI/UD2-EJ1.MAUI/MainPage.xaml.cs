namespace UD2_EJ1.MAUI
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
       {
            InitializeComponent();
       }

        private async void BtnSend_Clicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Entrada", "Has entrado en el sistema", "Aceptar");
        }
    }
}
