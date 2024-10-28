using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets_for_the_tour;

namespace form_Excursion
{
    public partial class Registration : Form
    {
        private readonly TourContext _dbContext;
        public Registration()
        {
            InitializeComponent();
            _dbContext = new TourContext();

            comboBox1.DataSource = Enum.GetValues(typeof(Grachdanstvo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            string MiddleName = textBox3.Text;
            string PassportData = textBox4.Text;
            string Email = textBox5.Text;
            string Password = textBox6.Text;

            DateOnly BirthDate = DateOnly.FromDateTime(dateTimePicker1.Value.Date);
            Grachdanstvo selectedGrachdanstvo = (Grachdanstvo)comboBox1.SelectedItem;


            //try
            //{
            //    Passenger passenger = new Passenger();
            //    passenger.Add(FirstName, LastName, MiddleName, PassportData, BirthDate, selectedGrachdanstvo.ToString(), Email, Password);
            //    _dbContext.Passes.Add(passenger);
            //    _dbContext.SaveChanges();
            //    MessageBox.Show("Аккаунт создан");
            //    this.Close();
            //}
            //catch(Exception ex) {

            //    MessageBox.Show("Ошибка");
            //    this.Close();
            //}

            try
            {
                // Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) ||
                    string.IsNullOrWhiteSpace(MiddleName) || string.IsNullOrWhiteSpace(PassportData) ||
                    BirthDate == null || string.IsNullOrWhiteSpace(selectedGrachdanstvo.ToString()) ||
                    string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Ошибка: Все поля должны быть заполнены.");
                    return; // Stop execution if validation fails
                }

                Passenger passenger = new Passenger();
                passenger.Add(FirstName, LastName, MiddleName, PassportData, BirthDate, selectedGrachdanstvo.ToString(), Email, Password);
                _dbContext.Passes.Add(passenger);
                _dbContext.SaveChanges();

                MessageBox.Show("Аккаунт создан");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                this.Close();
            }


        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
