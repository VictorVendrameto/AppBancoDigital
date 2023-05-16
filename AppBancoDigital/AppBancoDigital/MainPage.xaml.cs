using AppBancoDigital.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace AppBancoDigital
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Conta)));

            NavigationPage.SetHasNavigationBar(this, false);
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