using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXamarinMov_Calculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        

        private void Button_Numeros_Clicked(object sender, EventArgs e)
        {
            Visor.Text += ((Button)sender).Text;
        }

        private void btn_Resultado_Clicked(object sender, EventArgs e)
        {
            St_OperacionesAnteriores.Children.Add(new Label() { Text = Visor.Text, FlowDirection = FlowDirection.RightToLeft }) ;
            var lastChild = St_OperacionesAnteriores.Children.LastOrDefault();
            if (lastChild != null)
                Sv_historial.ScrollToAsync(lastChild, ScrollToPosition.MakeVisible, true);

        }
    }
}
