using System;
using System.Collections.Generic;
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
using System.IO;

namespace mathiasznapok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                //Beolvasas//
                List<feladatok> list = new List<feladatok>();
                StreamReader sr = new StreamReader("");  
                
                while (!sr.EndOfStream)
                {
                    list.Add(new feladatok(sr.ReadLine(),';'));
                }
            }
            catch (Exception hiba)
            {

                MessageBox.Show(hiba.Message);
            }
        }
    }
}
