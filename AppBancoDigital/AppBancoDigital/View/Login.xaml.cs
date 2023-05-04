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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Menu());
            //dados pro login (temporario)



            /*string password = conta_pw.Text;

            string user_correto = "58885093884";
            string password_correto = "4444";

            if (user == user_correto && password == password_correto) 
            {
                Application.Current.Properties.Add("user_logado", user);
                App.Current.MainPage = new NavigationPage(new View.Menu());
            }
            else 
            {
                DisplayAlert("Ops!", "CPF ou senha inválidos", "OK");
            }*/
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Cadastro());
        }
    }
}