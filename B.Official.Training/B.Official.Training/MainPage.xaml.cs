using System;
using Xamarin.Forms;

namespace B.Official.Training
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage("Home page"), true);
        }
    }
}
