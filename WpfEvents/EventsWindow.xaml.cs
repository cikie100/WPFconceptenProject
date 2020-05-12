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

namespace WPFconceptenDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EventsSample : Window
    {
        public EventsSample()
        {
            InitializeComponent();
            //tekst toont pas wnnr je muisknop los laat
            pnlMainGrid.MouseUp += new MouseButtonEventHandler(pnlMainGrid_MouseUp);
            //tekst toont meteen zodra je klikt
            pnlMainGrid.MouseDown += new MouseButtonEventHandler(pnlMainGrid_MouseDown);
        }

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //zodat het slechts 1 keer toont en niet een 2de keer wanneer u op "OK" drukt
            if (e.GetPosition(this).X >= 0 && e.GetPosition(this).Y >= 0)  {
                MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
            }
        }

        private void pnlMainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //zodat het slechts 1 keer toont en niet een 2de keer wanneer u op "OK" drukt
            if (e.GetPosition(this).X >= 0 && e.GetPosition(this).Y >= 0)
            {
                MessageBox.Show("You clicked " + e.GetPosition(this).ToString());
            }
        }
    }
}
