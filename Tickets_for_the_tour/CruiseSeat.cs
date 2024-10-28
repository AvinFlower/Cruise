namespace Tickets_for_the_tour
{
    public class CruiseSeat : Entity
    {
        public string SeatNumber { get; set; }
        public string ComfortLevel { get; set; }
        public string Location { get; set; }
        public string IsBooked { get; set; }
        public void Add(string SeatNumber, string ComfortLevel, string Location, string IsBooked)
        {
            this.SeatNumber = SeatNumber;
            this.ComfortLevel = ComfortLevel;
            this.Location = Location;
            this.IsBooked = IsBooked;
        }
    }

    public enum ComfortLevel
    {
        Эконом = 1,
        Стандарт = 2,
        Люкс = 3
    }
}