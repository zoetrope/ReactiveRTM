using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Data
{
    public class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            var p = PropertyChanged;
            if (p != null)
            {
                p(this, new PropertyChangedEventArgs(name));
            }
        }
    } 
}
