using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Intec.xamaritanApp.ViewModels
{


    public class RegisterViewModels : BaseViewModel
    {
        public ICommand RegisterCommand { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public RegisterViewModels()
        {
            RegisterCommand = new Command(OnRegister);
        }
        async private void OnRegister()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword) || string.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Campos", "Debe llenar los campos", "continuar");
            }
            else if (Password != ConfirmPassword)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Las contraseñas deben ser iguales", "ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new Intec.xamaritanApp.ProfilePage());
                await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Name, "ok");
            }
        }


    }

}
