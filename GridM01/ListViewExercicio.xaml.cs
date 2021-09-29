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
    public partial class ListViewExercicio : ContentPage
    {
        public ListViewExercicio()
        {
            InitializeComponent();
        }

        private void ListaAlunos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaAlunos());
        }
    }
}