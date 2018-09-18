using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Crypto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Videocard> list;
        public List<CryptoValute> cv;
        public MainWindow()
        {
            InitializeComponent();


            cv = new List<CryptoValute>() { new CryptoValute() { Coef = 1.3, Name = "BTC", Value = 0 },
            new CryptoValute() { Coef = 0.8, Name = "ETH", Value = 0 },
            new CryptoValute() { Coef = 0.4, Name = "CAR", Value = 0 }};

            List<CryptoValute> cv2 = new List<CryptoValute>() { new CryptoValute() { Coef = 1.3, Name = "BTC", Value = 0 },
            new CryptoValute() { Coef = 0.8, Name = "ETH", Value = 0 },
            new CryptoValute() { Coef = 0.4, Name = "CAR", Value = 0 }};

            list = new ObservableCollection<Videocard>()
            {
                new Videocard(){Name="GTX 650",Power=400,Cryptos=cv},
                 new Videocard(){Name="GTX 1080",Power=700,Cryptos=cv2}
            };

      

            LbMain.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vid = LbMain.SelectedItem as Videocard;
            if (vid != null)
            {
                vid.StartThreading();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var vid = list.First(x => x == LbMain.SelectedItem);
            vid.StopThreading();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddWindow window = new AddWindow();
            window.ShowDialog();
            if (window.videocard == null)
                return;
            var tmp = window.videocard;
            tmp.Cryptos = cv;
            list.Add(tmp);

        }
    }
}
