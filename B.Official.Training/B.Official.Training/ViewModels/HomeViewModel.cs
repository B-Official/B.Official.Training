using System.ComponentModel;
using System.Runtime.CompilerServices;
using B.Official.Training.Annotations;
using B.Official.Training.Models;

namespace B.Official.Training.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private UserModel _user;

        public UserModel User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}