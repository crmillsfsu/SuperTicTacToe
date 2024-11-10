namespace SuperTicTacToe.Views;

public partial class StartScreen : ContentPage
{
	public StartScreen()
	{
		InitializeComponent();
	}

    private void PlayClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Game");
    }

    private void ExitClicked(object sender, EventArgs e)
    {
        Application.Current?.Quit();
    }
}