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

        public List<int> RowColumnSelectionOptions { 
            get
            {
                return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            }
        }

        public List<ColorChoice> SymbolColorOptions
        {
            get
            {
                return new List<ColorChoice> {
                    new ColorChoice {Color = Colors.Blue, NameDisplay = "Blue" }
                    , new ColorChoice {Color = Colors.Green, NameDisplay = "Green" }
                    , new ColorChoice { Color = Colors.Red, NameDisplay = "Red" }
                    , new ColorChoice { Color = Colors.Purple, NameDisplay = "Purple" }
                    , new ColorChoice {Color = Colors.Orange, NameDisplay = "Orange" }
                };
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
                return new ObservableCollection<Row>(GameService.Current?.Rows ?? new List<Row>());
            }
        }

        public Player? Player1 { get; set; }
        public Player? Player2 { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {
            Player1 = new Player();
            Player2 = new Player();
        }

        //public void BuildBoard()
        //{
        //    Rows = new ObservableCollection<Row>();
        //    for(int i = 0; i < SelectedRows; i++)
        //    {
        //        Rows.Add(new Row());
        //        for(int j= 0; j < SelectedColumns; j++)
        //        {
        //            Rows[i]?.Columns?.Add(new Cell($" "));
        //        }
        //    }

        //    NotifyPropertyChanged("Rows");
        //}

        public void Refresh()
        {
            NotifyPropertyChanged("Rows");
        }
    }
}
