using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Model
{
    public class Book
    {
        public int bookID { get; set; }
        public string bookName { get; set; }
        public string bookAuthor { get; set; }
        public string bookLanguage { get; set; }
        public string publisher { get; set; }
        public string bookKind { get; set; }
        public int bookAmount { get; set; }
        public int pageNumber { get; set; }
        public int publicationYear { get; set; }

        public Book(int bookID, string bookName, string bookAuthor, string bookLanguage, string publisher, string bookKind, int bookAmount, int pageNumber, int publicationYear)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookLanguage = bookLanguage;
            this.publisher = publisher;
            this.bookKind = bookKind;
            this.bookAmount = bookAmount;
            this.pageNumber = pageNumber;
            this.publicationYear = publicationYear;
        }

        public int getBookID()
        {
            return this.bookID;
        }
        public string getBookName()
        {
            return this.bookName;
        }
        public string getBookAuthor()
        {
            return this.bookAuthor;
        }
        public string getBookLanguage()
        {
            return this.bookLanguage;
        }
        public string getPublisher()
        {
            return this.publisher;
        }
        public string getKind()
        {
            return this.bookKind;
        }
        public int getBookAmount()
        {
            return this.bookAmount;
        }
        public int getPageNumber()
        {
            return this.pageNumber;
        }
        public int getPublicationYear()
        {
            return this.publicationYear;
        }
    }
}
