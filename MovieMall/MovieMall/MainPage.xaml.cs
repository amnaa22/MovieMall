using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace MovieMall
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Image> images = new List<Image>()
            {
                new Image(){Title="Avengers Endgame", Url="https://4.bp.blogspot.com/-scpSekAk66w/XMCesCQF4vI/AAAAAAAABuQ/0q2fgoYXV5waswTB1PkYELeK5zbNWc9qwCKgBGAs/w4096-h2304-c/avengers-endgame-characters-uhdpaper.com-4K-135.jpg"},
                new Image(){Title="Tomb Raider", Url="https://images.wallpapersden.com/image/download/alicia-vikander-tomb-raider-2018-movie_a2ZobWeUmZqaraWkpJRnamtlrWZpaWU.jpg"},
                new Image(){Title="Avatar", Url="https://cdn.wallpapersafari.com/55/11/XxfUto.jpg" },
                new Image(){Title="Aquaman", Url="https://i0.wp.com/ramenswag.com/wp-content/uploads/2019/02/Aquaman-Movie-Poster-2018_-HD-Movies_-4k-Wallpapers_-Images-....jpg?fit=2764%2C1554&ssl=1" },
                new Image(){Title="Thunder Force", Url="https://images.wallpapersden.com/image/wxl-melissa-mccarthy-thunder-force_76985.jpg" },
                new Image(){Title="The Adam Project", Url="https://images.wallpapersden.com/image/download/the-adam-project-4k_bWdmaWeUmZqaraWkpJRpZW5rrWdoZWk.jpg" },
                new Image(){Title="The Last Song", Url="https://img1.hotstarext.com/image/upload/f_auto,t_web_m_1x/sources/r1/cms/prod/6608/666608-h" },
                new Image(){Title="Ice", Url="https://popkult.org/wp-content/uploads/2018/03/%D0%BB%D1%91%D0%B4-%D0%BB%D0%B5%D0%B4-ice-1.png" },
                new Image(){Title="Choose Or Die", Url="https://hype.my/wp-content/uploads/2022/04/Choose-Or-Die-2-1.jpg" },
                new Image(){Title="Split", Url="https://www.fortressofsolitude.co.za/wp-content/uploads/2020/06/Split-Petition-Calls-For-Removal-Of-M-Night-Shyamalan%E2%80%99s-Movie-From-Netflix.jpg" }
            };

            Carousel.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(3), (() =>
            {
                Carousel.Position = (Carousel.Position + 1) % images.Count;
                return true;
            }));
        }

        private void Action_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Action());
        }
        private void Romantic_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Romantic());
        }
        private void Thriller_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Thriller());
        }
        private void Comedy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Comedy());
        }
        private void Fantasy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fantasy());
        }
    }
}
