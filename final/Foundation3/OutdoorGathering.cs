public class OutdoorGathering : Event {
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement) : base(title, description, date, time, address) {
        this.weatherStatement = weatherStatement;
    }

    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Statement: {weatherStatement}";
    }
}