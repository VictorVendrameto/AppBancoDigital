using AppBancoDigital.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace AppBancoDigital
{
    public partial class App : Application
    {
        public App()
        {

            //Forçar modo claro, ir para MainActivity
            Device.SetFlags(new string[] { "AppTheme_Experimental" });

            InitializeComponent();

            MainPage = new Login();
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
