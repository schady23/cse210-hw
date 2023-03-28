class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return this.country == "USA";
    }

    public string GetFullAddress()
    {
        return this.streetAddress + "\n" + this.city + ", " + this.state + "\n" + this.country;
    }
}