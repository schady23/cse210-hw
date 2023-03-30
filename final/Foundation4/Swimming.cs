public class SwimmingActivity : Activity
    {
        public int Laps { get; set; }

        public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return Laps * 50 / 1000.0;
        }

        public override double GetSpeed()
        {
            return GetDistance() / (Length / 60.0);
        }

        public override string GetPace()
        {
            double paceSeconds = (Length * 60.0) / GetDistance();
            int minutes = (int)(paceSeconds / 60);
            int seconds = (int)(paceSeconds % 60);
            return String.Format("{0}.{1:00} min per km", minutes, seconds);
        }

        public override string GetSummary()
        {
            return String.Format("{0} Swimming ({1} min) - Distance {2:F1} km, Speed {3:F1} kph, Pace: {4}",
                Date.ToString("dd MMM yyyy"), Length, GetDistance(), GetSpeed(), GetPace());
        }
    }