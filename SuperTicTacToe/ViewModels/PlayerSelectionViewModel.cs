using SuperTicTacToe.Models;
using SuperTicTacToe.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTicTacToe.ViewModels
{
    public class PlayerSelectionViewModel
    {
        public ObservableCollection<ColorChoice> SymbolColorOptions
        {
            get
            {
                return new ObservableCollection<ColorChoice>(GameService.Current.SymbolColorOptions);
            }
        }

        public Player? Player1
        {
            get
            {
                return GameService.Current.Player1;
            }
        }

        public Player? Player2
        {
            get
            {
                return GameService.Current.Player2;
            }
        }
    }
}
