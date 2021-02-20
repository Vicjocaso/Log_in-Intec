using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intec.xamaritanApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }
        async private void HomeP(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(confirPassword.Text) || string.IsNullOrEmpty(email.Text))
            {
                await DisplayAlert("Campos", "Debe llenar los campos", "continuar");
            }
            else if (password.Text != confirPassword.Text)
            {
                await DisplayAlert("Alert", "Las contraseñas deben ser iguales", "ok");
            }
            else 
            {
                await Navigation.PushAsync(new Intec.xamaritanApp.ProfilePage());
                await DisplayAlert("Bienvenido", "Hola " + name.Text, "ok");
            }
        }
    }
}