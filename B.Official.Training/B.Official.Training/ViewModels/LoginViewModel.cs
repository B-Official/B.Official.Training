using System.Windows.Input;
using B.Official.Training.Models;
using B.Official.Training.Services;
using B.Official.Training.Views;
using Xamarin.Forms;

namespace B.Official.Training.ViewModels
{
    public class LoginViewModel
    {
        private DatabaseService _database;
        public UserModel User { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand SigupCommand { get; set; }
        public INavigation Navigation { get; set; }
        public LoginViewModel()
        {
            _database = new DatabaseService();
            User = new UserModel();
            LoginCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.UserName) || string.IsNullOrEmpty(User.Password))
                {
                    await App.Current.MainPage.DisplayAlert("Thông báo", "Điền đầy đủ thông tin", "OK");
                }
                else
                {
                    // xu ly logic khi dang nhap
                    var data = await _database.Login(User);
                    if (data != null)
                    {
                        await App.Current.MainPage.DisplayAlert("Thông báo", "Đăng nhập thành công", "OK");
                        await Navigation.PushAsync(new HomePage(data), true);
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Thông báo", "Tài khoản hoặc mật khảu sai", "OK");
                    }
                }
            });
            SigupCommand = new Command(Sigup);
        }

        private async void Sigup()
        {
            await Navigation.PushAsync(new SigupPage(), true);
        }
    }
}