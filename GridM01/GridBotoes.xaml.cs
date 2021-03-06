using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridBotoes : ContentPage
    {
        public GridBotoes()
        {
            InitializeComponent();
        }

        private void pagina01(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        private void pagina03(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calculadora());
        }
        private void pagina04(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GcCharacters());
        }
    }
}