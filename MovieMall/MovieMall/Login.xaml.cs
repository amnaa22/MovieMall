using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.Toast;
using Plugin.Toast.Abstractions;


namespace MovieMall
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            var entry = new Entry { Text = "Xamarin.Forms", ClearButtonVisibility = ClearButtonVisibility.WhileEditing };
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (username.Text == String.Empty || username.Text == null)
            {
                CrossToastPopUp.Current.ShowToastWarning("Please enter username", ToastLength.Long);
                return;
            }
            if (String.IsNullOrEmpty(password.Text))
            {
                CrossToastPopUp.Current.ShowToastWarning("Please enter password");
                return;
            }
            string user = username.Text;
            string pass = password.Text;
            if (pass != null && user != null)
            {
                await Navigation.PushAsync(new MainPage());
                Application.Current.Properties["Name"] = username.Text;
            }
        }
    }
}