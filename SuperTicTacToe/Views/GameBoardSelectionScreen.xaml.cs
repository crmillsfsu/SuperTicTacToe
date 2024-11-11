using SuperTicTacToe.Services;
using SuperTicTacToe.ViewModels;

namespace SuperTicTacToe.Views;

public partial class GameBoardSelectionScreen : ContentPage
{
	public GameBoardSelectionScreen()
	{
		InitializeComponent();
		BindingContext = new GameBoardSelectionViewModel();
	}

    private void GoClicked(object sender, EventArgs e)
    {
		GameService.Current.BuildBoard();
		Shell.Current.GoToAsync("//PlayerSelection");
		
    }
}