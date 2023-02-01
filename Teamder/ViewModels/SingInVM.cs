using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teamder.Services;

namespace Teamder.ViewModels
{
    public partial class SingInVM : BaseViewModel
    {
        private readonly UserService _userService;
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignInCommand))]
        public string login;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignInCommand))]
        public string password;

        [ObservableProperty]
        public string logging = "false";
        public bool CanSignIn  => !string.IsNullOrWhiteSpace(Login) && !string.IsNullOrWhiteSpace(Password);

        public SingInVM(UserService userService)
        {
            _userService = userService;
            Logging = "false";
        }

        [RelayCommand(CanExecute = "CanSignIn")]
        private async Task SignIn()
        {
            Logging = "true";
            //Shell.Current.DisplayAlert("Debug", Login + "\n" + Password, "ok");

            await _userService.AuthorisationUserAsync(Login, Password);
        }
    }
}
