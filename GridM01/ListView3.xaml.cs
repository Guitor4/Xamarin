using GridM01.model;
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
    public partial class ListView3 : ContentPage
    {
        public ListView3()
        {
            InitializeComponent();

            List<Produto> ListaProduto = new List<Produto>
            {
                new Produto{
                    img = "img/elesis.jpg",
                    nome = "Elesis",
                    valor = 2000.90
                },
                 new Produto{

                    img = "img/zero.png",
                    nome = "Zero",
                    valor = 2000.90
                },
                 new Produto{
                    img = "img/edel.png",
                    nome = "Edel",
                    valor = 2000.90
                }

            };

            listView1.ItemsSource = ListaProduto;
        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}