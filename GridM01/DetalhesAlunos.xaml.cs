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
    public partial class DetalhesAlunos : ContentPage
    {
        public DetalhesAlunos(Object aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentException();
            }

            BindingContext = aluno;
                

            InitializeComponent();
        }
    }
}