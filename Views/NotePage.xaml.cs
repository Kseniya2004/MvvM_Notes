namespace MvvM_Notes.Views;
using MvvM_Notes.ViewModels;

public partial class NotePage : ContentPage
{
    public NoteViewModel ViewModel { get; private set; }
    public NotePage(NoteViewModel vm)
    {
        InitializeComponent();
        ViewModel = vm;
        this.BindingContext = ViewModel;
    }
}