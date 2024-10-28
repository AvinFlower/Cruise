using Microsoft.EntityFrameworkCore;
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
    public partial class Form_Employee : Form
    {
        private readonly TourContext _dbContext;
        public Form_Employee()
        {
            InitializeComponent();
            _dbContext = new TourContext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {
            var employees = _dbContext.Employees.ToList();
            textBox1.Text += "Работники:\r\n";

            // Заполняем TextBox информацией о сотрудниках
            foreach (var employee in employees)
            {
                textBox1.Text += $"\r\n{employee.LastName} {employee.FirstName} {employee.MiddleName}, Должность: {employee.Position}\r\n";
            }
        }
    }
}
