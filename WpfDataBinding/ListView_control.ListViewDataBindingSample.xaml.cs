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
    
    public partial class ListViewDataBindingSample : Window
    {
        public ListViewDataBindingSample()
        {
            InitializeComponent();
            List<User2> items = new List<User2>(); 
            items.Add(new User2() { Name = "John Doe", Age = 42 }); 
            items.Add(new User2() { Name = "Jane Doe", Age = 39 }); 
            items.Add(new User2() { Name = "Sammy Doe", Age = 13 });
            
            lvDataBinding.ItemsSource = items;
        }
    }
    public class User2{
        public string Name { get; set; }
public int Age { get; set; }
        public override string ToString() { return this.Name + ", " + this.Age + " years old"; }
    }

}
