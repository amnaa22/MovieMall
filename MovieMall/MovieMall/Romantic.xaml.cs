using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace MovieMall
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Romantic : ContentPage
    {
        public Romantic()
        {
            InitializeComponent();
        }

        private void TheLastSong_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TheLastSong());
        }
        private void Ice_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ice());
        }
        private void InProgress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InProgress());
        }
    }
}