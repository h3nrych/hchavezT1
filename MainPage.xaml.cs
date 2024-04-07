namespace hchavezT1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void btnCalcularIess_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                !string.IsNullOrWhiteSpace(txtSalario.Text) &&
                !string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                double salario = double.Parse(txtSalario.Text);
                int edad = int.Parse(txtEdad.Text);

                // sacar porcentaje al slario
                double aporteIESS = salario * 0.0945;
                //restar el aporte al iees
                double salarioNeto = salario - aporteIESS;

                await DisplayAlert("Aporte al IESS", $"Nombre: {nombre}\nApellido: {apellido}\nSalario: {salario:C}\nEdad: {edad}\nAporte al IESS: {aporteIESS:C} \n\n\nsalario neto: {salarioNeto}", "OK");
            }
            else
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            }
        }
    }
}

