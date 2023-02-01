using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamder.ViewModels
{
    public partial class SignUpVM : BaseViewModel
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignUpCommand))]
        public string username;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(SignUpCommand))]
        public string password;

        [ObservableProperty]
        public string logging = "false";
        public bool CanSignIn => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);

        public SignUpVM()
        {
            Logging = "false";
        }

        [RelayCommand(CanExecute = "CanSignIn")]
        private void SignUp()
        {
            Logging = "true";
            Shell.Current.DisplayAlert("Debug", Username + "\n" + Password, "ok");
        }
    }
}
