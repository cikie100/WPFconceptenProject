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
using System.Windows.Shapes;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for ListView_control.xaml
    /// </summary>
    public partial class ListViewGridViewSample : Window
    {
        public ListViewGridViewSample()
        {
            InitializeComponent();
            List<User4> items = new List<User4>(); 
            items.Add(new User4() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            items.Add(new User4() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            items.Add(new User4() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" }); 
            
            lvUsers.ItemsSource = items;
        }
    }
    public class User4
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }}}
