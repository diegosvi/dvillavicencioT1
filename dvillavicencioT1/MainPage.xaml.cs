namespace dvillavicencioT1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalculo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            int salario = Convert.ToInt32(txtSalario.Text);


            int aporte = (int)(salario * 0.0945);

            DisplayAlert("Alerta", "Bienvenido: " + nombre + " "+ apellido +"\nTienes: " + edad + "años"+ "\nTu aporte mensual es de: " + aporte, "Cerrar");

        }
    }

}
