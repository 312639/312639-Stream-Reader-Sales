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

namespace _312639Reader_Challange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        List<string> month2017 = new List<string>();
        List<string> month2018 = new List<string>();
            
      
        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader("2017.txt");
            System.IO.StreamReader streamReader2018 = new System.IO.StreamReader("2018.txt");

            while (!streamReader.EndOfStream)
            {
                month2018.Add(streamReader2018.ReadLine());
                month2017.Add(streamReader.ReadLine());
            }
            //Sales for 2017
            if ((bool)Jan.IsChecked) { lblOutput2017.Content = "$" + month2017[1]; }
            else if ((bool)Feb.IsChecked) { lblOutput2017.Content = "$" + month2017[2].ToString(); }
            else if ((bool)Mar.IsChecked) { lblOutput2017.Content = "$" + month2017[3].ToString(); }
            else if ((bool)Apr.IsChecked) { lblOutput2017.Content = "$" + month2017[4].ToString(); }
            else if ((bool)May.IsChecked) { lblOutput2017.Content = "$" + month2017[5].ToString(); }
            else if ((bool)Jun.IsChecked) { lblOutput2017.Content = "$" + month2017[6].ToString(); }
            else if ((bool)Jul.IsChecked) { lblOutput2017.Content = "$" + month2017[7].ToString(); }
            else if ((bool)Aug.IsChecked) { lblOutput2017.Content = "$" + month2017[8].ToString(); }
            else if ((bool)Sep.IsChecked) { lblOutput2017.Content = "$" + month2017[9].ToString(); }
            else if ((bool)Nov.IsChecked) { lblOutput2017.Content = "$" + month2017[11].ToString(); }
            else if ((bool)Dec.IsChecked) { lblOutput2017.Content = "$" + month2017[12].ToString(); }

            //Sales for 2018
            if ((bool)Jan.IsChecked) { lblOutput2018.Content = "$" + month2018[1].ToString(); }
            else if ((bool)Feb.IsChecked) { lblOutput2018.Content = "$" + month2018[2].ToString(); }
            else if ((bool)Mar.IsChecked) { lblOutput2018.Content = "$" + month2018[3].ToString(); }
            else if ((bool)Apr.IsChecked) { lblOutput2018.Content = "$" + month2018[4].ToString(); }
            else if ((bool)May.IsChecked) { lblOutput2018.Content = "$" + month2018[5].ToString(); }
            else if ((bool)Jun.IsChecked) { lblOutput2018.Content = "$" + month2018[6].ToString(); }
            else if ((bool)Jul.IsChecked) { lblOutput2018.Content = "$" + month2018[7].ToString(); }
            else if ((bool)Aug.IsChecked) { lblOutput2018.Content = "$" + month2018[8].ToString(); }
            else if ((bool)Sep.IsChecked) { lblOutput2018.Content = "$" + month2018[9].ToString(); }
            else if ((bool)Oct.IsChecked) { lblOutput2018.Content = "$" + month2018[10].ToString(); }
            else if ((bool)Nov.IsChecked) { lblOutput2018.Content = "$" + month2018[11].ToString(); }
            else if ((bool)Dec.IsChecked) { lblOutput2018.Content = "$" + month2018[12].ToString(); }

            //Average sales
            if ((bool)Jan.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[1])) + (double.Parse(month2018[1]))) / 2); }
            if ((bool)Feb.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[2])) + (double.Parse(month2018[2]))) / 2); }
            if ((bool)Mar.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[3])) + (double.Parse(month2018[3]))) / 2); }
            if ((bool)Apr.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[4])) + (double.Parse(month2018[4]))) / 2); }
            if ((bool)May.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[5])) + (double.Parse(month2018[5]))) / 2); }
            if ((bool)Jun.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[6])) + (double.Parse(month2018[6]))) / 2); }
            if ((bool)Jul.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[7])) + (double.Parse(month2018[7]))) / 2); }
            if ((bool)Aug.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[8])) + (double.Parse(month2018[8]))) / 2); }
            if ((bool)Sep.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[9])) + (double.Parse(month2018[9]))) / 2); }
            if ((bool)Oct.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[10])) + (double.Parse(month2018[10]))) / 2); }
            if ((bool)Nov.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[11])) + (double.Parse(month2018[11]))) / 2); }
            if ((bool)Dec.IsChecked) { lblOutputAverage.Content = ("The Average is $" + ((double.Parse(month2017[12])) + (double.Parse(month2018[12]))) / 2); }
        }
    }
}
