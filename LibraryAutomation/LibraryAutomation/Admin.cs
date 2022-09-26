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
    public partial class Admin : Form
    {
        List<Personal> members;
        List<Book> books;
        public Admin(List<Personal> members, List<Book> books)
        {
            InitializeComponent();
            this.members = members;
            this.books = books;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            foreach(Personal member in members)
            {
                dataGridView1.Rows.Add(member.getId(), member.getName(), member.getSurname(), member.getDate(), member.getUsername(), member.getPassword(), member.getAuthority());
            }

            foreach(Book book in books)
            {
                dataGridView2.Rows.Add(book.getBookID(),book.getBookName(),book.getBookAuthor(),book.getBookLanguage(),book.getPublisher(),book.getKind(),book.getBookAmount(),book.getPageNumber(),book.getPublicationYear());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(textBoxID.Text), textBoxName.Text, textBoxSurname.Text, maskedTextDate.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxAuthority.Text);

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        public void fillText()
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxUsername.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxPassword.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAuthority.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillText();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string date = maskedTextDate.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string authority = textBoxAuthority.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, name, surname, date, username, password, authority);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<groupBoxMember.Controls.Count; i++)
            {
                if(groupBoxMember.Controls[i] is TextBox || groupBoxMember.Controls[i] is MaskedTextBox)
                {
                    groupBoxMember.Controls[i].Text = string.Empty;
                }
            }
        }

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(textBoxBookID.Text, textBookName.Text, textAuthor.Text, textBoxLan.Text, textBoxPublisher.Text, textBoxKind.Text, textBoxAmount.Text, textBoxAmount.Text, textBoxPage.Text, textBoxYear.Text);

        }

        private void buttonBookDel_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void buttonBookClear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBoxBook.Controls.Count; i++)
            {
                if(groupBoxBook.Controls[i] is TextBox)
                {
                    groupBoxBook.Controls[i].Text = string.Empty;
                }
            }
        }

        private void buttonBookUpdate_Click(object sender, EventArgs e)
        {
            string bookID = textBoxBookID.Text;
            string bookName = textBookName.Text;
            string author = textAuthor.Text;
            string language = textBoxLan.Text;
            string publisher = textBoxPublisher.Text;
            string kind = textBoxKind.Text;
            string amount = textBoxAmount.Text;
            string page = textBoxPage.Text;
            string publicationYear = textBoxYear.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(bookID, bookName, author, language, publisher, kind, amount, page, publicationYear);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBookID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBookName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textAuthor.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxLan.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBoxPublisher.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBoxKind.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBoxAmount.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBoxPage.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBoxYear.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void buttonMemberSearch_Click(object sender, EventArgs e)
        {
            Personal targetMember = null;

            int chosenMemberID = Convert.ToInt32(textBoxSearch.Text);

            foreach(Personal member in members)
            {
                if(member.getId() == chosenMemberID)
                {
                    targetMember = member;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(targetMember.getId(), targetMember.getName(), targetMember.getSurname(), targetMember.getDate(), targetMember.getUsername(), targetMember.getPassword(), targetMember.getAuthority());

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach(Personal targetMember in members)
            {
                dataGridView1.Rows.Add(targetMember.getId(), targetMember.getName(), targetMember.getSurname(), targetMember.getDate(), targetMember.getUsername(), targetMember.getPassword(), targetMember.getAuthority());
            }
        }

        private void buttonSearch2_Click(object sender, EventArgs e)
        {
            Book targetBook = null;

            int chosenBookID = Convert.ToInt32(textBoxSearch2.Text);

            foreach(Book book in books)
            {
                if(book.getBookID() == chosenBookID)
                {
                    targetBook = book;
                    break;
                }
            }

            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(targetBook.getBookID(), targetBook.getBookName(), targetBook.getBookAuthor(), targetBook.getBookLanguage(), targetBook.getPublisher(), targetBook.getKind(), targetBook.getBookAmount(), targetBook.getPageNumber(), targetBook.getPublicationYear());
        }

        private void buttonRefresh2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach(Book targetBook in books)
            {
                dataGridView2.Rows.Add(targetBook.getBookID(), targetBook.getBookName(), targetBook.getBookAuthor(), targetBook.getBookLanguage(), targetBook.getPublisher(), targetBook.getKind(), targetBook.getBookAmount(), targetBook.getPageNumber(), targetBook.getPublicationYear());
            }
        }

        private void ExitAdmin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
            MessageBox.Show("Logged out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
