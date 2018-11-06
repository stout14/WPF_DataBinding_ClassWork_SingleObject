using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DataBinding_ClassWork_SingleObject
{
    class Pereson : INotifyPropertyChanged
    {
        public string Name { get; set; }
        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                var pc = PropertyChanged;
                if(pc != null)
                {
                    pc(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
            
    }
}
