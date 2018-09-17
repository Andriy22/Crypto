using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Crypto
{
    public class Videocard
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public List<CryptoValute> Cryptos { get; set; }
        public CryptoValute CurrentCrypto { get; set; }
        Thread th;

        public Videocard()
        {
           

           

        }
        public void StartThreading()
        {
            th = new Thread(Func);
            th.IsBackground = true;
            th.Start();
        }
        public void StopThreading()
        {
            th.Abort();
        }
        public void Func()
        {


            while(true)
            {
                CurrentCrypto.Value += CurrentCrypto.Coef;
                Thread.Sleep(1000 - Power);
            }
        }
    }
}
