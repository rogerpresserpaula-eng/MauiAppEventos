namespace MauiAppEventos.VIEWS;

public partial class CadastroEvento : ContentPage
{
	public CadastroEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new ResumoEvento());

        }
		catch
		{
            DisplayAlert("Ops", "ERRO!", "OK");
        }
    }
}