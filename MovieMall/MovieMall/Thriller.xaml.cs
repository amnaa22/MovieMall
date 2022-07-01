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
    public partial class Thriller : ContentPage
    {

        public Thriller()
        {
            InitializeComponent();
        }

        private void InProgress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InProgress());
        }
        private void Split_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Split());
        }
        private void ThePurge_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThePurge());
        }
    }
}