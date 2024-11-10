using SuperTicTacToe.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperTicTacToe.ViewModels
{
    public class GameBoardSelectionViewModel:INotifyPropertyChanged
    {
        private GameService? gameService;
        public GameService? GameService
        {
            get
            {
                return gameService;
            }

            private set
            {
                gameService = value;
            }
        }

        public ObservableCollection<int> RowColumnSelectionOptions
        {
            get
            {
                return new ObservableCollection<int>(GameService?.RowColumnSelectionOptions ?? new List<int>());
            }
        }


        public GameBoardSelectionViewModel() {
            GameService = GameService.Current;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
