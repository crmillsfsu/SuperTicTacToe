using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperTicTacToe.Models
{
    public class Player: INotifyPropertyChanged
    {
        public string? Name { get; set; }
        public char? Symbol1 { get; set; }

        private ColorChoice? color1;
        public ColorChoice? Color1 { 
            get
            {
                return color1;
            }

            set
            {
                if(color1 != value)
                {
                    color1 = value;
                }
                NotifyPropertyChanged();
            }
        }
        public char? Symbol2 { get; set;}

        public ColorChoice? color2;
        public ColorChoice? Color2 {
            get
            {
                return color2;
            }

            set
            {
                if (color2 != value)
                {
                    color2 = value;
                }
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
