using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp1.Models;
using WpfApp1.Views;


namespace WpfApp1.ViewModels
{
    public class BaseViewModel:INotifyPropertyChanged
    {
   
        public Frame mainFrame { get; set; }
        public BaseViewModel() {

            mainFrame = new Frame();
        }

        public void OnInitialize()
        {
            mainFrame.NavigationService.Navigate(new Page1());
        }
       

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
