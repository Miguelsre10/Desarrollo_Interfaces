namespace UD2_EJ5_INOTIFYPROPERTYCHANGED
{
    public partial class MainPage : ContentPage
    {
        private MatchNames matchName1;
        public MainPage()
        {
            InitializeComponent();

            //Crear un objeto de la clase MatchNames

            matchName1 = new MatchNames { Name = "Nombre", Surname = "Apellido" };
            BindingContext = matchName1;

        }
    }
}
