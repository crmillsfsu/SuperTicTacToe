using SuperTicTacToe.ViewModels;

namespace SuperTicTacToe
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void GoClicked(object sender, EventArgs e)
        {
            (BindingContext as MainViewModel)?.BuildBoard();
        }

        private void CellClicked(object sender, EventArgs e)
        {
            (BindingContext as MainViewModel)?.Refresh();
        }
    }

}
