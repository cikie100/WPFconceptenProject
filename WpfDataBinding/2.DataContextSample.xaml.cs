using System.Windows;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for DataContextSample.xaml
    /// </summary>
    public partial class DataContextSample : Window
    {
        public DataContextSample()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}