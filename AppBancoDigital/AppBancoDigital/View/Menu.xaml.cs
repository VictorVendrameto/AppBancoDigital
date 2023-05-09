using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        //Ir no app android>Resources>Values>Styles.xml para mudar a cor da barrinha de status

        //pix
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pix());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Conta());
        }

        private async void btnSair_Clicked(object sender, EventArgs e)
        {
            bool confirme = await DisplayAlert("Você deseja",
                                                "Desconectar a sua conta?",
                                                "Sim", "Não");
            if (confirme)
            {
                App.Current.Properties.Remove("user_logado");
                App.Current.MainPage = new Login();
            }
        }
    }
}