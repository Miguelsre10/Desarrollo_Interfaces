using Ej_MAUI.Models;

namespace Ej_MAUI.Views;

public partial class PizzaPage : ContentPage
{
	public Pizza pizza { get; set; } = new Pizza();
    string resumen = "";

    public PizzaPage()
	{
		InitializeComponent();
        BindingContext= this;
	}

    private async void BtnConfirmarPedido_Clicked(object sender, EventArgs e)
    {
        CalculoPizza();
        resumen = "Tamaño: " + pizza.Tipo;
        resumen += "\n";
        resumen += "Ingredientes: ";
        if (pizza.Jamon) resumen += "Jamón ";
        if (pizza.Champinones) resumen += "Champiñones ";
        if (pizza.Aceitunas) resumen += "Aceitunas ";
        if (pizza.Pina) resumen += "Piña ";
        resumen += "\n";
        resumen += "Cantidad: " + pizza.Cantidad;
        resumen += "\n";
        resumen += "\n";
        resumen += "Total: " + CalculoTotal();



        await DisplayAlertAsync("Pedido Confirmado", resumen, "Aceptar");
    }

    private decimal CalculoExtra()
    {
        decimal extra = 0;
        if (pizza.Jamon) extra += (decimal)1.5;
        if (pizza.Champinones) extra += (decimal)1.5;
        if (pizza.Aceitunas) extra += (decimal)1.5;
        if (pizza.Pina) extra += (decimal)1.5;
        return extra;
    }
    private decimal CalculoTotal()
    {
        decimal total = 0;
        if (RBtnPequena.IsChecked) total = 8;
        if (RBtnMedidana.IsChecked) total = 12;
        if (RBtnGrande.IsChecked) total = 16;
        if (pizza.domicilio)
        {
            pizza.p_domicilio = 3;
            
        }
        else{
            pizza.p_domicilio = 0;
        }
        total += (decimal)3;
        pizza.total = total;
        return total+CalculoExtra();
    }

	private void CalculoPizza()
	{
        if (RBtnPequena.IsChecked)
        {
            pizza.Tipo = "Pequeña";
        }
        if (RBtnMedidana.IsChecked)
        {
            pizza.Tipo = "Mediana";
        }
        if (RBtnGrande.IsChecked)
        {
            pizza.Tipo = "GRande";
        }

        if (ChkJamon.IsChecked)
        {
            pizza.Jamon = true;
        }
        if (ChkChampi.IsChecked)
        {
            pizza.Champinones = true;
        }
        if (ChkAceitunas.IsChecked)
        {
            pizza.Aceitunas = true;
        }
        if (ChkPina.IsChecked)
        {
            pizza.Pina = true;
        }
        if (SwServicioDomicilio.IsToggled)
        {
            pizza.domicilio = true;
        }
        CalculoTotal();
        pizza.Cantidad = (int)Slider_Cantidad.Value;
    }

    private void RBtnMedidana_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculoPizza();
    }

    private void RBtnGrande_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculoPizza();
    }

    private void ChkJamon_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculoPizza();
    }

    private void ChkChampi_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculoPizza();
    }

    private void ChkAceitunas_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculoPizza();
    }

    private void ChkPina_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculoPizza();
    }

    private void Slider_Cantidad_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        CalculoPizza();
    }

    private void SwServicioDomicilio_Toggled(object sender, ToggledEventArgs e)
    {
        CalculoPizza();
    }

    private void RBtnPequena_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CalculoPizza();
    }
}