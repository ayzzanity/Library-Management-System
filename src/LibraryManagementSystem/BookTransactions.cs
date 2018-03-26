using System.Data;

namespace LibraryManagementSystem
{
    class BookTransactions
    {
        DBTransactions db = new DBTransactions();

        public DataSet loadBorrowedBookInfo(int bookID, int memberID)
        {
            return db.load("SELECT * FROM borrowers WHERE bookID = '" + bookID + "' AND memberID = '" + memberID + "' ");
        }
        public void borrowBook(int bookID, int memberID, string bDate, string dDate)
        {
            db.executeSql("INSERT INTO borrowers (bookID, memberID, borrowdate, duedate) VALUES ('" + bookID + "', '" + memberID + "', '" + bDate + "', '" + dDate + "') ");
            db.executeSql("UPDATE books SET status = 'Borrowed' WHERE bookID = '" + bookID + "' ");
        }
        public DataSet loadBorrowedList()
        {
            return db.load("SELECT CONCAT(firstname,' ',lastname) AS Fullname, books.title, borrowdate FROM books INNER JOIN borrowers ON books.bookID = borrowers.bookID INNER JOIN members ON members.memberID = borrowers.memberID WHERE returndate is NULL ");
        }
        public DataSet loadBorrowedList(int id)
        {
            return db.load("SELECT CONCAT(firstname,' ',lastname) AS Fullname, books.title, borrowdate FROM books INNER JOIN borrowers ON books.bookID = borrowers.bookID INNER JOIN members ON members.memberID = borrowers.memberID WHERE borrowers.memberID = '"+id+"%' AND returndate is NULL ");
        }
        public void returnBook(int bookID, int memberID, string rDate)
        {
            db.executeSql("UPDATE borrowers SET returndate = '" + rDate + "' WHERE bookID = '" + bookID + "' AND memberID = '" + memberID + "' ");
            db.executeSql("UPDATE books SET status = 'Available' WHERE bookID = '" + bookID + "' ");
        }
    }
}
