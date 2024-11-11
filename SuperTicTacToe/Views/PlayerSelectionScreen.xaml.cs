using SuperTicTacToe.ViewModels;

namespace SuperTicTacToe.Views;

public partial class PlayerSelectionScreen : ContentPage
{
	public PlayerSelectionScreen()
	{
		InitializeComponent();
		BindingContext = new PlayerSelectionViewModel();
	}

    private void OkClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Game");
    }
    private void BackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//BoardSelection");
    }
}