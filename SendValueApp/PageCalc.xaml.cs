using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SendValueApp
{
    public partial class PageCalc : ContentPage
    {
        public PageCalc(string Valor1, string Valor2)
        {
            InitializeComponent();
            int resultado = Int32.Parse(Valor1) + Int32.Parse(Valor2);
            Result.Text = resultado.ToString();
        }
    }
}
