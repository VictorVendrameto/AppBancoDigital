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
    public partial class Conta : ContentPage
    {
        public Conta()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            btnPix.Source = ImageSource.FromResource("AppBancoDigital.Imagens.pix.png");
            btnDep.Source = ImageSource.FromResource("AppBancoDigital.Imagens.dep.png");
            btnTrans.Source = ImageSource.FromResource("AppBancoDigital.Imagens.trans.png");
            btnPag.Source = ImageSource.FromResource("AppBancoDigital.Imagens.pix.png");
        }

        //Pix
        private void Button_Clicked (object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pix());
        }

        //Pagamentos
        private void Button_Clicked1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pag());
        }

        //Transferencia
        private void Button_Clicked2(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Trans());
        }
        //Deposito
        private void Button_Clicked3(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Dep());
        }
    }
}