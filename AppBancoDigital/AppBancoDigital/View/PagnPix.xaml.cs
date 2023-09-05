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
		}
        //receber
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pag());
        }

        //enviar
        private void Button_Clicked1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Pag());
        }

        //exibir
        private void Button_Clicked2(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Trans());
        }
        //ler
        private void Button_Clicked3(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new View.Dep());
        }
    }
}