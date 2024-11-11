using SuperTicTacToe.Models;
using SuperTicTacToe.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Cell = SuperTicTacToe.Models.Cell;

namespace SuperTicTacToe.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public GameService GameService
        {
            get
            {
                return GameService.Current;
            }
        }

        public int SelectedRows { 
            get { 
                return GameService.Current.SelectedRows;
            } 
        }
        public int SelectedColumns { 
            get
            {
                return GameService.Current.SelectedColumns;
            }
        }

        public ObservableCollection<Row>? Rows {
            get
            {
                return GameService.Current?.Rows;
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

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int playerCounter;

        private int symbolCounter;

        public bool IsPlayer1Turn
        {
            get
            {
                return playerCounter % 2 == 0;
            }
        }

        public bool IsPlayer2Turn
        {
            get
            {
                return playerCounter % 2 != 0;
            }
        }

        public MainViewModel()
        {
            playerCounter = 0;
            symbolCounter = 0;
        }

        public void Refresh()
        {
            NotifyPropertyChanged("Rows");
        }
    }
}
