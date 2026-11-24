namespace UD3_PERISTENCIA_MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            EntryClientName.Text = Preferences.Get("clientName", String.Empty);
            EntryClientMail.Text = Preferences.Get("clientEmail", "");

            //para el presupuesto pasamos de double a string
            var budget = Preferences.Get("clientBudget", 0.0);
            EntryBudget.Text = budget.ToString();

            //para la lista desplegable vamos a convertit el valor 
            //de configuracion en un indice compatible con el Picker
            var destiny = Preferences.Get("clientDestiny", "");
            if (!string.IsNullOrWhiteSpace(destiny))
            {
                var list = PickerDestiny.ItemsSource.Cast<string>().ToList();
                PickerDestiny.SelectedIndex = list.IndexOf(destiny);
            }
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            //Guardar informacion en la configuracion de la APP
            Preferences.Set("clientName", EntryClientName.Text ?? "");
            Preferences.Set("clientEmail", EntryClientMail.Text ?? "");

            //Tenemos que parsear el string del presupuesto a double
            if (double.TryParse(EntryBudget.Text, out double clientBudget))
            {
                Preferences.Set("clientBudget", clientBudget);
            }

            Preferences.Set("clientDestiny", PickerDestiny.SelectedItem.ToString() ?? "");

            //guradamos y borramos los metodos del formulario
            await DisplayAlertAsync("Guardado", "Se han guardado los datos", "Continuar");
            clearForm();
        }

        private void BtnLoad_Clicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            try
            {
                var confirmacion = await DisplayAlertAsync("Borrar", "¿Seguro que quiere borrar los datos del formulario?", "BORRAR", "Cancelar");
                if (confirmacion)
                {
                    clearForm();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync("Error", ex.Message, "OK");
            }
        }

        private void clearForm()
        {
            EntryClientName.Text = "";
            EntryClientMail.Text = "";
            EntryBudget.Text = "";
            PickerDestiny.SelectedIndex = -1;
        }
    }
}
