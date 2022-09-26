using LibraryAutomation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Form1 : Form
    {
        List<Personal> members = new List<Personal>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usernameTxt.Text = string.Empty;
            passwordTxt.Text = string.Empty;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName, password = "";

            userName = usernameTxt.Text;
            password = passwordTxt.Text;

            bool control = false;

            foreach (Personal personal in members)
            {
                if (userName.ToLower() == personal.getUsername() && password.ToLower() == personal.getPassword() && personal.getAuthority() == "admin")
                {
                    //redirect to admin page
                    Admin admin = new Admin(members,books);
                    admin.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (userName.ToLower() == personal.getUsername() && password.ToLower() == personal.getPassword() && personal.getAuthority() == "user")
                {
                    User user = new User(books);
                    user.Show();
                    this.Hide();
                    control = true;
                    break;
                }

            }

            if(!control)
                MessageBox.Show("An error has occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            members.Add(new Personal(1, "Esra", "Koc", DateTime.Now, "esra", "1", "admin"));
            members.Add(new Personal(2, "Bill", "Gates", DateTime.Now, "bill", "2", "user"));
            members.Add(new Personal(3, "Mark", "Zuckerberg", DateTime.Now, "mark", "3", "user"));
            members.Add(new Personal(4, "Elon", "Musk", DateTime.Now, "elon", "4", "user"));

            books.Add(new Book(1, "No-No Boy", "John Okada", "English", "the University of Washington Press", "Novel", 30, 232, 2014));
            books.Add(new Book(2, "The Paper Palace", "Miranda Cowley Heller", "English", "Penguin", "History", 59, 400, 2022));
            books.Add(new Book(3, "The Keeper of Stories", "Sally Page", "English", "One More Chapter", "History", 110, 384, 2022));
            books.Add(new Book(4, "The Dinner Lady Detectives", "Hannah Hendy", "English", "Canelo", "Mystery", 96, 302, 2021));
            books.Add(new Book(5, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Novel", 150, 760, 2015));
        }
    }
}
