using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using UTL.DataLayer;

namespace UTL.BusinessLayer
{

    public class clsLibrary {
        public int id { private set; get; }
        public string name { set; get; }
        public DateTime CreationDate { set; get; }

        public clsLibrary(string name, DateTime CreationDate) {
            this.id = UTL.DataLayer.clsLibrary.getToplibraryid() + 1;
            this.name = name;
            this.CreationDate = CreationDate;
        }

        public clsLibrary(int id, string name, DateTime CreationDate) {
            this.id = id;
            this.name = name;
            this.CreationDate = CreationDate;
        }

        public clsLibrary()
        {
            id = -1;
        }

        public static clsLibrary Find(int id)
        {
            string Name = ""; DateTime CreationDate = new DateTime();

            return UTL.DataLayer.clsLibrary.Find(id,ref Name ,ref CreationDate)
                ? new clsLibrary(id,Name,CreationDate) : null;
        }
        public bool AddLibrary()
        {
            bool added = UTL.DataLayer.clsLibrary.AddNewLibrary(id,name,CreationDate);
            return added;

        }

        public bool UpdateLibrary()
        {
            return UTL.DataLayer.clsLibrary.UpdateLibrary(id,name, CreationDate);
        }
        public static bool DeleteLibrary(int id) { return UTL.DataLayer.clsLibrary.DeleteLibrary(id); }
        public static DataTable ListAllabraries()
        {
            return UTL.DataLayer.clsLibrary.ListAllLibrary();
        }
        public static bool IsLibPresent(int id)
        {
            return UTL.DataLayer.clsLibrary.IsLibraryPresent(id);
        }
    }


    public class clsBook
    {
        public int Id { private set; get; }
        public string Title { set; get; }
        public string Author { set; get; }
        public string Genre { set; get; }
        public DateTime PublishDate { set; get; }
        public int Copies { set; get; }
        public int Libraryid { set; get; }


        public clsBook(string Title, string Author, string Genre, DateTime PublishDate,
             int Copies, int libraryid)
        {
            this.Id = UTL.DataLayer.clsBook.getTopBookid() + 1;
            this.Author = Author;
            this.Title = Title;
            this.Genre = Genre;
            this.PublishDate = PublishDate;
            this.Copies = Copies;
            this.Libraryid = libraryid;
        }
        public clsBook(int id,string Title, string Author, string Genre, DateTime PublishDate,
        int Copies, int libarayid)
        {
            this.Id = id;
            this.Author = Author;
            this.Title = Title;
            this.Genre = Genre;
            this.PublishDate = PublishDate;
            this.Copies = Copies;
            this.Libraryid = libarayid;
        }


        public clsBook()
        {
            Id = -1;
        }

        public static clsBook Find(int id)
        {
            int copies=0 , Libraryid = 0;
            DateTime pubDate = DateTime.MinValue;
            string author = "", title = "", genre = "";

            return UTL.DataLayer.clsBook.Find(id,ref title,ref author,ref genre, ref pubDate,ref copies,ref Libraryid)
                ? new clsBook(id,title,author,genre,pubDate,copies, Libraryid) :null;
        }
        public bool AddBook()
        {

            bool saved = UTL.DataLayer.clsBook.AddNewBook(Id, Title, Author, Genre, PublishDate, Copies, Libraryid);
            return saved;

        }

        public bool UpdateBook()
        {
            return UTL.DataLayer.clsBook.UpdateBook(Id, Title, Author, Genre, PublishDate, Copies, Libraryid);
        }
        public static bool DeleteBook(int id) { return UTL.DataLayer.clsBook.DeleteBook(id); }

        public static DataTable ListAllBooks()
        {
            return UTL.DataLayer.clsBook.ListAllBooks();
        }
        public static bool IsBookPresent(int id)
        {
            return UTL.DataLayer.clsBook.IsBookPresent(id);
        }

    }


