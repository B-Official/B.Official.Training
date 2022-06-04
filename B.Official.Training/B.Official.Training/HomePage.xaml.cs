
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B.Official.Training
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage(string title)
        {
            InitializeComponent();
            Title = title;
        }
    }
}