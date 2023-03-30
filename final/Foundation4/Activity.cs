public class Activity
    {
        public DateTime Date { get; set; }
        public int Length { get; set; }

        public Activity(DateTime date, int length)
        {
            Date = date;
            Length = length;
        }

        public virtual double GetDistance()
        {
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            return 0.0;
        }

        public virtual string GetPace()
        {
            return "";
        }

        public virtual string GetSummary()
        {
            return "";
        }
    }