using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamder.ViewModels
{
    public partial class SingInVM : BaseViewModel
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignInCommand))]
        public string login;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignInCommand))]
        public string password;

        [ObservableProperty]
        public string logging = "false";
        public bool CanSignIn  => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password);

        public SingInVM()
        {
            Logging = "false";
        }

        [RelayCommand(CanExecute = "CanSignIn")]
        private void SignIn()
        {
            Logging = "true";
            Shell.Current.DisplayAlert("Debug", Login + "\n" + Password, "ok");
        }
    }
}
