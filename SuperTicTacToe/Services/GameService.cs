using SuperTicTacToe.Models;
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
            Rows = new List<Row>();
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

        public List<Row>? Rows { get; set; }

        public Player? Player1 { get; set; }
        public Player? Player2 { get; set; }

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
        }
    }
}
