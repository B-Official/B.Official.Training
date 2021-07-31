using B.Official.Training.Views;
using Xamarin.Forms;

namespace B.Official.Training
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage())
            {
                BarTextColor = Color.Black,
                BarBackgroundColor=Color.White
            };
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
