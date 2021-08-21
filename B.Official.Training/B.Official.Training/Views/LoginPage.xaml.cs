using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B.Official.Training.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B.Official.Training.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var vm = (LoginViewModel)BindingContext;
            if (vm != null)
            {
                vm.Navigation = this.Navigation;
            }
        }
    }
}