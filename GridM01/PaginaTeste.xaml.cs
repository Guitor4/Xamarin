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
    public partial class PaginaTeste : ContentPage
    {
        public PaginaTeste()
        {
            InitializeComponent();
        }
        private void pagina02(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridBotoes());
        }
        private void pagina01(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}