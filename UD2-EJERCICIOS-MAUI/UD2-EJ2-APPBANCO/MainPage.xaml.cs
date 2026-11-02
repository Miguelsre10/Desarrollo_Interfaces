namespace UD2_EJ2_APPBANCO
{
    public partial class MainPage : ContentPage
    {
        public List<String> Transacciones { get; set; } = new List<string>
        {
            "Compra en supermercado - Cantidad: $32.40 - Fecha: 10/08/2024",
            "Pago de servicios - Cantidad: $45.00 - Fecha: 11/08/2024",
            "Gasolinera - Cantidad: $60.25 - Fecha: 12/08/2024",
            "Restaurante - Cantidad: $12.99 - Fecha: 13/08/2024",
            "Suscripción digital - Cantidad: $24.50 - Fecha: 14/08/2024",
            "Farmacia - Cantidad: $85.00 - Fecha: 15/08/2024",
            "Tienda de ropa - Cantidad: $5.50 - Fecha: 16/08/2024",
            "Transporte público - Cantidad: $120.45 - Fecha: 17/08/2024",
            "Compra en línea - Cantidad: $8.75 - Fecha: 18/08/2024",
            "Cafetería - Cantidad: $15.00 - Fecha: 19/08/2024",
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

    }
}
