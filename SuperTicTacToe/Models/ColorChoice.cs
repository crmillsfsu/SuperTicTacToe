using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTicTacToe.Models
{
    public class ColorChoice
    {
        public ColorChoice() { }

        public Color? Color { get; set; }
        public string? NameDisplay { get; set; }

        public override string ToString()
        {
            return NameDisplay ?? string.Empty;
        }
    }
}
