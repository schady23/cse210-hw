public class CyclingActivity : Activity
    {
        public double Speed { get; set; }

        public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
        {
            Speed = speed;
        }

        public override double GetDistance()
        {
            return Speed * (Length / 60.0);
        }

        public override double GetSpeed()
        {
            return Speed;
        }

        public override string GetPace()
        {
            double paceSeconds = (Length * 60.0) / GetDistance();
            int minutes = (int)(paceSeconds / 60);
            int seconds = (int)(paceSeconds % 60);
            return String.Format("{0}.{1:00} min per mile", minutes, seconds);
        }

        public override string GetSummary()
        {
            return String.Format("{0} Cycling ({1} min) - Distance {2:F1} miles, Speed {3:F1} mph, Pace: {4}",
                Date.ToString("dd MMM yyyy"), Length, GetDistance(), Speed, GetPace());
        }
    }