namespace MvvM_Notes.Views;
using MvvM_Notes.ViewModels;

public partial class NotesListPage : ContentPage
{
	public NotesListPage()
	{
		InitializeComponent();
        BindingContext = new NotesListViewModel() { Navigation = this.Navigation };
    }
}