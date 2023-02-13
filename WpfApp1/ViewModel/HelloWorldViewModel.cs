using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class HelloWorldViewModel : INotifyPropertyChanged
    {
        private string helloString;
        public event PropertyChangedEventHandler PropertyChanged;

        public string HelloString
        {
            get { return helloString; }
            set
            {
                helloString = value;
                // we call propertychanged in set
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public HelloWorldViewModel ()
        {
            HelloWorldModel helloWorldModel= new HelloWorldModel();
            helloString = helloWorldModel.ImportantInfo;
        }
    }
}
