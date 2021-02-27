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
                await App.Current.MainPage.DisplayAlert("Alert", "You must fill in the fields", "Ok");
            }
            else if (Password != ConfirmPassword)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "Passwords must be the same", "Ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new Intec.xamaritanApp.ProfilePage());
                await App.Current.MainPage.DisplayAlert("Welcome", "Hello " + Name, "Ok");
            }
        }


    }

}
