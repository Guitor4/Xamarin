using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridM01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pagina02(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridBotoes());
        }

        private void pagina05(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GcCharacters());
        }
    }
}
