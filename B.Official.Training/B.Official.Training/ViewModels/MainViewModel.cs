using B.Official.Training.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace B.Official.Training.ViewModels
{
    class MainViewModel 
    {
        public ICommand LestStartCommand { get; set; }
        public INavigation Navigation { get; set; }
        public MainViewModel()
        {
            LestStartCommand = new Command(LestStart);
        }

        private async void LestStart(object obj)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
