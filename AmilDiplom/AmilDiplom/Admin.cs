using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmilDiplom
{
    internal class Admin
    {
        public int AdminID { get; set; }
        private string Login, Password;
        public string login { get { return Login; } set { Login = value;} }
        public string password { get { return Password; } set { Password = value;} }
        public Admin() { }
        public Admin(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
