using System.Collections.ObjectModel;
using UD2_EJ7_CAROUSEL.Models;

namespace UD2_EJ7_CAROUSEL.Views;

public partial class CarouselPage : ContentPage
{
	//VAMOS A DECLARAR UNA COLECCION PARA LOS JUGUETES

	// especial, porque avisa a la interfaz si hay un cambio dentro
	public ObservableCollection<Toy> ListToys { get; set; } = new ObservableCollection<Toy>
	{
		new Toy() { NameToy="Robot", PriceToy=14, ImageToy="robot.jpg", AgeRecomended=9 },
		new Toy() { NameToy="Pelota", PriceToy=6, ImageToy="ball.jpg", AgeRecomended=4 },
		new Toy() { NameToy="Muñeca", PriceToy=18, ImageToy="doll.jpg", AgeRecomended=4 },
		new Toy() { NameToy="Coche", PriceToy=20, ImageToy="car.jpg", AgeRecomended=5 }

	};


	private Toy? _selectedToy;

	//declaramos el objeto de juguete seleccionado
	public Toy? SelectedToy
	{
		get { return _selectedToy; }
		set
		{
			_selectedToy = value;
			OnPropertyChanged(); // aqui no hace falta el INotify... porque el ContentPage ya lo tiene integrado
		}
	} 
    public CarouselPage()
	{
		InitializeComponent();
		//conectamos el carousel con el observable collection
		BindingContext = this;
        //si usamos un binding, busca el binding aqui(this)
    }
}