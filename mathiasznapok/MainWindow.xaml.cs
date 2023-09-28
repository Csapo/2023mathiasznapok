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

        List<feladatok> list = new List<feladatok>();

        public MainWindow()
        {
            InitializeComponent();

            string[] temp = File.ReadAllLines("adatok.txt");
            for (int i = 0; i < temp.Length; i++)
            {
                try
                {
                    list.Add(new feladatok(temp[i],';'));
                }
                catch(Exception baj) 
                {
                    MessageBox.Show(baj.Message);
                }
            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            name n = new name();
            n.Show();
            this.Close();
        }
    }
}
