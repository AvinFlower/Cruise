namespace Tickets_for_the_tour
{
    public enum Grachdanstvo
    {
        RF,
        Belarus,
        Ukraine,
        Kazakhstan
    }
    public class Passenger : Person
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Grachdanstvo { get; set; }
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

        public override void Add(string LastName, string FirstName, string MiddleName, string PassportData, DateOnly BirthDate)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.PassportData = PassportData;
            this.BirthDate = BirthDate;
        }

        public void Add(string LastName, string FirstName, string MiddleName, string PassportData, DateOnly BirthDate, string Grachdanstvo, string Email, string Password)
        {
            Add(LastName, FirstName, MiddleName, PassportData, BirthDate);
            this.Grachdanstvo = Grachdanstvo;
            this.Email = Email;
            this.Password = Password;

        }
    }
}
