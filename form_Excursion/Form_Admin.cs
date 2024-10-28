using Tickets_for_the_tour;

namespace form_Excursion
{
    public partial class Form_Admin : Form
    {
        private Admin _loggedInAdmin;


        public Form_Admin(Admin admin)
        {
            InitializeComponent();
            _loggedInAdmin = admin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Attractions add_attractions = new Add_Attractions();
            add_attractions.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Excursion add_excursion = new Add_Excursion();
            add_excursion.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_RoutPoint add_routpoint = new Add_RoutPoint();
            add_routpoint.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Ship add_ship = new Add_Ship();
            add_ship.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_Employee add_employee = new Add_Employee();
            add_employee.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Flight add_flight = new Add_Flight();
            add_flight.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add_Ticket add_ticket = new Add_Ticket();
            add_ticket.ShowDialog();
        }


        private void Form_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_Excursion form_Excursion = new Form_Excursion(_loggedInAdmin);
            form_Excursion.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }
    }
}
