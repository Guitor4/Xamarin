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
    public partial class ImgCircleNoCS : ContentPage
    {
        public ImgCircleNoCS()
        {
            InitializeComponent();

            AbsoluteLayout abs = new AbsoluteLayout();

            Label lb1 = new Label()
            {
                Text = "Irineu você não sabe nem eu",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Image img2 = new Image
            {
                Source = "lass.png"
            };
            abs.Children.Add(img2, new Rectangle(0.5, 100, 200, 200), AbsoluteLayoutFlags.XProportional);

            abs.Children.Add(lb1, new Rectangle(0.1, 30, 400, 80), AbsoluteLayoutFlags.XProportional);

            img1.Source = "elesis.png";

            var tap1 = new TapGestureRecognizer();

            img1.GestureRecognizers.Add(tap1);

            tap1.Tapped += Tap1_Tapped;

            abs.Children.Add(img1, new Rectangle(0.5, 300, 150, 150), AbsoluteLayoutFlags.XProportional);

            Content = abs;
        }

        private async void Tap1_Tapped(object sender, EventArgs e)
        {
            img1.Opacity = 0.5;
            await Task.Delay(200);
            img1.Opacity = 1;
            await DisplayAlert("fui tapeado", "fui tapeado", "fui tapeado");
        }
    }
}