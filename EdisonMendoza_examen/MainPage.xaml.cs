﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EdisonMendoza_examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_ventana_dos_Clicked(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;

            //definicion de varicaciones
            string user_val = "estudiante2020";
            string pass_val = "uisrael2020";
            await Navigation.PushAsync (new Ventana_dos(user,pass));


        }
    }
}
