using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EdisonMendoza_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana_dos : ContentPage
    {
        public Ventana_dos(string user,string pass)
        {
            InitializeComponent();
            lbUser.Text = user;
            txtpass.Text = pass;

        }
    }
}