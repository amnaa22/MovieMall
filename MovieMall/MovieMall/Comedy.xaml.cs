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
    public partial class Comedy : ContentPage
    {
        public Comedy()
        {
            InitializeComponent();
        }

        private void InProgress_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InProgress());
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hangover());
        }
        private void TheAdamProject_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TheAdamProject());
        }
    }
}