    public class clsEmployee
    {
        public int Id { private set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime HireD { set; get; }
        public DateTime ResignDate { set; get; }
        public int Salary { set; get; } //ofc could be decimal but ya know no one is paid in fractions :)
        public int shiftid { set; get; }
        public int AbsencesCount { set; get; }
        public int LibraryID { get; set; }

        public clsEmployee(int Id, string FirstName, string LastName, int LibraryID, DateTime HireD,
             DateTime ResignDate,int AbsencesCount, int Salary, int shiftid)
        {
            this.Id = Id;
            this.FirstName = FirstName;  
            this.LastName = LastName;
            this.LibraryID = LibraryID;
            this.HireD = HireD;
            this.ResignDate = ResignDate;
            this.AbsencesCount = AbsencesCount;
            this.Salary = Salary;
            this.shiftid = shiftid;

        }

        public clsEmployee(string FirstName, string LastName,int LibraryID, DateTime HireD,
             DateTime ResignDate, int Salary, int AbsencesCount, int shiftid)
        {
            this.Id = UTL.DataLayer.clsEmployee.getTopStaffid() + 1;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.LibraryID = LibraryID;
            this.HireD = HireD;
            this.ResignDate = ResignDate;
            this.Salary = Salary;
            this.shiftid = shiftid;

        }

        public clsEmployee()
        {
            Id = -1;
        }

        public static clsEmployee Find(int id)
        {
            int shiftId = -1,Salary  = 0, LibraryID = -1, AbsCount = 0;
            DateTime HireD = DateTime.MinValue, ResignDate = DateTime.MinValue;
            string firstname = "", lastname = "";

            return UTL.DataLayer.clsEmployee.Find(id, ref firstname, ref lastname,ref LibraryID, ref HireD,ref ResignDate,ref Salary,ref AbsCount,ref shiftId)
                ? new clsEmployee(id,  firstname,  lastname,LibraryID,  HireD, ResignDate,  Salary, AbsCount,  shiftId) : null;
        }
        public bool AddEmployee()
        {
            bool saved = UTL.DataLayer.clsEmployee.AddNewEmployee(Id, FirstName, LastName, LibraryID, HireD, ResignDate, Salary, shiftid, AbsencesCount);
            return saved;
        }

        public bool UpdateEmployee()
        {
            return UTL.DataLayer.clsEmployee.UpdateEmployee(Id, FirstName, LastName, Salary, HireD, ResignDate, AbsencesCount, LibraryID, shiftid);
        }

        public static bool DeleteEmployee(int id) { return UTL.DataLayer.clsEmployee.DeleteEmployee(id); }
        public static DataTable ListAllEmployees()
        {
            return UTL.DataLayer.clsEmployee.ListAllEmployees();
        }
        public static bool IsEmployeePresent(int id)
        {
            return UTL.DataLayer.clsEmployee.IsEmployeePresent(id);
        }

    }
    public class clsLoan
    {
        public int Id { private set; get; }

        public DateTime LoanD { set; get; }
        public DateTime DueD { set; get; }
        public int MemberId { set; get; }
        public int BookId { set; get; } 


        public clsLoan(int Id, int MemberId, int BookId, DateTime LoanD,
             DateTime DueD)
        {
            this.Id = Id;
            this.MemberId = MemberId;
            this.BookId = BookId;
            this.LoanD = LoanD;
            this.DueD = DueD;
        }

        public clsLoan(int MemberId, int BookId, DateTime LoanD,
             DateTime DueD)
        {
            this.Id = UTL.DataLayer.clsLoan.getTopLoanid() + 1;
            this.MemberId = MemberId;
            this.BookId = BookId;
            this.LoanD = LoanD;
            this.DueD = DueD;

        }

        public clsLoan()
        {
            Id = -1;
        }

        public static clsLoan Find(int id)
        {
            int MemberId = -1, BookId = -1;
            DateTime loanD = DateTime.MinValue;
            DateTime dueD = DateTime.MinValue;


            return UTL.DataLayer.clsLoan.Find(id,ref MemberId,ref BookId,ref loanD,ref dueD)
                ? new clsLoan(id, MemberId, BookId, loanD, dueD) : null;
        }
        public bool AddLoan()
        {
            bool saved = UTL.DataLayer.clsLoan.AddNewLoan(Id,MemberId,BookId,LoanD,DueD);
            return saved;
        }

        public bool UpdateLoan()
        {
            return UTL.DataLayer.clsLoan.UpdateLoan(Id,MemberId,BookId,LoanD,DueD);
        }
        public static bool DeleteLoan(int id) { return UTL.DataLayer.clsLoan.DeleteLoan(id); }
        public static DataTable ListAllLoans()
        {
            return UTL.DataLayer.clsLoan.ListAllLoans();
        }
        public static bool IsLoanPresent(int id)
        {
            return UTL.DataLayer.clsLoan.IsLoanPresent(id);
        }
        
    }
    public class clsMember
    {
        public int Id { private set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime JoinD { set; get; }
        public DateTime EndMem { set; get; } 


        public clsMember(int Id, string FirstName, string LastName, DateTime JoinD,
            DateTime EndMem)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.JoinD = JoinD;
            this.EndMem = EndMem;

        }

        public clsMember(string FirstName, string LastName, DateTime JoinD,
            DateTime EndMem)
        {
            this.Id = UTL.DataLayer.clsMember.getTopMemberid() + 1;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.JoinD = JoinD;
            this.EndMem = EndMem;
        }


        public clsMember()
        {
            Id = -1;
        }

        public static clsMember Find(int id)
        {
            
            DateTime JoinD = DateTime.MinValue;
            DateTime EndMem = DateTime.MinValue;

            string firstname = "", lastname = "";

            return UTL.DataLayer.clsMember.Find(id, ref firstname, ref lastname, ref JoinD, ref EndMem)
                ? new clsMember(id, firstname, lastname, JoinD, EndMem) : null;
        }
        public bool AddMember()
        {
            bool saved = UTL.DataLayer.clsMember.AddNewMember(Id,FirstName, LastName, JoinD, EndMem);
            return saved;
        }

        public bool UpdateMember()
        {
            return UTL.DataLayer.clsMember.UpdateMember(Id, FirstName, LastName,JoinD,EndMem);
        }
        public static bool DeleteMember(int id) { return UTL.DataLayer.clsMember.DeleteMember(id); }
        public static DataTable ListAllMembers()
        {
            return UTL.DataLayer.clsMember.ListAllMembers();
        }
        public static bool IsMemberPresent(int id)
        {
            return UTL.DataLayer.clsMember.IsMemberPresent(id);
        }


    }
}
