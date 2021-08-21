using B.Official.Training.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B.Official.Training.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SigupPage : ContentPage
    {
        public SigupPage()
        {
            InitializeComponent();
            var vm = BindingContext as SigupViewModel;
            if (vm != null)
            {
                vm.Navigation = Navigation;
            }
        }
    }
}