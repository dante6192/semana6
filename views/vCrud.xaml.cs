using Android.Database;
using Newtonsoft.Json;
using semana6.models;

namespace semana6.views;

public partial class vCrud : ContentPage
{
	private const string Url = "URL";
	private readonly HttpClient cliente =new HttpClient();



	private ObservableCollection<Estudiante> _estudiante;
	public vCrud()
	{
		InitializeComponent();
		Mostrar();
	}

	public async void Mostrar()
	{
		var content = await cliente.GetStringAsync(Url);
		List<Estudiante> lista = JsonConvert.DeserializeObject<List<Estudiante>>(content);
		_estudiante = new ObservableCollection<Estudiante> ( lista );
		lvEstudiante.ItelSource = _estudiante;
	}

    private void Nuevo_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new anadirEstudiante());

    }

    private void lvEstudiante_ItemSelect(object sender, SelectedItemChangedEventArgs e)
    {
		var objEstudiante = (Estudiante)e.SelectedItem;
		Navigation.PushAsync(new vEliminar_Estudiante(objEstudiante));
    }
}