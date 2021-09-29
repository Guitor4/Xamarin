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
    public partial class Calculadora : ContentPage
    {
        public Calculadora()
        {
            InitializeComponent();
        }


        private void btn1_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '7';
        }
        private void btn2_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '8';
        }
        private void btn3_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '9';
        }
        private void btn4_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '+';
        }
        private void btn5_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '4';
        }
        private void btn6_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '5';
        }
        private void btn7_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '6';
        }
        private void btn8_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '-';
        }
        private void btn9_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '1';
        }
        private void btn10_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '2';
        }
        private void btn11_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '3';
        }
        private void btn12_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '*';
        }
        private void btn13_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '0';
        }
        private void btn14_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '=';
        }
        private void btn15_Clicked(object sender, EventArgs e)
        {
            lb1.Text += '/';
        }
    }
}