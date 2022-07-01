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
    public partial class ThePurge : ContentPage
    {
        public ThePurge()
        {
            InitializeComponent();
            ispisiusername.Text = Application.Current.Properties["Name"].ToString();
        }

        private void print_Clicked(object sender, EventArgs e)
        {
            int stars = Rating.SelectedStarValue;
            komentar.IsVisible = false;
            print.IsVisible = false;
            ocjena.IsVisible = false;
            avatar.IsVisible = true;
            ispisiusername.IsVisible = true;
            printkomentar.IsVisible = true;
            printkomentar.Text = "Your comment: " + komentar.Text;
            yourReview.IsVisible = true;
            yourReview.Text = "Your star review: " + Convert.ToString(stars);
        }

    }
}