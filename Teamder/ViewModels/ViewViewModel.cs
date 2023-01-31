using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace Teamder.ViewModels
{
    public partial class ViewViewModel : BaseViewModel
    {
        [RelayCommand]
        public void Test()
        {
            Debug.WriteLine("Тест");
        }
    }
}
