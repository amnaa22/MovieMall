using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieMall
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fantasy : ContentPage
    {
        public Fantasy()
        {
            InitializeComponent();
        }

        private void Aquaman_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Aquaman());
        }
        private void Avatar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Avatar());
        }
        private void InProgress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InProgress());
        }
    }
}