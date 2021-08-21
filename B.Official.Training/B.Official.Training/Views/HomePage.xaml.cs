using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B.Official.Training.Models;
using B.Official.Training.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B.Official.Training.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage(UserModel user)
        {
            InitializeComponent();
            var vm = BindingContext as HomeViewModel;
            if (vm != null)
            {
                vm.User = user;
            }
        }
    }
}