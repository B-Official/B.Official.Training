using B.Official.Training.Models;
using B.Official.Training.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace B.Official.Training.ViewModels
{
    public class HomeViewModel
    {
        public INavigation NavigationPage { get; set; }
        public ObservableCollection<DeviceModel> DeviceData { get; set; } = new ObservableCollection<DeviceModel>
        {
            new DeviceModel
            {
                Image="house_living_room_icon.png",
                NameRoom="Living Room",
                NumberDevice="5",
                Colorbg="#F8485E"
            },
            new DeviceModel
            {
                Image="cooking_food_hot_kitchen_icon.png",
                NameRoom="Kitchen",
                NumberDevice="4",
                Colorbg="#F5FDB0"
            },
            new DeviceModel
            {
                Image="office_paper_printer_icon.png",
                NameRoom="Office",
                NumberDevice="10",
                Colorbg="#5089C6"
            },
            new DeviceModel
            {
                Image="bedroom_icon.png",
                NameRoom="Bedroom",
                NumberDevice="6",
                Colorbg="#F6AE99"
            },
            new DeviceModel
            {
                Image="bathroom_icon.png",
                NameRoom="Bathroom",
                NumberDevice="7",
                Colorbg="#53B8BB"
            },
            new DeviceModel
            {
                Image="dining_room_icon.png",
                NameRoom="Dining Room",
                NumberDevice="4",
                Colorbg="#A73489"
            },

        };
        public ICommand SelectItemCommand { get; private set; }
        public HomeViewModel()
        {
            SelectItemCommand = new Command((obj)=> SelectItem(obj));
        }

        private void SelectItem(object obj)
        {
            if(obj != null)
            {
                var data = (DeviceModel)obj;
                NavigationPage.PushAsync(new DetailPage(data));
            }
        }
    }
}