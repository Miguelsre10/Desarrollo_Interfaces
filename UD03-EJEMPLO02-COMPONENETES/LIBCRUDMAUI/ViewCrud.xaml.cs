namespace LIBCRUDMAUI;

public partial class ViewCrud : ContentView
{
	//Declaramos las propiedades que vamos a importar del componente

	public Button BtnAdd => AddButton;
	public Button BtnModify { get { return ModifyButton; } }
	// las dos de arriba son equivalentes

	public Button BtnDelete => DeleteButton;


	public ViewCrud()
	{
		InitializeComponent();
	}
}