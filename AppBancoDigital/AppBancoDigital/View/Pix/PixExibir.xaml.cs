using QRCoder;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace AppBancoDigital.View.Pix
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PixExibir : ContentPage
	{
		public PixExibir ()
		{
			InitializeComponent ();
		}

        
        private void Button_Clicked(object sender, EventArgs e)
        {
            string teste = "Chave da Transferência: vendrametovictor@gmail.com ";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(teste, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            img_qrcode.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }
    }
}