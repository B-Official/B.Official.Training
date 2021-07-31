using B.Official.Training.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace B.Official.Training.ViewModels
{
    public class DetailViewModel : INotifyPropertyChanged
    {
        private DeviceModel device;

        public DeviceModel Device { get => device; set { device = value; NotifyPropertyChanged("Device"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public DetailViewModel()
        {

        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
