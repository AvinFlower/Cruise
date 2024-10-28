using System.Data;
using Tickets_for_the_tour;

namespace form_Excursion
{
    public partial class Form_Excursion : Form
    {
        private Passenger _loggedInPassenger;
        private Admin _loggedInAdmin;
        public Form_Excursion(Passenger passenger)
        {
            InitializeComponent();
            _loggedInPassenger = passenger;

            button5.Text = $"{_loggedInPassenger.FirstName} {_loggedInPassenger.LastName}";

            // Обновляем ширину и позицию кнопки
            UpdateButtonWidthAndShiftLeft(button5);

            using (TourContext db = new())
            {
                var query1 = from Excursion in db.Excursions
                             orderby Excursion.ExcursionVariants
                             select new { Excursion.ExcursionVariants };


                foreach (var item in query1)
                {
                    comboBox1.Items.Add(item.ExcursionVariants);
                }

                comboBox1.Text = comboBox1.Items[0].ToString();
            }
        }

        public Form_Excursion(Admin admin)
        {
            InitializeComponent();
            _loggedInAdmin = admin;

            // Отображаем имя и фамилию администратора
            button5.Text = $"{_loggedInAdmin.FirstName} {_loggedInAdmin.LastName}";

            // Обновляем ширину и позицию кнопки
            UpdateButtonWidthAndShiftLeft(button5);


            using (TourContext db = new())
            {
                var query1 = from Excursion in db.Excursions
                             orderby Excursion.ExcursionVariants
                             select new { Excursion.ExcursionVariants };


                foreach (var item in query1)
                {
                    comboBox1.Items.Add(item.ExcursionVariants);
                }

                comboBox1.Text = comboBox1.Items[0].ToString();
            }
        }

        private void UpdateButtonWidthAndShiftLeft(Button button)
        {
            // Измеряем размер текста
            Size textSize = TextRenderer.MeasureText(button.Text, button.Font);

            // Сохраняем старую ширину кнопки
            int oldWidth = button.Width;

            // Устанавливаем новую ширину кнопки
            button.Width = textSize.Width + 10; // Добавляем отступ в 20 пикселей

            // Изменяем позицию кнопки, чтобы она расширялась влево
            button.Left -= (button.Width - oldWidth); // Уменьшаем положение Left на разницу в ширине
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Rout form_rout = new Form_Rout();
            form_rout.SelectedExcursionVariant = comboBox1.SelectedItem.ToString();
            form_rout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Flights form_flights = new Form_Flights(_loggedInPassenger);
            form_flights.SelectedExcursionVariant = comboBox1.SelectedItem.ToString();
            form_flights.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Employee form_employee = new Form_Employee();
            form_employee.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Ships form_ships = new Form_Ships();
            form_ships.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Passenger_Profile passenger_profile = new Passenger_Profile(_loggedInPassenger);
            passenger_profile.ShowDialog();
        }

        private void Form_Excursion_Load(object sender, EventArgs e)
        {

        }
    }
}
