using semana6.models;

namespace semana6.views;

public partial class vEliminar_Estudiante : ContentPage
{
	public vEliminar_Estudiante(Estudiante datos)
	{

		InitializeComponent();
        txtCodigo.Text=datos.codigo; 
        txtNombre.Text=datos.nombre;
        txtApellido.Text=datos.apellido;
        txtEdad.Text=datos.edad.ToString();
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {

    }
}