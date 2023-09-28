using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace mathiasznapok
{
    /// <summary>
    /// Interaction logic for game.xaml
    /// </summary>
    public partial class game : Window
    {
        DirectoryInfo d; //képeket tartalamzó mappa információi
        FileInfo[] Files; //mappában található állományok tölbje
        int imageIndex = 0; //Hányadik képnél tartunk?

        public game()
        {
            InitializeComponent();
           
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D)
            {


                if (player.Margin.Right < 100)
                {
                    d = new DirectoryInfo("walkR"
                ); //Mappa megadása           
                    Files = d.GetFiles("*.*"); //képek összegyűjtése
                    imageIndex++;
                    if (imageIndex == Files.Length)
                        imageIndex = imageIndex - Files.Length;

                    BitmapImage BMI = new BitmapImage();
                    BMI.BeginInit();
                    BMI.UriSource = new Uri(d.FullName + @"\" + Files[imageIndex]);
                    BMI.DecodePixelWidth = 50;
                    BMI.EndInit();
                    player.Source = BMI;
                    player.Width = BMI.Width;
                    player.Height = BMI.Height;

                    Thickness newMargin = player.Margin;

                    newMargin.Left += 15;


                    player.Margin = newMargin;
                }


            }

            if (e.Key == Key.A)
            {
                d = new DirectoryInfo("walkL"
              ); //Mappa megadása           
                Files = d.GetFiles("*.*"); //képek összegyűjtése
                imageIndex++;
                if (imageIndex == Files.Length)
                    imageIndex = imageIndex - Files.Length;

                BitmapImage BMI = new BitmapImage();
                BMI.BeginInit();
                BMI.UriSource = new Uri(d.FullName + @"\" + Files[imageIndex]);
                BMI.DecodePixelWidth = 50;
                BMI.EndInit();
                player.Source = BMI;
                player.Width = BMI.Width;
                player.Height = BMI.Height;

                Thickness newMargin = player.Margin;

                newMargin.Left -= 15;


                player.Margin = newMargin;
            }

            if (e.Key == Key.W)
            {
                d = new DirectoryInfo("frontwalk"
              ); //Mappa megadása           
                Files = d.GetFiles("*.*"); //képek összegyűjtése
                imageIndex++;
                if (imageIndex == Files.Length)
                    imageIndex = imageIndex - Files.Length;

                BitmapImage BMI = new BitmapImage();
                BMI.BeginInit();
                BMI.UriSource = new Uri(d.FullName + @"\" + Files[imageIndex]);
                BMI.DecodePixelWidth = 50;
                BMI.EndInit();
                player.Source = BMI;
                player.Width = BMI.Width;
                player.Height = BMI.Height;

                Thickness newMargin = player.Margin;

                newMargin.Top -= 15;


                player.Margin = newMargin;
            }

            if (e.Key == Key.S)
            {
                d = new DirectoryInfo("backwalk"
              ); //Mappa megadása           
                Files = d.GetFiles("*.*"); //képek összegyűjtése
                imageIndex++;
                if (imageIndex == Files.Length)
                    imageIndex = imageIndex - Files.Length;

                BitmapImage BMI = new BitmapImage();
                BMI.BeginInit();
                BMI.UriSource = new Uri(d.FullName + @"\" + Files[imageIndex]);
                BMI.DecodePixelWidth = 50;
                BMI.EndInit();
                player.Source = BMI;
                player.Width = BMI.Width;
                player.Height = BMI.Height;

                Thickness newMargin = player.Margin;

                newMargin.Top += 15;


                player.Margin = newMargin;
            }


        }
    }
}
