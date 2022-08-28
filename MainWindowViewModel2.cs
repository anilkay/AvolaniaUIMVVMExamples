using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aval1
{
    public partial  class MainWindowViewModel2:ObservableObject
    {
        [ObservableProperty]
        public string mainText="Çağrılmış Kafatası";
        private int howMany = 0;
        [RelayCommand]
        void ButtonClicked()
        {
            howMany++;
            MainText = "Butona Bastım" + howMany;
        }
    }
}
