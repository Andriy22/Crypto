using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public class CryptoValute:INotifyPropertyChanged
    {
        private double IPVAlue;
        public string Name{get;set;}
        public double Value
        {
            get
            {
                return IPVAlue;
            }
            set
            {
                IPVAlue = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("Value"));
            }
        }
        public double Coef { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
