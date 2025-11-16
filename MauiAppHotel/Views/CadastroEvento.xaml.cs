using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class CadastroEvento : ContentPage
{
        App PropriedadesApp;
        public CadastroEvento()
        {

            InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        inicioDoEvento.MinimumDate = DateTime.Now;
        inicioDoEvento.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        fimDoEvento.MinimumDate = inicioDoEvento.Date.AddDays(1);
        fimDoEvento.MaximumDate = inicioDoEvento.Date.AddDays(7);
        }
   

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {Evento ev = new Evento
            {
                NumeroParticipantes = Convert.ToInt32(NumeroDeParticipante.Value),
                NomeEvento = NomeDoEvento.Text,
                InicioEvento = inicioDoEvento.Date,
                FimEvento = fimDoEvento.Date,
                ValorParticipante = Convert.ToInt32(ValorDeParticipante.Value),
                LocalEvento = LocalDoEvento.Text, 

            };
           await Navigation.PushAsync(new EventoContradado()
           { 
                BindingContext = ev
           });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}