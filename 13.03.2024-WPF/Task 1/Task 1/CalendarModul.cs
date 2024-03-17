using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Task_1
{

    internal class CalendarModul
    {
        public string addDateTolist(string date, List<string> selectedDates)
        {
            MainWindow mainWindow = new MainWindow();
            string selectedDate = date;

            if (!selectedDates.Contains(selectedDate))
            {               
                return selectedDate;
            }
            return "0";
        }
    }
}
