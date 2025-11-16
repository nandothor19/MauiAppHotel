namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Views.CadastroEvento());
    }
}