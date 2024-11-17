using SuperTicTacToe.Models;
using System.Collections.ObjectModel;
using Cell = SuperTicTacToe.Models.Cell;
namespace SuperTicTacToe.Services
{
    public class GameService
    {
        public List<int> RowColumnSelectionOptions
        {
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

        public void BuildBoard()
        {
            Rows = new ObservableCollection<Row>();
            for (int i = 0; i < SelectedRows; i++)
            {
                Rows.Add(new Row());
                for (int j = 0; j < SelectedColumns; j++)
                {
                    Rows[i]?.Columns?.Add(new Cell($" "));
                }
            }
        }

        public int SelectedRows { get; set; }
        public int SelectedColumns { get; set; }

        public ObservableCollection<Row>? Rows { get; set; }

        public Player? Player1 { get; set; }
        public Player? Player2 { get; set; }

        public string? CurrentPlayerMoveDisplay
        {
            get
            {
                var returnVal = string.Empty;

                if(CurrentPlayer == 0)
                {
                    returnVal = CurrentSymbol == 0 ? Player1?.Symbol1.ToString() : Player1?.Symbol2.ToString();
                }
                else
                {
                    returnVal = CurrentSymbol == 0 ? Player2?.Symbol1.ToString() : Player2?.Symbol2.ToString();
                }

                return returnVal;
            }
        }

        public Color? CurrentPlayerMoveColor
        {
            get
            {
                Color? returnVal;

                if (CurrentPlayer == 0)
                {
                    returnVal = CurrentSymbol == 0 ? Player1?.Color1?.Color : Player1?.Color2?.Color ?? Colors.Black;
                }
                else
                {
                    returnVal = CurrentSymbol == 0 ? Player2?.Color1?.Color : Player2?.Color2?.Color ?? Colors.Black;
                }

                return returnVal;
            }
        }

        private int playerCounter;

        private int symbolCounter;

        public void AdvancePlayerCounter()
        {
            if(CurrentSymbol == 1)
            {
                playerCounter++;
            }
            symbolCounter++;

        }

        public int CurrentPlayer
        {
            get
            {
                return playerCounter % 2;
            }
        }

        public int CurrentSymbol
        {
            get
            {
                return symbolCounter % 2;
            }
        }

        private static GameService? instance;
        public static GameService Current
        {
            get
            {
                if(instance == null)
                {
                    instance = new GameService();
                }

                return instance;
            }
        }
        private GameService()
        {
            Player1 = new Player();
            Player2 = new Player();

            playerCounter = 0;
            symbolCounter = 0;
        }
    }
}
