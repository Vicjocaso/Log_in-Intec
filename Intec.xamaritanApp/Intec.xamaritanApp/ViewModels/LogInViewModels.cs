using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Intec.xamaritanApp.ViewModels
{
    public class LogInViewModels : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }
        public string Name { get; set; }
        public string Password { get; set; }

        public LogInViewModels()
        {
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }
        async private void OnLogin()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Campos", "Debe llenar los campos", "continuar");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new Intec.xamaritanApp.ProfilePage());
                await App.Current.MainPage.DisplayAlert("Bienvenido", "Hola " + Name , "ok");
            }
        }
        async private void OnRegister()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Intec.xamaritanApp.RegistroPage());
        }

    }
}
