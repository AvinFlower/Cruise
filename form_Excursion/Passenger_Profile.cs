using Tickets_for_the_tour;

namespace form_Excursion
{
    public partial class Passenger_Profile : Form
    {
        private Passenger _loggedInPassenger;

        public Passenger_Profile(Passenger passenger)
        {
            InitializeComponent();
            _loggedInPassenger = passenger;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Passenger_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
