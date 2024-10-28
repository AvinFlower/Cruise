namespace Tickets_for_the_tour
{
    public class Employee : Person
    {
        public string Position{ get; set; }
        public override void Add(string LastName, string FirstName, string MiddleName, string PassportData, DateOnly BirthDate)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.PassportData = PassportData;
            this.BirthDate = BirthDate;
        }

        public void Add(string LastName, string FirstName, string MiddleName, string PassportData, DateOnly BirthDate, string Position)
        {
            Add(LastName, FirstName, MiddleName, PassportData, BirthDate);
            this.Position = Position;
        }
    }
    public enum Position
    {
        Сaptain,
        Сashier,
        Сleaner,
        Waiter
    }
}
