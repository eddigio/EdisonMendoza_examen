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

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double dato1 = Convert.ToDouble(txtdato1.Text);
            double dato2 = Convert.ToDouble(txtdato2.Text);
            double montoInicial = (1800 - dato2);
            double pagoMensual = ((montoInicial / 3)*0.5);
            txtResultado.Text = pagoMensual.ToString();
            
            
        }
    }
}