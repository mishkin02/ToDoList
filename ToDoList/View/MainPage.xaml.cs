using ToDoList.ViewModel;

namespace ToDoList;

public partial class MainPage : ContentPage
{
	public MainPage(ToDoListViewModel viewModle)
	{
		InitializeComponent();
		BindingContext = viewModle;
    }
}

