using System;
using System.Collections.ObjectModel;


namespace CanadaHolidaysApp.ViewModels
{
    public class HolidaysViewModel
    {
        public ObservableCollection<Holiday> Holidays { get; private set; }

        public HolidaysViewModel()
        {
            Holidays = new ObservableCollection<Holiday>
            {
                new Holiday { Name = "New Year's Day", Date = new DateTime(DateTime.Now.Year, 1, 1) },
                new Holiday { Name = "Good Friday", Date = new DateTime(DateTime.Now.Year, 4, 15) },
                new Holiday { Name = "Victoria Day", Date = new DateTime(DateTime.Now.Year, 5, 24) },
                new Holiday { Name = "Canada Day", Date = new DateTime(DateTime.Now.Year, 7, 1) },
                new Holiday { Name = "Civic Day", Date = new DateTime(DateTime.Now.Year, 8, 2) },
                new Holiday { Name = "Labour Day", Date = new DateTime(DateTime.Now.Year, 9, 6) },
                new Holiday { Name = "Thanksgiving", Date = new DateTime(DateTime.Now.Year, 10, 11) },
                new Holiday { Name = "Remembrance Day", Date = new DateTime(DateTime.Now.Year, 11, 11) },
                new Holiday { Name = "Christmas Day", Date = new DateTime(DateTime.Now.Year, 12, 25) },
                new Holiday { Name = "Boxing Day", Date = new DateTime(DateTime.Now.Year, 12, 26) }
            };
        }
    }
}
