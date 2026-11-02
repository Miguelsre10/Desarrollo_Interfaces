using UD2_EJ3_PIZZERIA_SUBIR_NOTA.Models;

namespace UD2_EJ3_PIZZERIA_SUBIR_NOTA.Views;

public partial class TypeSelectionPage : ContentPage
{
	Pizza pizza = Pizza.Instancia;

	// Copilot. Evita que al pulsar el boton de Siguiente
	// se añada a la pila la misma pagina varias veces 
	private bool isNavigating = false;

	public List<String> PizzaTypes { get; set; } = new List<String> { "Margarita", "Pepperoni", "Cuatro Quesos" };
	public TypeSelectionPage()
	{
		InitializeComponent();

		BindingContext = this;
	}

	private async void BtnTypeSelection_siguiente_Clicked(object sender, EventArgs e)
	{
		// Evitar navegación múltiple
		if (isNavigating) return;

		if (TypePicker.SelectedItem != null)
		{
			isNavigating = true;

			pizza.Tipo = (string)TypePicker.SelectedItem;
			pizza.Cantidad = (int)Slider_Cantidad.Value;

			// Navegar a PersonalizationPage usando la ruta registrada
			await Shell.Current.GoToAsync("personalization");

			isNavigating = false;
		}
		else
		{
			// Mostrar aviso modal si no hay selección
			await DisplayAlertAsync("Advertencia", "Debes seleccionar un tipo de pizza", "OK");
		}
	}
}