using B.Official.Training.Models;
using B.Official.Training.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B.Official.Training.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(DeviceModel device)
        {
            InitializeComponent();
            var vm = (DetailViewModel)BindingContext;
            if (vm != null)
            {
                vm.Device = device;
            }
        }
    }
}