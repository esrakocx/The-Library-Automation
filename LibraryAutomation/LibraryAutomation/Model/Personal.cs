using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Model
{
    public class Personal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime date { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string authority { get; set; }

        public Personal()
        {

        }

        public Personal(int id, string name, string surname, DateTime date, string userName, string password, string authority)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.date = date;
            this.userName = userName;
            this.password = password;
            this.authority = authority;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }
        public string getSurname()
        {
            return this.surname;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public DateTime getDate()
        {
            return this.date;
        }

        public void setUsername(string userName)
        {
            this.userName = userName;
        }

        public string getUsername()
        {
            return this.userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setAuthority(string authority)
        {
            this.authority = authority;
        }

        public string getAuthority()
        {
            return this.authority;
        }

        public override string ToString()
        {
            return "Name " + this.name + "\nSurname " + this.surname;
        }
    }
}