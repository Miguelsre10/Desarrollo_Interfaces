using EJ_MAUI.Models;
using System.Collections.ObjectModel;

namespace EJ_MAUI.Views;

public partial class Agenda : ContentPage
{
	public ObservableCollection<Tarea> AgendaTareas { set; get; } = new ObservableCollection<Tarea>();

	public Agenda()
	{
		InitializeComponent();
		this.BindingContext = this;
	}

    private async void BtnAnadir_Clicked(object sender, EventArgs e)
    {
        //if(!Validacion()) { return; }
        if (DescripcionEntry.Text == "")
        {
            await DisplayAlertAsync("Alerta", "La descripcion no puede estar vacia", "OK");
            return ;
        }
        if (ModuloPicker.SelectedIndex == -1)
        {
            await DisplayAlertAsync("Alerta", "Se ha de seleccionar un modulo", "OK");
            return ;
        }

        AgendaTareas.Add(new Tarea
        {
            Descripcion = DescripcionEntry.Text,
            Asignatura = ModuloPicker.SelectedItem.ToString(),
            FechaEntrega = FechaPicker.Date ?? DateTime.Now
        });

    }
    /*
	private async bool Validacion() {
		if(DescripcionEntry.Text == "")
		{
			await DisplayAlertAsync("Alerta", "La descripcion no puede estar vacia", "OK");
			return true;
		}
		if (ModuloPicker.SelectedIndex == -1)
		{
            await DisplayAlertAsync("Alerta", "Se ha de seleccionar un modulo", "OK");
            return true;
        }
		return true; 
	}
    */
}