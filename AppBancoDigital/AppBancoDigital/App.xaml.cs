﻿using AppBancoDigital.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital
{
    public partial class App : Application
    {
        public static Model.Correntista DadosCorrentista { get; set; }
        public App()
        {

            //Forçar modo claro, ir para MainActivity
            Device.SetFlags(new string[] { "AppTheme_Experimental" });

            InitializeComponent();

            if (Properties.ContainsKey("user_logado"))
            {
                MainPage = new NavigationPage(new MainPage());
            }
            //setar uma pagina inicial
            else
            {
                MainPage = new NavigationPage(new View.Login());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
