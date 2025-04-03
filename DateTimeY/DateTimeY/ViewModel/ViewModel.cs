using System.Collections.ObjectModel;

namespace DateTimeY
{
    public class ViewModel
    {
        public ObservableCollection<DataModel> SleepData { get; set; }

        public ViewModel()
        {
            SleepData = new ObservableCollection<DataModel>()
            {
                new() { Day = "Monday", Duration = new DateTime(2025, 2, 10, 7, 30, 0) },
                new() { Day = "Tuesday", Duration = new DateTime(2025, 2, 11, 6, 45, 0) },
                new() { Day = "Wednesday", Duration = new DateTime(2025, 2, 12, 8, 0, 0) },
                new() { Day = "Thursday", Duration = new DateTime(2025, 2, 13, 5, 50, 0) },
                new() { Day = "Friday", Duration = new DateTime(2025, 2, 14, 7, 15, 0) },
                new() { Day = "Saturday", Duration = new DateTime(2025, 2, 15, 9, 0, 0) },
                new() { Day = "Sunday", Duration = new DateTime(2025, 2, 16, 8, 30, 0) }
            };
        }
    }
}
