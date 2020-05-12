using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfDataGrid
{
    /// <summary>
    /// Interaction logic for DispatcherTimerSample.xaml
    /// </summary>
    public partial class DispatcherTimerSample : Window
    {
        public DispatcherTimerSample()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();

            //ZONDER MILLISEC
            timer.Interval = TimeSpan.FromSeconds(1);
            //VOOR MILLISEC
            //timer.Interval=TimeSpan.FromMilliseconds(1);timer

            timer.Tick += timer_Tick; timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //ZONDER MILLISEC
            lblTime.Content = DateTime.Now.ToLongTimeString();
            //VOOR MILLISEC
            //lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");
        }

    }
}
