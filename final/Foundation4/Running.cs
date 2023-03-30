public class RunningActivity : Activity
    {
        public double Distance { get; set; }

        public RunningActivity(DateTime date, int length, double distance) : base(date, length)
        {
            Distance = distance;
        }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return Distance / (Length / 60.0);
        }

        public override string GetPace()
        {
            double paceSeconds = (Length * 60.0) / Distance;
            int minutes = (int)(paceSeconds / 60);
            int seconds = (int)(paceSeconds % 60);
            return String.Format("{0}.{1:00} min per mile", minutes, seconds);
        }

        public override string GetSummary()
        {
            return String.Format("{0} Running ({1} min) - Distance {2:F1} miles, Speed {3:F1} mph, Pace: {4}",
                Date.ToString("dd MMM yyyy"), Length, Distance, GetSpeed(), GetPace());
        }
    }