using UD2_EJ3_PIZZERIA_SUBIR_NOTA.Models;

namespace UD2_EJ3_PIZZERIA_SUBIR_NOTA.Views;

public partial class DeliveryPage : ContentPage
{
    private bool isNavigating = false;
    Pizza pizza = Pizza.Instancia;
    public DeliveryPage()
	{
		InitializeComponent();
	}

    private async void BtnDelivery_volver_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");

    }

    private async void BtnDelivery_confirmar_Clicked(object sender, EventArgs e)
    {
        if (isNavigating) return;

        if (DateDelivery.Date != null)
        {
            isNavigating = true;

            pizza.FechaEntraga = DateDelivery.Date;

            // Construcción de la lista de ingredientes extras seleccionados
            string extras = "";
            if (pizza.QuesoExtra) extras += "- Queso Extra\n";
            if (pizza.Jamon) extras += "- Jamón\n";
            if (pizza.Champinones) extras += "- Champiñones\n";
            if (pizza.Aceitunas) extras += "- Aceitunas\n";
            if (pizza.Pimientos) extras += "- Pimientos\n";

            // Si no hay extras, mostrar mensaje
            if (string.IsNullOrEmpty(extras))
                extras = "Sin ingredientes extras";

            // Construcción del resumen del pedido
            string resumen = $"RESUMEN DEL PEDIDO\n\n" +
                            $"Tipo de Pizza: {pizza.Tipo}\n" +
                            $"Cantidad: {pizza.Cantidad}\n\n" +
                            $"Ingredientes adicionales:\n{extras}\n" +
                            $"Fecha de entrega: {pizza.FechaEntraga:dd/MM/yyyy}";

            // Mostrar el resumen en una ventana modal
            await DisplayAlertAsync("Pedido Confirmado", resumen, "OK");

            isNavigating = false;
        }
    }
}