using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aval1
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _mainText = "Çağrılmış Kafatası";
        public int howMany = 0;
        public string MainText
        {
            get
            {
                return _mainText;
            }
            set
            {
                _mainText = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(MainText)));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void ButtonClicked()
        {
            howMany++;
            MainText = "Butona Bastım"+howMany;
        }
    }
}
