﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Intec.xamaritanApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
           await DisplayAlert("Vacio", "", "ok");
        }

        async private void Registro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Intec.xamaritanApp.RegistroPage());
        }

    }
}
