namespace MauiAppEventos.VIEWS;

public partial class CadastroEvento : ContentPage
{
	public CadastroEvento()
	{
		InitializeComponent();

		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);

		dtpck_final.MinimumDate = dtpck_inicio.Date.Value.AddDays(1);
        dtpck_final.MaximumDate = dtpck_inicio.Date.Value.AddDays(10);

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
    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date.Value;

        dtpck_final.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_final.MaximumDate = data_selecionada_inicio.AddDays(10);
    }
    
}