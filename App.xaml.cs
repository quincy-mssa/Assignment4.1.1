using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_4._1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Dictionary<string, Person> persons;
        public MainWindow()
        {
            InitializeComponent();
            persons = MockData.CreateData();
            ContactData.ItemsSource = persons.Values;
        }
        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            if (persons.TryGetValue(txtSearch.Text, out Person person))
            {
                datagrid2.ItemsSource = person;
            }
        }
    }
}