using System.Collections.Generic;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;

namespace Task_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> selectedDates = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {     

          
            CalendarModul calendarModul = new CalendarModul();

            string date = calendarModul.addDateTolist(ChooseCalendar.SelectedDate.Value.ToString(), selectedDates);

            if (date != "0")
            {
                ListBox.Items.Add(date);
                selectedDates.Add(date);
            }
            else
            {
                MessageBox.Show("Already reserved");             
            }
           
        }
    }
   
    
}
