namespace APP_CRUD
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            //Declaramos los eventos click de los botones

            ButtonsComponent.BtnAdd.Clicked += BtnAdd_Clicked;
            ButtonsComponent.BtnModify.Pressed += BtnModify_Pressed;
            ButtonsComponent.BtnModify.Released += BtnModify_Released;
            ButtonsComponent.BtnDelete.Focused += BtnDelete_Focused;
            ButtonsComponent.BtnDelete.Unfocused += BtnDelete_Unfocused;
        }

        private void BtnDelete_Unfocused(object? sender, FocusEventArgs e)
        {
            dotnet.IsVisible = true;
        }

        private void BtnDelete_Focused(object? sender, FocusEventArgs e)
        {
            dotnet.IsVisible = false;
        }

        private void BtnModify_Released(object? sender, EventArgs e)
        {
            ButtonsComponent.BtnModify.TextColor = Colors.White;
        }

        private void BtnModify_Pressed(object? sender, EventArgs e)
        {
            ButtonsComponent.BtnModify.TextColor = Colors.Red;
        }

        private async void BtnAdd_Clicked(object? sender, EventArgs e)
        {
            await DisplayAlertAsync("Evento ADD", "Esto es el evento 'Clicked' de el boton 'Añadir'", "OK");
        }
    }
}
