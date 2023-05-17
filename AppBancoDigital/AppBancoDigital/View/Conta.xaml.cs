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

            btnImgPix.Source = ImageSource.FromResource("AppBancoDigital.Imagens.pix.png");
        }
        private void Button_Clicked (object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pix());
        }
    }
}