namespace TeamderStaff.ViewModels
{
    public class mWindowViewModel : BindableBase
    {
        public DelegateCommand TestCommand => new(() => 
        {
            Debug.WriteLine("Тест");
        });
    }
}
