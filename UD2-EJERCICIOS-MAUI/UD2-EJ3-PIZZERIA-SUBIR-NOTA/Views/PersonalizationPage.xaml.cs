using UD2_EJ3_PIZZERIA_SUBIR_NOTA.Models;

namespace UD2_EJ3_PIZZERIA_SUBIR_NOTA.Views;

public partial class PersonalizationPage : ContentPage
{
    private bool isNavigating = false;
    Pizza pizza = Pizza.Instancia;
    public PersonalizationPage()
	{
		InitializeComponent();
	}

    private async void BtnPersonalization_siguiente_Clicked(object sender, EventArgs e)
    {
        if (isNavigating) return;

        isNavigating = true;

        pizza.QuesoExtra = ChkQueso.IsChecked;
        pizza.Jamon = ChkJamon.IsChecked;
        pizza.Champinones = ChkChampin.IsChecked;
        pizza.Aceitunas = ChkAceitunas.IsChecked;
        pizza.Pimientos = ChkPimientos.IsChecked;

        await Shell.Current.GoToAsync("delivery");

        isNavigating = false;
    }

    private async void BtnPersonalization_volver_Clicked(object sender, EventArgs e)
    {
        // Vuelve a la página anterior sin agregar historial
        // Pop de la pila
        await Shell.Current.GoToAsync("..");
    }
}