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
    public partial class GcCharacters : ContentPage
    {
        public GcCharacters()
        {
            InitializeComponent();
        }

        private async void T1(object sender, EventArgs e)
        {
            img1.Opacity = 0.5;
            await Task.Delay(100);
            img1.Opacity = 1;
            await Navigation.PushAsync(new PaginaTeste());
        }
        private async void T2(object sender, EventArgs e)
        {
            img2.Opacity = 0.5;
            await Task.Delay(100);
            img2.Opacity = 1;
            await DisplayAlert("fui tapeado","fui tapeado","fui tapeado");
        }
        private async void T3(object sender, EventArgs e)
        {
            img3.Opacity = 0.5;
            await Task.Delay(100);
            img3.Opacity = 1;
            await Navigation.PushAsync(new CharSpecs());
        }
        private async void T4(object sender, EventArgs e)
        {
            img4.Opacity = 0.5;
            await Task.Delay(100);
            img4.Opacity = 1;
            await Navigation.PushAsync(new PaginaTeste());
        }
    }
}