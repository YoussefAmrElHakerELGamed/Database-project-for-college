using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTL.BusinessLayer;

namespace Simple_Crud_App
{
    public partial class BooksSubForm : Form
    {

        public int id = -1;
        public BooksSubForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            cleanInputs();
        }

        public void cleanInputs() {
            BookTitle.Text = BookAuthor.Text = BookCopies.Text = BookGenre.Text = BookLibraryid.Text = "";
            BookTitle.PlaceholderText = "Title";
            BookAuthor.PlaceholderText = "Author";
            BookGenre.PlaceholderText = "Genre";
            BookLibraryid.PlaceholderText = "Library id";
            bookDatePicker.Value = System.DateTime.Now;
            id = -1;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            clsBook book;
            if (BookTitle.Text.Length < 1) { BookTitle.PlaceholderText = "Title is required."; return; }
            if (BookGenre.Text.Length < 1) { BookGenre.PlaceholderText = "Genre is required."; return; }
            if (BookAuthor.Text.Length < 1) { BookAuthor.PlaceholderText = "Author is required."; return; }
            if (BookLibraryid.Text.Length < 1) { BookLibraryid.PlaceholderText = "Library id is required."; return; }
            if(BookCopies.Text.Length < 1) { BookCopies.Text = "1"; }

            if(id == -1)
            {
                book = new clsBook(BookTitle.Text, BookAuthor.Text, BookGenre.Text, (DateTime)bookDatePicker.Value, int.Parse(BookCopies.Text), int.Parse(BookLibraryid.Text));
                book.AddBook();
            }
            else
            {
                book = new clsBook(id, BookTitle.Text, BookAuthor.Text, BookGenre.Text, (DateTime)bookDatePicker.Value, int.Parse(BookCopies.Text), int.Parse(BookLibraryid.Text));
                book.UpdateBook();
            }
            cleanInputs();
            Hide();
            MainHolder.main.refreshDataView();
        }

    }
}
