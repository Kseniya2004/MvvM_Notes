namespace MvvM_Notes;
using MvvM_Notes.Views;

public partial class App : Application
{
    public App()
    {
        MainPage = new NavigationPage(new NotesListPage());
    }

    protected override void OnStart()
    { }

    protected override void OnSleep()
    { }

    protected override void OnResume()
    { }
}
