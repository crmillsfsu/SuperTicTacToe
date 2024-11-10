using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SuperTicTacToe.Models
{
    public class Cell : INotifyPropertyChanged
    {
        public string? Display { get; set; }

        public Cell(string display)
        {
            ClickCommand = new Command(DoClick);
            Display = display;
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand ClickCommand { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void DoClick()
        {
            Display = "X";
            NotifyPropertyChanged("Display");
        }

        public Cell() {
            ClickCommand = new Command(DoClick);
        }

        public override string? ToString()
        {
            return Display;
        }
    }
}
