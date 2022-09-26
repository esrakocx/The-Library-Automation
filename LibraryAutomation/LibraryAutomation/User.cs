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
    public partial class User : Form
    {
        List<Book> books;
        public User(List<Book> books)
        {
            InitializeComponent();
            this.books = books;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
            MessageBox.Show("Logged out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void User_Load(object sender, EventArgs e)
        {
            foreach(Book book in books)
            {
                dataGridViewUser.Rows.Add(book.getBookID(), book.getBookName(), book.getBookAuthor(), book.getBookLanguage(), book.getPublisher(), book.getKind(), book.getBookAmount(), book.getPageNumber(), book.getPublicationYear());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Book targetBook = null;

            int chosenBookID = Convert.ToInt32(txt_Search.Text);

            foreach (Book book in books)
            {
                if (book.getBookID() == chosenBookID)
                {
                    targetBook = book;
                    break;
                }
            }

            dataGridViewUser.Rows.Clear();
            dataGridViewUser.Rows.Add(targetBook.getBookID(), targetBook.getBookName(), targetBook.getBookAuthor(), targetBook.getBookLanguage(), targetBook.getPublisher(), targetBook.getKind(), targetBook.getBookAmount(), targetBook.getPageNumber(), targetBook.getPublicationYear());
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataGridViewUser.Rows.Remove(dataGridViewUser.CurrentRow);
            foreach (Book targetBook in books)
            {
                dataGridViewUser.Rows.Add(targetBook.getBookID(), targetBook.getBookName(), targetBook.getBookAuthor(), targetBook.getBookLanguage(), targetBook.getPublisher(), targetBook.getKind(), targetBook.getBookAmount(), targetBook.getPageNumber(), targetBook.getPublicationYear());
            }
        }
    }
}
