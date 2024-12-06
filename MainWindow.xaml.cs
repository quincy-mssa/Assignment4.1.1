using System.Collections.Generic;
using System.Windows;

namespace Assignment_4._1._1
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, Person> persons;

        public MainWindow()
        {
            InitializeComponent();

            persons = MockData.CreateData();

            ContactData.ItemsSource = persons.Values;
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            string searchName = txtSearch.Text;

            if (persons.TryGetValue(searchName, out Person person))
            {
                datagrid2.ItemsSource = new List<Person> { person };
            }
            else
            {
                datagrid2.ItemsSource = null;
                MessageBox.Show("No match found.", "Search Result");
            }
        }
    }
}
