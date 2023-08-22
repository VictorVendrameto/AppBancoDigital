using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBancoDigital.Model;
using AppBancoDigital.Service;
using System.Diagnostics;

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

        //Login
        private async void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Conta());



            /*try
            {
                string[] cpf_pontuado = user.Text.Split('.', '-');
                string cpf_digitado = cpf_pontuado[0] + cpf_pontuado[1] + cpf_pontuado[2] + cpf_pontuado[3];
                string senha_digitada = conta_pw.Text;

                string senha_sha1;

                using (var sha1 = new SHA1Managed())
                {
                    senha_sha1 = BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(senha_digitada)));
                    senha_sha1 = string.Join("", senha_sha1.ToLower().Split('-'));
                }

                Correntista c = await DataServiceCorrentista.AuthenticCorrentista(new Correntista
                {
                    Cpf = cpf_digitado,
                    Senha = senha_sha1
                });

                if(c != null)
                {
                    App.Current.Properties.Add("user_logado", cpf_digitado);
                    App.Current.MainPage = new NavigationPage(new MainPage()
                    {
                        BindingContext = c
                    });
                }

                else
                {
                    DisplayAlert("Erro", "Dados incorretos!", "OK");
                }
            }
            catch (Exception err)
            {
                DisplayAlert("Ops", err.Message, "OK");
            }
            //Finally{

            //Carregando.IsRunning = false; }
            */
        }

        //cadastro
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Cadastro());
        }
    }
}