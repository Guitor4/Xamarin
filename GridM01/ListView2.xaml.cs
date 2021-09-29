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
    public partial class ListView2 : ContentPage
    {
        public ListView2()
        {
            InitializeComponent();

            List<string> lista = new List<string>
            {
                "Domingo","Segunda-feira","Terça-feira","Quarta-feira","Quinta-feira","Sexta-feira","Sábado"
            };

            listView1.ItemsSource = lista;
        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}