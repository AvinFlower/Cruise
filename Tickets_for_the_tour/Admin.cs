using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_for_the_tour
{
    public class Admin : Entity
    {
        public string Login {  get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Add(string Login, string Password, string FirstName, string LastName)
        {
            this.Login = Login;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
