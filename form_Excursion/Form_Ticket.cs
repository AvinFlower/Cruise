using Tickets_for_the_tour;

namespace form_Excursion
{
    public partial class Form_Ticket : Form
    {
        private Passenger _loggedInPassenger;

        public int SelectedFlightNumber { get; set; }
        public string SelectedExcursionVariant { get; set; }

        private readonly TourContext _dbContext;
        public Form_Ticket(Passenger passenger)
        {
            InitializeComponent();
            _dbContext = new TourContext();
            _loggedInPassenger = passenger; //!!!!!!!!!!!!!


        }

        private void Form_Ticket_Load(object sender, EventArgs e)
        {
            decimal excursionPrice = GetExcursionPrice(SelectedExcursionVariant);
            //label6.Text = "Стоимость билета на экскурсию - " + excursionPrice;

            comboBox1.DataSource = Enum.GetValues(typeof(PaymentMethod));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string FirstName = textBoxFirstName.Text;
            //string LastName = textBoxLastName.Text;
            //string MiddleName = textBoxMiddleName.Text;
            //string PassportData = textBoxPassportData.Text;
            //DateOnly BirthDate = DateOnly.FromDateTime(dateTimePickerBirthDate.Value.Date);
            //Grachdanstvo selectedGrachdanstvo = (Grachdanstvo)comboBox2.SelectedItem;

            //Passenger passenger = new Passenger();
            //passenger.Add(FirstName, LastName, MiddleName, PassportData, BirthDate, selectedGrachdanstvo.ToString());
            //_dbContext.Passes.Add(passenger);


            int Number = CountTicketsInDatabase();

            Flight selectedFlight = FindFlightByNumber(SelectedFlightNumber);
            decimal excursionPrice = GetExcursionPrice(SelectedExcursionVariant);
            PaymentMethod selectedPaymentMethod = (PaymentMethod)comboBox1.SelectedItem;

            //Ticket ticket = new Ticket();
            //ticket.Add(Number + 1, excursionPrice, DateTime.Now.ToUniversalTime(), selectedPaymentMethod.ToString(), passenger, selectedFlight);
            //_dbContext.Tickets.Add(ticket);

            _dbContext.SaveChanges();

            //MessageBox.Show("Билет №" + ticket.NumberTicket + " успешно куплен на рейс " + selectedFlight.NumberFlights + "\n" + "время отправления " + selectedFlight.DepartureDateTime + "\n" + "место отправления " + selectedFlight.DeparturePlace + "\n" + "пассажир " + passenger.FirstName + " " + passenger.LastName + " " + passenger.MiddleName + "\n\n" + "сохраните этот билет чтобы не потерять");
            //this.Close();
            //Form_Excursion formExcursion = new Form_Excursion();
            //formExcursion.ShowDialog();


        }
        private int CountTicketsInDatabase()
        {
            return _dbContext.Tickets.Count();
        }

        private Flight FindFlightByNumber(int flightNumber)
        {
            return _dbContext.Flights.FirstOrDefault(f => f.NumberFlights == flightNumber);
        }
        private decimal GetExcursionPrice(string excursionVariant)
        {
            var excursion = _dbContext.Excursions
                .FirstOrDefault(e => e.ExcursionVariants == excursionVariant);

            if (excursion != null)
            {
                return excursion.PriceExcursion;
            }
            return 0;
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
