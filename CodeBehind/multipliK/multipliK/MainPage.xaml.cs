namespace multipliK;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void MultiplicaBtn_Clicked(System.Object sender, System.EventArgs e)
    {
		string pasos = "";
		int numero1 = int.Parse(number1.Text);
		pasos += $"	 {numero1}\n";
        int numero2 = int.Parse(number2.Text);
        pasos += $"x {numero2}\n";
		pasos += "______________\n";

		
		char[] digitos = number2.Text.ToCharArray();

		foreach (var numero in digitos.Reverse())
		{
			pasos += $"{(int.Parse(numero.ToString()) * numero1)}\n";
        }
        pasos += "______________\n";

        int resultado = numero1 * numero2;
		pasos += $"{resultado}";
		result.Text = pasos;

    }

}


