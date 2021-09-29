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
    public partial class ListaAlunos : ContentPage
    {
        public ListaAlunos()
        {
            InitializeComponent();

            List<Alunos> ListaAlunos = new List<Alunos>
            {
                new Alunos{ 
                
                    Img = "img/elesis.jpg",
                    nome = "Elesis Sieghart",
                    matricula = "20210123"

                
                },
                new Alunos{

                    Img = "img/zero.jpg",
                    nome = "Zero Zephyrum",
                    matricula = "20210123"


                },
                new Alunos{

                    Img = "img/jin.png",
                    nome = "Jin Kaien",
                    matricula = "20210123"


                },
                new Alunos{

                    Img = "img/asin.png",
                    nome = "Asin ????",
                    matricula = "20210123"


                },





            };

            listView1.ItemsSource = ListaAlunos;

        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
           var p = e.SelectedItem as Alunos;

            DisplayAlert("Mensagem", "Aluno :" +p.nome, "OK");
        }
    }
}