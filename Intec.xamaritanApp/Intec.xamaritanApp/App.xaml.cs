using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intec.xamaritanApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var login = new MainPage();
            NavigationPage.SetHasNavigationBar(login, false);
            MainPage = new NavigationPage(login);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
