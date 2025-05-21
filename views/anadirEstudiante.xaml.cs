using System.Net;

namespace semana6.views;

public partial class anadirEstudiante : ContentPage
{
	public anadirEstudiante()
	{
		InitializeComponent();
	}

    private void btnAnadir_Clicked(object sender, EventArgs e)
    {
		try
		{
			WebClient cliente = new WebClient();
			var parametros = System.Collections.Specialized.NameValueCollection();
			parametros.Add("nombre", txtNombre.Text);
			parametros.Add("apellido", txtApellido.Text);
			parametros.add("edad", txtEdad.Text);

			cliente.UploadValues("direccion donde està el servicio", "POST",parametros);
			Navigation.PushAsync(new vCrud());
		}
		catch (Exception ex)
		{
			DisplayAlert("Error", ex.Message, "Cerrar");
			throw;
		}
    }
}