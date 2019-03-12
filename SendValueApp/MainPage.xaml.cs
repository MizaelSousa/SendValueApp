using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SendValueApp
{
    public partial class MainPage : ContentPage
    {
        void Calcular(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageCalc(N1.Text, N2.Text));
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
