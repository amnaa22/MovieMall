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
    public partial class Action : ContentPage
    {
        public Action()
        {
            InitializeComponent();
        }

        private void FastAndFurious_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FastAndFurious());
        }
        private void Avengers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Avengers());
        }
        private void RedNotice_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RedNotice());
        }
        private void TombRaider_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TombRaider());
        }
        private void InProgress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InProgress());
        }

    }
}