using Tickets_for_the_tour;

namespace form_Excursion
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

            // ������������� �� ������� KeyDown ��� ���� �����
            this.KeyDown += new KeyEventHandler(Form_Login_KeyDown);
            // �������� ����������� ��������� ������� ������ �� ������ �����
            this.KeyPreview = true;
        }

        // ���������� ������� ������� �� ������ �����
        private void Form_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // �������� �� ��, ��� button1 �� �������� null
                if (button1 != null)
                {
                    // ����� ������ button1_Click ��� ������� Enter
                    button1.PerformClick();
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredLogin = textBox1.Text;
            string enteredPassword = textBox2.Text;

            Passenger user = ValidatePassenger(enteredLogin, enteredPassword);
            Admin admin = ValidateAdmin(enteredLogin, enteredPassword);

            if (user != null)
            {
                Hide();
                Form_Excursion form_Excursion = new Form_Excursion(user);
                form_Excursion.ShowDialog();
            }
            else if (admin != null)
            {
                Hide();
                Form_Admin form_Admin = new Form_Admin(admin);
                form_Admin.ShowDialog();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("�������� ����� ��� ������");
            }
        }



        private Passenger ValidatePassenger(string enteredLogin, string enteredPassword)
        {
            using (TourContext context = new TourContext())
            {
                // Check if an admin with the entered login and password exists
                return context.Passengers.FirstOrDefault(passenger =>
                    passenger.Email == enteredLogin && passenger.Password == enteredPassword);
            }
        }

        private Admin ValidateAdmin(string enteredLogin, string enteredPassword)
        {
            using (TourContext context = new TourContext())
            {
                // Check if an admin with the entered login and password exists
                return context.Admins.FirstOrDefault(admin =>
                    admin.Login == enteredLogin && admin.Password == enteredPassword);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}