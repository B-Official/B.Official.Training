using B.Official.Training.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace B.Official.Training.ViewModels
{
    class HomeViewModel
    {
        public ObservableCollection<FoodModel> ProductData { get; set; }
        public HomeViewModel()
        {
            ProductData = new ObservableCollection<FoodModel>(new List<FoodModel>
            {
                new FoodModel{Price="9",TitleItem="Lentil Salad",ContentItem="Discover the newest hand-picked palettes of Color Hunt",ColorItem="#F2E1C1",ImageItem="burger.png"},
                new FoodModel{Price="12",TitleItem="Lentil Salad",ContentItem="Discover the newest hand-picked palettes of Color Hunt",ColorItem="#C400FF",ImageItem="french_fries.png"},
                new FoodModel{Price="15",TitleItem="Lentil Salad",ContentItem="Discover the newest hand-picked palettes of Color Hunt",ColorItem="#FFA0A0",ImageItem="hot_dog.png"},
                new FoodModel{Price="5",TitleItem="Lentil Salad",ContentItem="Discover the newest hand-picked palettes of Color Hunt",ColorItem="#ACFFAD",ImageItem="noodles.png"},
            });
        }
    }
}
