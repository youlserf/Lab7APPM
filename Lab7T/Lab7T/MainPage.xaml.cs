using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace Lab7T
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnScannerQR_Clicked(object sender, EventArgs e) {
            try {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.TopText = " Cardenas Youlserf";
                scanner.BottomText = "Lab 07";
                var result = await scanner.Scan();
                if ( result != null) {
                    txtResultado.Text = result.Text;
                }
            } catch(Exception ex) {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }

    }
}
