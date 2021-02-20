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
            await Navigation.PushAsync(new Intec.xamaritanApp.ProfilePage());
        }
    }
}