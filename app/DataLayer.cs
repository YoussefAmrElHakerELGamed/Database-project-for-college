using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ConnactionData
{ public static string ConString = "Data Source=" + System.Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=librarySystem;Integrated Security=True"; }

namespace UTL.DataLayer
{
    public static class clsLibrary {
        private static string conS = ConnactionData.ConString;
        private static SqlConnection con = new SqlConnection(conS);

        public static bool Find(int id, ref string Name, ref DateTime Creationdate) {
            try
            {
                con.Open();
                string Query = "SELECT * FROM Libraries Where LibraryId=@id";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    Name = r["LibName"].ToString();
                    Creationdate = (DateTime)r["CreationDate"];
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static int getToplibraryid() {

            string nonQ = @"Select LibraryId from Libraries
                            order by LibraryId desc";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(nonQ, con);
                SqlDataReader r = cmd.ExecuteReader();

                DataTable df = new DataTable();
                if (r.HasRows) { df.Load(r); }
                con.Close();
                return Int32.Parse(df.Rows[0].ItemArray[0].ToString());

            }
            catch (Exception)
            {
                return 0;
            }
            finally { con.Close();}

        }

        public static bool AddNewLibrary(int id,string LibName, DateTime Creationdate)
        {

            string nonQ = @"insert into Libraries(LibraryId,LibName,CreationDate)
                            values (@LibraryId,@LibName,@CreationDate)";

            try
            {
                con.Open();

                SqlCommand cmdI = new SqlCommand(nonQ, con); 
                cmdI.Parameters.AddWithValue("@LibraryId", id);
                cmdI.Parameters.AddWithValue("@LibName", LibName);
                cmdI.Parameters.AddWithValue("@CreationDate", Creationdate);
                cmdI.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool UpdateLibrary(int id,string LibName, DateTime CreationDate)
        {
            try
            {
                int rowsE = 0;
                con.Open();
                string nonQ = @"Update Libraries
                                Set LibName = @LibName, CreationDate = @CreationDate 
                                Where LibraryId = @id;";
                SqlCommand cmd = new SqlCommand(nonQ, con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@LibName", LibName);
                cmd.Parameters.AddWithValue("@CreationDate", CreationDate);
                rowsE = cmd.ExecuteNonQuery();

                return rowsE > 0;
            }
            catch
            {
                return false;
            }


            finally { con.Close(); }

        }
        public static bool DeleteLibrary(int Id)
        {
            string nonQ = "Delete from Libraries where LibraryId = @Id;";
            SqlCommand cmd = new SqlCommand(nonQ, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            int rowsE;

            try
            {
                con.Open();
                rowsE = cmd.ExecuteNonQuery();
                return (rowsE != 0);
            }
            catch(Exception e)
            { return false; }
            finally { con.Close(); }

        }
        public static DataTable ListAllLibrary()
        {
            string Q = "SELECT LibraryId as 'ID',LibName as 'Library name',CreationDate as 'Opened in' FROM Libraries";
            SqlCommand cmd = new SqlCommand(Q, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }

                return dt;
            }
            catch { return null; }
            finally { con.Close(); }

        }

        public static bool IsLibraryPresent(int id)
        {
            string q = "SELECT found=1 FROM Books WHERE LibraryId=@ID";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                con.Open();
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n == 1;
            }
            catch { return false; }
            finally { con.Close(); }
        }
    }



    public static class clsBook
    {
        private static  string conS = ConnactionData.ConString;
        private static SqlConnection con = new SqlConnection(conS);
        public static bool Find(int Id, ref string Title, ref string Author, ref string Genre,
              ref DateTime PublishD, ref int Copies,ref int LibraryId)
        {
            try
            {
                con.Open();
                string Query = "SELECT * FROM Books WHERE BookId=@Id";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {

                    Title = r["title"].ToString();
                    Author = r["author"].ToString();
                    Genre = r["Genre"].ToString();
                    PublishD = Convert.ToDateTime( r["publishdate"] );
                    Copies = (int) r["copies"];
                    LibraryId = (int)r["LibraryId"];
                    r.Close();

                    return true;
                }
                else

                {
                    r.Close();
                    return false;
                }

            }
            catch
            {
                // to do : log the exception in a file or something

                return false;
            }


            finally { con.Close(); }


        }

        public static int getTopBookid()
        {

            string nonQ = @"Select BookId from Books
                            order by BookId desc";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(nonQ, con);
                SqlDataReader r = cmd.ExecuteReader();

                DataTable df = new DataTable();
                if (r.HasRows) { df.Load(r); }
                con.Close();
                return Int32.Parse(df.Rows[0].ItemArray[0].ToString());

            }
            catch (Exception)
            {
                return 0;
            }
            finally { con.Close(); }

        }

        public static bool AddNewBook(int id ,string Title,  string Author,  string Genre,
               DateTime PublishD,  int Copies , int libraryid)
        {
            string nonQ = @"Insert INTO Books (BookId,Title,Author,Genre,Copies,PublishDate,LibraryId)
                            VALUES(@BookId, @Title, @Author, @Genre, @Copies,@PublishDate,@LibraryId)";


            try
            {
                con.Open();

                SqlCommand cmdI = new SqlCommand(nonQ, con);

                cmdI.Parameters.AddWithValue("@BookId", id);
                cmdI.Parameters.AddWithValue("@Title", Title);
                cmdI.Parameters.AddWithValue("@Author", Author);
                cmdI.Parameters.AddWithValue("@Genre", Genre);
                cmdI.Parameters.AddWithValue("@Copies", Copies);
                cmdI.Parameters.AddWithValue("@PublishDate", PublishD);
                cmdI.Parameters.AddWithValue("@LibraryId", libraryid);
                cmdI.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool UpdateBook(int Id,  string Title,  string Author,  string Genre,
               DateTime PublishD,  int Copies, int libraryid)
        {
            try
            {
                con.Open();
                string nonQ = @"Update Books 
                                Set Title=@Title, Author=@Author, Genre=@Genre, PublishDate=@PublishD, Copies=@Copies, LibraryId=@libraryid
                                Where BookId = @Id;";
                SqlCommand cmd = new SqlCommand(nonQ, con);

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Author", Author);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@PublishD", PublishD);
                cmd.Parameters.AddWithValue("@Copies", Copies);
                cmd.Parameters.AddWithValue("@libraryid", libraryid);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }

        }
        public static bool DeleteBook(int Id)
        {
            string nonQ = "DELETE FROM Books WHERE BookId=@Id";
            SqlCommand cmd = new SqlCommand(nonQ, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            int rowsE ;

            try
            {
                con.Open();
                rowsE = cmd.ExecuteNonQuery();
                return (rowsE != 0);
            }
            catch
            {return false; }
            finally { con.Close(); }

        }
        public static DataTable ListAllBooks()
        {
            string Q = @"Select BookId as 'ID',Title,Author,Genre,Copies,PublishDate,Libraries.LibName as 'at' from Books
                         inner join Libraries
                         on Books.LibraryId = Libraries.LibraryId; ";
            SqlCommand cmd = new SqlCommand(Q, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }

                return dt;
            }
            catch { return null; }
            finally { con.Close(); }

        }

        public static bool IsBookPresent(int id)
        {
            string q = "SELECT found=1 FROM Books WHERE BookId=@ID";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                con.Open();
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n == 1;
            }
            catch { return false; }
            finally { con.Close(); }
        }


    }


    public class clsEmployee
    {
        private static string conS = ConnactionData.ConString;
        private static SqlConnection con = new SqlConnection(conS);
        public static bool Find(int Id, ref string FirstName,ref string LastName, ref int LibraryID, ref DateTime HireD,
              ref DateTime ResignDate, ref int Salary,ref int AbsencesCount, ref int ShiftId)
        {
            try
            {
                con.Open();
                string Query = "SELECT * FROM Librarians WHERE LibrarianId=@Id";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    FirstName = r["FirstName"].ToString();
                    LastName = r["LastName"].ToString();
                    HireD = Convert.ToDateTime(r["HireDate"]);
                    AbsencesCount = Convert.ToInt32(r["Absences"]);
                    Salary = Convert.ToInt32(r["Salary"]);

                    try { LibraryID = Convert.ToInt32(r["LibraryId"]); } catch { LibraryID = -1; }
                    try { ShiftId = Convert.ToInt32(r["ShiftId"]); } catch { ShiftId = -1; }
                    try { ResignDate = Convert.ToDateTime(r["ResignDate"]); } catch { ResignDate = DateTime.Now; }

                    r.Close();

                    return true;
                }
                else

                {
                    r.Close();
                    return false;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString() + e.InnerException.Message.ToString() + e.InnerException.InnerException.Message.ToString());
                return false;
            }


            finally { con.Close(); }


        }

        public static int getTopStaffid()
        {

            string nonQ = @"Select LibrarianId from Librarians
                            order by LibrarianId desc";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(nonQ, con);
                SqlDataReader r = cmd.ExecuteReader();

                DataTable df = new DataTable();
                if (r.HasRows) { df.Load(r); }
                con.Close();
                return Int32.Parse(df.Rows[0].ItemArray[0].ToString());

            }
            catch (Exception)
            {
                return 0;
            }
            finally { con.Close(); }

        }

        public static bool AddNewEmployee(int id,string FirstName,  string LastName,int LibraryID,  DateTime HireD, DateTime ResignDate
                 , int Salary, int ShiftId = -1,int AbsCount = 0)
        {
            string nonQ = @"Insert INTO Librarians(LibrarianId,FirstName,LastName,Salary,HireDate,ResignDate,Absences,ShiftId,LibraryId)
                            VALUES(@LibrarianId,@FirstName,@LastName,@Salary,@HireDate,@ResignDate,@Absences,@ShiftId,@LibraryId)";

            try
            {
                con.Open();

                SqlCommand cmdI = new SqlCommand(nonQ, con);

                cmdI.Parameters.AddWithValue("@LibrarianId", id);
                cmdI.Parameters.AddWithValue("@FirstName", FirstName);
                cmdI.Parameters.AddWithValue("@LastName", LastName);
                cmdI.Parameters.AddWithValue("@Salary", Salary);
                cmdI.Parameters.AddWithValue("@HireDate", HireD);
                cmdI.Parameters.AddWithValue("@Absences", AbsCount);
                cmdI.Parameters.AddWithValue("@ShiftId", ShiftId);
                cmdI.Parameters.AddWithValue("@LibraryId", LibraryID);

                if (ResignDate == DateTime.MaxValue)
                    cmdI.Parameters.AddWithValue("@ResignDate", DBNull.Value);
                else
                    cmdI.Parameters.AddWithValue("@ResignDate", ResignDate);

                cmdI.ExecuteNonQuery();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        public static bool UpdateEmployee(int Id, string FirstName, string LastName, int Salary, DateTime HireD, DateTime ResignDate
               ,int AbsCount, int LibraryId, int ShiftId = -1)
        {
            try
            {
                int rowsE = 0;
                con.Open();
                string nonQ = @"Update Librarians 
                                Set FirstName = @FirstName,LastName = @LastName,Salary = @Salary,HireDate = @HireDate,ResignDate = @ResignDate,Absences = @Absences,ShiftId = @ShiftId,LibraryId = @LibraryId
                                Where LibrarianId = @Id";
                SqlCommand cmd = new SqlCommand(nonQ, con);


                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@Salary", Salary);
                cmd.Parameters.AddWithValue("@HireDate", HireD);
                cmd.Parameters.AddWithValue("@Absences", AbsCount);
                cmd.Parameters.AddWithValue("@ShiftId", ShiftId);
                cmd.Parameters.AddWithValue("@LibraryId", LibraryId);

                if (ResignDate == DateTime.MaxValue)
                    cmd.Parameters.AddWithValue("@ResignDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@ResignDate", ResignDate);


                rowsE = cmd.ExecuteNonQuery();

                return rowsE > 0;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return false;
            }


            finally { con.Close(); }

        }
        public static bool DeleteEmployee(int Id)
        {
            string nonQ = "DELETE FROM Librarians WHERE LibrarianId=@Id";
            SqlCommand cmd = new SqlCommand(nonQ, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            int rowsE = 0;

            try
            {
                con.Open();
                rowsE = cmd.ExecuteNonQuery();
                return (rowsE != 0);
            }
            catch { return false; }
            finally { con.Close(); }

        }
        public static DataTable ListAllEmployees()
        {
            string Q = @"
                        select LibrarianId,Libraries.LibName as 'Working at',FirstName,LastName,Salary,HireDate,ResignDate,Absences,
                        Case
	                        When Shifts.ShiftId = 1 Then 'Morning'
	                        When Shifts.ShiftId = 2 Then 'Afternoon'
	                        When Shifts.ShiftId = 3 Then 'night'
                        End as 'Shift time'
                        ,ShiftStartTime,ShiftEndTime from Librarians
                        Inner join Shifts
                        on Librarians.ShiftId = Shifts.ShiftId
                        left join Libraries
                        on Librarians.LibraryId = Libraries.LibraryId;";

            SqlCommand cmd = new SqlCommand(Q, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                
                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }

                return dt;
            }
            catch { return null; }
            finally { con.Close(); }

        }
        public static bool IsEmployeePresent(int id)
        {
            string q = "SELECT found=1 FROM employes WHERE id=@ID";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                con.Open();
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n == 1;
            }
            catch { return false; }
            finally { con.Close(); }
        }
    }
    public class clsLoan
    {
        private static string conS = ConnactionData.ConString;
        private static SqlConnection con = new SqlConnection(conS);
        public static bool Find(int Id, ref int MemberId, ref int BookId, ref DateTime LoanD,
              ref DateTime DueD)
        {
            try
            {
                con.Open();
                string Query = "SELECT * FROM Loans WHERE LoanId=@Id";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {

                    MemberId = Convert.ToInt32( r["MemberId"] );
                    BookId = Convert.ToInt32( r["BookId"] );
                    LoanD = Convert.ToDateTime(r["LoanDate"]);
                    DueD = Convert.ToDateTime(r["ReturnDate"] );




                    r.Close();

                    return true;
                }
                else

                {
                    r.Close();
                    return false;
                }

            }
            catch
            {
                // to do : log the exception in a file or something

                return false;
            }


            finally { con.Close(); }


        }


        public static int getTopLoanid()
        {

            string nonQ = @"Select LoanId from Loans
                            order by LoanId desc";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(nonQ, con);
                SqlDataReader r = cmd.ExecuteReader();

                DataTable df = new DataTable();
                if (r.HasRows) { df.Load(r); }
                con.Close();
                return Int32.Parse(df.Rows[0].ItemArray[0].ToString());

            }
            catch (Exception)
            {
                return 0;
            }
            finally { con.Close(); }

        }

        public static bool AddNewLoan(int id, int MemberId,  int BookId,  DateTime LoanD,
               DateTime DueD)
        {
            string nonQ = @"Insert INTO Loans (LoanId,MemberId,BookId,LoanDate,ReturnDate)
                            VALUES(@LoanId,@MemberId, @BookId, @LoanD, @DueD)";



            int L_ID = -1;

            try
            {
                con.Open();

                SqlCommand cmdI = new SqlCommand(nonQ, con);

                cmdI.Parameters.AddWithValue("@LoanId", id);
                cmdI.Parameters.AddWithValue("@MemberId", MemberId);
                cmdI.Parameters.AddWithValue("@BookId", BookId);
                cmdI.Parameters.AddWithValue("@LoanD", LoanD);
                cmdI.Parameters.AddWithValue("@DueD", DueD);

                cmdI.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool UpdateLoan(int Id,  int MemberId,  int BookId,  DateTime LoanD,
               DateTime DueD)
        {
            try
            {
                int rowsE = 0;
                con.Open();
                string nonQ = @"Update loans 
                                Set MemberId=@MemberId,BookId=@BookId,LoanDate=@LoanD,ReturnDate=@ReturnDate
                                Where LoanId = @id;";
                SqlCommand cmd = new SqlCommand(nonQ, con);

                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                cmd.Parameters.AddWithValue("@BookId", BookId);
                cmd.Parameters.AddWithValue("@LoanD",LoanD );
                cmd.Parameters.AddWithValue("@ReturnDate", DueD);

                rowsE = cmd.ExecuteNonQuery();

                return rowsE > 0;
            }
            catch
            {
                return false;
            }


            finally { con.Close(); }

        }
        public static bool DeleteLoan(int Id)
        {
            string nonQ = "DELETE FROM Loans WHERE LoanId=@Id";
            SqlCommand cmd = new SqlCommand(nonQ, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            int rowsE = 0;

            try
            {
                con.Open();
                rowsE = cmd.ExecuteNonQuery();
                return (rowsE != 0);
            }
            catch { return false; }
            finally { con.Close(); }

        }
        public static DataTable ListAllLoans()
        {
            string Q = @"Select LoanId,Members.FirstName as 'Borrower First name',Members.LastName as 'Borrower last name',Books.Title,LoanDate,ReturnDate from Loans
                         Inner Join Members
                         on Loans.MemberId = Members.MemberId
                         Inner Join Books
                         on Loans.BookId = Books.BookId; ";
            SqlCommand cmd = new SqlCommand(Q, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }

                return dt;
            }
            catch { return null; }
            finally { con.Close(); }

        }
        public static bool IsLoanPresent(int id)
        {
            string q = "SELECT found=1 FROM Loans WHERE LoanId=@ID";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                con.Open();
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n == 1;
            }
            catch { return false; }
            finally { con.Close(); }
        }
    }
    public class clsMember
    {
        private static string conS = ConnactionData.ConString;
        private static SqlConnection con = new SqlConnection(conS);
        public static bool Find(int Id, ref string FirstName, ref string LastName, ref DateTime JoinD,
               ref DateTime EndD)
        {
            try
            {
                con.Open();
                string Query = "SELECT * FROM Members WHERE MemberId=@Id";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", Id);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {

                    FirstName = r["FirstName"].ToString();
                    LastName = r["LastName"].ToString();
                    JoinD = Convert.ToDateTime(r["JoinDate"]);
                    EndD  = Convert.ToDateTime(r["MemberShipEndDate"]);



                    r.Close();

                    return true;
                }
                else

                {
                    r.Close();
                    return false;
                }

            }
            catch
            {
                // to do : log the exception in a file or something

                return false;
            }


            finally { con.Close(); }


        }

        public static int getTopMemberid()
        {

            string nonQ = @"Select MemberId from Members
                            order by MemberId desc";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(nonQ, con);
                SqlDataReader r = cmd.ExecuteReader();

                DataTable df = new DataTable();
                if (r.HasRows) { df.Load(r); }
                con.Close();
                return Int32.Parse(df.Rows[0].ItemArray[0].ToString());

            }
            catch (Exception)
            {
                return 0;
            }
            finally { con.Close(); }

        }

        public static bool AddNewMember(int id ,string FirstName,  string LastName,  DateTime JoinD,
                DateTime EndD)
        {
            string nonQ = @"INSERT INTO Members (MemberId,FirstName, LastName, JoinDate, MemberShipEndDate)
                            VALUES(@MemberId,@FirstName, @LastName, @JoinDate, @MemberShipEndDate);";

            try
            {
                con.Open();

                SqlCommand cmdI = new SqlCommand(nonQ, con);

                cmdI.Parameters.AddWithValue("@MemberId", id);
                cmdI.Parameters.AddWithValue("@FirstName", FirstName);
                cmdI.Parameters.AddWithValue("@LastName", LastName);
                cmdI.Parameters.AddWithValue("@JoinDate", JoinD);
                cmdI.Parameters.AddWithValue("@MemberShipEndDate", EndD);
                cmdI.ExecuteNonQuery();

                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public static bool UpdateMember(int Id,  string FirstName,  string LastName,  DateTime JoinD,
                DateTime EndD)
        {
            try
            {
                con.Open();
                string nonQ = @"Update Members 
                                Set FirstName=@FirstName,LastName=@LastName,JoinDate=@JoinDate,MemberShipEndDate=@MemberShipEndDate
                                Where MemberId = @Id;";
                SqlCommand cmd = new SqlCommand(nonQ, con);

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@JoinDate", JoinD);
                cmd.Parameters.AddWithValue("@MemberShipEndDate", EndD);

                cmd.ExecuteNonQuery();

                return false;
            }
            catch
            {
                return false;
            }


            finally { con.Close(); }

        }
        public static bool DeleteMember(int Id)
        {
            string nonQ = "DELETE FROM Members WHERE MemberId=@Id";
            SqlCommand cmd = new SqlCommand(nonQ, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            int rowsE ;

            try
            {
                con.Open();
                rowsE = cmd.ExecuteNonQuery();
                return (rowsE != 0);
            }
            catch { return false; }
            finally { con.Close(); }

        }
        public static DataTable ListAllMembers()
        {
            string Q = "SELECT MemberId as 'ID',FirstName as 'First name',LastName as 'Last name',JoinDate,MemberShipEndDate as 'Membership ends in' FROM Members";
            SqlCommand cmd = new SqlCommand(Q, con);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }

                return dt;
            }
            catch { return null; }
            finally { con.Close(); }

        }
        public static bool IsMemberPresent(int id)
        {
            string q = "SELECT found=1 FROM Members WHERE id=@ID";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ID", id);
            try
            {
                con.Open();
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n == 1;
            }
            catch { return false; }
            finally { con.Close(); }
        }
    }

}
