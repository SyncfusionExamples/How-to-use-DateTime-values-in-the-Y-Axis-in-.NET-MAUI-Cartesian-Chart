using Syncfusion.Maui.Toolkit.Charts;

namespace DateTimeY
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NumericalAxis_LabelCreated(object sender, ChartAxisLabelEventArgs e)
        {
            if (double.TryParse(e.Label, out double minutes))
            {
                TimeSpan time = TimeSpan.FromMinutes(minutes);
                e.Label = new DateTime(1, 1, 1, time.Hours, time.Minutes, 0).ToString("hh:mm tt");
            }
        }
    }
}
