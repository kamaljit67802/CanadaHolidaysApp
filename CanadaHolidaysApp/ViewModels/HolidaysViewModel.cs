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
                new Holiday { Name = "St. Patrick's Day", Date = new DateTime(DateTime.Now.Year, 3, 17) },
                new Holiday { Name = "St. George's Day", Date = new DateTime(DateTime.Now.Year, 4, 23) },
                new Holiday { Name = "National Aboriginal Day", Date = new DateTime(DateTime.Now.Year, 6, 21) },
                new Holiday { Name = "Féte Nationale", Date = new DateTime(DateTime.Now.Year, 6, 24) },
                new Holiday { Name = "Discovery Day", Date = new DateTime(DateTime.Now.Year, 6, 24) },
                new Holiday { Name = "Canada Day", Date = new DateTime(DateTime.Now.Year, 7, 1) },
                new Holiday { Name = "Nunavut Day", Date = new DateTime(DateTime.Now.Year, 7, 9) },
                new Holiday { Name = "National Day for Truth and Reconciliation", Date = new DateTime(DateTime.Now.Year, 9, 30) },
                new Holiday { Name = "Remembrance Day", Date = new DateTime(DateTime.Now.Year, 11, 11) },
                new Holiday { Name = "Christmas Day", Date = new DateTime(DateTime.Now.Year, 12, 25) },
                new Holiday { Name = "Boxing Day", Date = new DateTime(DateTime.Now.Year, 12, 26) },
            };
        }
    }
}
