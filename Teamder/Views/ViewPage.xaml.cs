namespace Teamder.Views;

public partial class ViewPage : ContentPage
{
	public ViewPage()
	{
		InitializeComponent();
		BindingContext = new ViewViewModel();
	}
}