using System;
using Groceries;
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

namespace Nabavka
{
    /// <summary>
    /// Interaction logic for MakeAListPage.xaml
    /// </summary>
    /// 
    struct ListOfGroceries
    {
        public String date;
        public String description;
        public List<String> items;

        public ListOfGroceries(String date, String description, List<String> items)
        {
            this.items = new List<String>();

            this.date = date;
            this.description = description;
            this.items = items;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

        public String getDate()
        {
            return this.date;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getDescription()
        {
            return this.description;
        }

        public void setList(List<String> items)
        {
            this.items = items;
        }

        public List<String> getList()
        {
            return this.items;
        }

        public void addItem(String item)
        {
            this.items.Add(item);
        }

        public void removeItem(String item)
        {
            this.items.Remove(item);
        }

    };


    public partial class MakeAListPage : Page
    {
        //GroceriesList gl = new GroceriesList();

        public MakeAListPage()
        {
            InitializeComponent();     
        }

        private void MakeAListBtn_Click(object sender, RoutedEventArgs e)
        {

            List<String> temp_list = itemList.Items.Cast<String>().ToList();
            ListOfGroceries l = new ListOfGroceries(this.dateTextBox.Text, this.itemTextBox.Text, temp_list);

            MessageBox.Show("Your list was succesfully created!"); 
        }

        private void addItemBtn_Click(object sender, RoutedEventArgs e)
        {
            if(this.itemTextBox.Text != "")
            {
                //gl.AddItemToTheList(this.itemTextBox.Text);

                itemList.Items.Add(this.itemTextBox.Text);
                this.itemTextBox.Focus();
                this.itemTextBox.Clear();
            }

            else
            {
                MessageBox.Show("Please enter an item for the list.","Error",MessageBoxButton.OK,MessageBoxImage.Information);
                this.itemTextBox.Focus();
            }
        }

        private void addDateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.dateTextBox.Text != "")
            {
                dateLabel.Content = this.dateTextBox.Text;
                this.dateTextBox.Focus();
                this.dateTextBox.Clear();
            }

            else
            {
                MessageBox.Show("Please enter a date for the list.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                this.dateTextBox.Focus();
            }
        }
    }
}
