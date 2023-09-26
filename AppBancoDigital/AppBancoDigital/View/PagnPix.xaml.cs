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
	public partial class PagnPix : ContentPage
	{
		public PagnPix ()
		{
			InitializeComponent ();

            btnReceber.Source = ImageSource.FromResource("AppBancoDigital.Imagens.pagpix.png");
            btnEnviar.Source = ImageSource.FromResource("AppBancoDigital.Imagens.enviarpix.png");
            btnLer.Source = ImageSource.FromResource("AppBancoDIgital.Imagens.LerQR.png");
        }
        //receber
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pix.PixReceber());
        }

        //enviar
        private void Button_Clicked1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pix.PixEnviar());
        }

        //exibir
        private void Button_Clicked2(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pix.PixExibir());
        }
        //ler
        private void Button_Clicked3(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pix.PixLerQRCode());
        }
    }
}