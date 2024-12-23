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
    public partial class MainForm : Form
    {
        private clsLibrary library; private clsBook book; private clsMember member;
        private clsLoan loan; private clsEmployee employee;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Cmanu = manu.Library;
            refreshDataView();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        private void LibrariesB_Click(object sender, EventArgs e)
        {
            MainLabel.Text = librariesB.Text;
            DataTable dataTable = clsLibrary.ListAllabraries();
            if (dataTable.Rows.Count > 0)
            {
                DataView.DataSource = dataTable;
                waringlabel.Text = "";
            }
            else waringlabel.Text = "there is no data in the libraries dataset";
            Cmanu = manu.Library;
            refreshDataView();
        }

        private void BooksB_Click(object sender, EventArgs e)
        {
            MainLabel.Text = BooksB.Text;
            DataTable dataTable = clsBook.ListAllBooks();
            if (dataTable.Rows.Count > 0)
            {
                DataView.DataSource = dataTable;
                waringlabel.Text = "";
            }
            else waringlabel.Text = "there is no data in the books dataset";
            Cmanu = manu.Book;
            refreshDataView();
        }

        private void MembersB_Click(object sender, EventArgs e)
        {
            MainLabel.Text = MembersB.Text;
            DataTable dataTable = clsMember.ListAllMembers();
            if (dataTable.Rows.Count > 0)
            {
                DataView.DataSource = dataTable;
                waringlabel.Text = "";
            }
            else waringlabel.Text = "there is no data in the members dataset";
            Cmanu = manu.Member;
            refreshDataView();
        }

        private void LoansB_Click(object sender, EventArgs e)
        {
            MainLabel.Text = LoansB.Text;
            DataTable dataTable = clsLoan.ListAllLoans();
            if (dataTable.Rows.Count > 0)
            {
                DataView.DataSource = dataTable;
                waringlabel.Text = "";
            }
            else waringlabel.Text = "there is no data in the loans dataset";
            Cmanu = manu.Loans;
            refreshDataView();
        }

        private void StaffB_Click(object sender, EventArgs e)
        {
            MainLabel.Text = StaffB.Text;
            DataTable dataTable = clsEmployee.ListAllEmployees();
            if (dataTable.Rows.Count > 0)
            {
                DataView.DataSource = dataTable;
                waringlabel.Text = "";
            }
            else waringlabel.Text = "there is no data in the staff dataset";
            Cmanu = manu.Staff;
            refreshDataView();
        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        librariesSubForm libraryForm;
        BooksSubForm BookForm;
        MemberSubForm MemberForm;
        LoansSubForm LoanForm;
        StaffSubForm StaffForm;
        enum manu {Library, Book, Member, Loans, Staff}
        manu Cmanu = manu.Library;
        private void addB_click(object sender, EventArgs e)
        {
            if(Cmanu == manu.Library)
            {
                if (libraryForm == null)
                {
                    libraryForm = new librariesSubForm();
                    libraryForm.Show();
                }
                else
                {
                    libraryForm.Show();
                    libraryForm.Activate();
                }
                libraryForm.addlibraryMainLabel.Text = "add library";
            }

            if(Cmanu == manu.Book)
            {
                if(BookForm == null)
                {
                    BookForm = new BooksSubForm();
                    BookForm.Show();
                }
                else
                {
                    BookForm.Show();
                    BookForm.Activate();
                }
                BookForm.addBooksMainLabel.Text = "add Book";
            }

            if(Cmanu == manu.Member)
            {
                if(MemberForm == null)
                {
                    MemberForm = new MemberSubForm();
                    MemberForm.Show();
                }
                else
                {
                    MemberForm.Show();
                    MemberForm.Activate();
                }
                MemberForm.addMemberMainLabel.Text = "add member";
            }

            if(Cmanu == manu.Loans)
            {
                if(LoanForm == null)
                {
                    LoanForm = new LoansSubForm();
                    LoanForm.Show();
                }
                else
                {
                    LoanForm.Show();
                    LoanForm.Activate();
                }
                LoanForm.addLoanMainLabel.Text = "add loan";
            }

            if(Cmanu == manu.Staff)
            {
                if(StaffForm == null)
                {
                    StaffForm = new StaffSubForm();
                    StaffForm.Show();
                }
                else
                {
                    StaffForm.Show();
                    StaffForm.Activate();
                }
                StaffForm.addBooksMainLabel.Text = "add employee";
            }
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cmanu == manu.Library) { clsLibrary.DeleteLibrary(library.id); refreshDataView(); }
                if (Cmanu == manu.Book) { clsBook.DeleteBook(book.Id); refreshDataView(); }
                if (Cmanu == manu.Member) { clsMember.DeleteMember(member.Id); refreshDataView(); }
                if (Cmanu == manu.Loans) { clsLoan.DeleteLoan(loan.Id); refreshDataView(); }
                if (Cmanu == manu.Staff) { clsEmployee.DeleteEmployee(employee.Id); refreshDataView(); }
            }
            catch { }
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Cmanu == manu.Library)
                    library = clsLibrary.Find(int.Parse(DataView.Rows[e.RowIndex].Cells[0].Value.ToString()));

                if (Cmanu == manu.Book)
                    book = clsBook.Find(int.Parse(DataView.Rows[e.RowIndex].Cells[0].Value.ToString()));

                if(Cmanu == manu.Member)
                    member = clsMember.Find(int.Parse(DataView.Rows[e.RowIndex].Cells[0].Value.ToString()));

                if (Cmanu == manu.Loans)
                    loan = clsLoan.Find(int.Parse(DataView.Rows[e.RowIndex].Cells[0].Value.ToString()));

                if (Cmanu == manu.Staff)
                    employee = clsEmployee.Find(int.Parse(DataView.Rows[e.RowIndex].Cells[0].Value.ToString()));

            }
            catch(Exception er) { Console.WriteLine(er.Message.ToString()); }
        }

        public void refreshDataView()
        {
            if (Cmanu == manu.Library) DataView.DataSource = clsLibrary.ListAllabraries();
            if (Cmanu == manu.Book) DataView.DataSource = clsBook.ListAllBooks();
            if (Cmanu == manu.Member) DataView.DataSource = clsMember.ListAllMembers();
            if (Cmanu == manu.Loans) DataView.DataSource = clsLoan.ListAllLoans();
            if (Cmanu == manu.Staff) DataView.DataSource = clsEmployee.ListAllEmployees();
        }

        public void Edit()
        {
            if (Cmanu == manu.Library && library != null)
            {
                if (libraryForm == null)
                    libraryForm = new librariesSubForm();
                else
                    libraryForm.Activate();

                libraryForm.id = library.id;
                libraryForm.LabName.Text = library.name;
                libraryForm.LabDate.Value = (DateTime)library.CreationDate;
                libraryForm.addlibraryMainLabel.Text = "Edit library";

                libraryForm.Show();
            }

            if(Cmanu == manu.Book && book != null)
            {

                if (BookForm == null)
                    BookForm = new BooksSubForm();
                else
                    BookForm.Activate();

                BookForm.id = book.Id;
                BookForm.BookTitle.Text = book.Title;
                BookForm.BookAuthor.Text = book.Author;
                BookForm.BookGenre.Text = book.Genre;
                BookForm.bookDatePicker.Value = (DateTime)book.PublishDate;
                BookForm.BookCopies.Text = book.Copies.ToString();
                BookForm.BookLibraryid.Text = book.Libraryid.ToString() == null ? "" : book.Libraryid.ToString();
                BookForm.addBooksMainLabel.Text = "Edit book";

                BookForm.Show();
            }


            if(Cmanu == manu.Member && member != null)
            {

                if (MemberForm == null)
                    MemberForm = new MemberSubForm();
                else
                    MemberForm.Activate();

                MemberForm.id = member.Id;
                MemberForm.MemberFirstName.Text = member.FirstName;
                MemberForm.MemberLastName.Text = member.LastName;
                MemberForm.MemberJoinDate.Value = (DateTime)member.JoinD;
                MemberForm.MemberEndDate.Value = (DateTime)member.EndMem;
                MemberForm.addMemberMainLabel.Text = "Edit member";

                MemberForm.Show();
            }

            if(Cmanu == manu.Loans && loan != null)
            {
                if (LoanForm == null)
                    LoanForm = new LoansSubForm();
                else
                    LoanForm.Activate();

                LoanForm.id = loan.Id;
                LoanForm.LoanMemberId.Text = loan.MemberId.ToString();
                LoanForm.LoanBookId.Text = loan.BookId.ToString();
                LoanForm.LoanJoinDate.Value = (DateTime)loan.LoanD;
                LoanForm.LoanEndDate.Value = (DateTime)loan.DueD;
                LoanForm.addLoanMainLabel.Text = "Edit loan";

                LoanForm.Show();
            }

            if(Cmanu == manu.Staff && employee != null)
            {
                if (StaffForm == null)
                    StaffForm = new StaffSubForm();
                else
                    StaffForm.Activate();

                StaffForm.id = employee.Id;
                StaffForm.StaffFirstName.Text = employee.FirstName;
                StaffForm.StaffLastName.Text = employee.LastName;
                StaffForm.StaffShiftID.Text = employee.shiftid.ToString();
                StaffForm.StaffLibraryID.Text = employee.LibraryID.ToString();
                StaffForm.StaffAbsCount.Text = employee.AbsencesCount.ToString();
                StaffForm.StaffSalary.Text = employee.Salary.ToString();
                StaffForm.StaffHireDate.Value = (DateTime)employee.HireD;
                try
                {
                    StaffForm.StaffResignDate.Value = (DateTime)employee.ResignDate;
                }
                catch { }

                StaffForm.addBooksMainLabel.Text = "Edit employee";

                StaffForm.Show();
            }
        }

    }
}
