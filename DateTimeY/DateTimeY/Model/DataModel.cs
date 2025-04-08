namespace DateTimeY
{
    public class DataModel
    {
        public string? Day { get; set; }

        public DateTime Duration { get; set; }

        public double DurationInMinutes => Duration.Hour * 60 + Duration.Minute;
    }
}
