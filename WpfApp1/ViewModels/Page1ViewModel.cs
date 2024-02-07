using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Models;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class Page1ViewModel:BaseViewModel
    {

        private RelayCommand _toPage1Command;
        public RelayCommand ToPage1Command
        {
            get
            {
                return _toPage1Command ??
                  (_toPage1Command = new RelayCommand(obj =>
                  {
                      toPage1();
                  }));
            }
        }
        public void toPage1()
        {
            mainFrame = new Frame();
            mainFrame.NavigationService.Navigate(new Page2());
        }

        public Page1ViewModel()
        {

        }
        

    }
}
