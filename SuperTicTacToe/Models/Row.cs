using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTicTacToe.Models
{
    public class Row
    {
        public ObservableCollection<Cell>? Columns { get; set; }

        public Row() { 
            Columns = new ObservableCollection<Cell>();
        }
    }
}
