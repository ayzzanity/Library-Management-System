using System.Data;

namespace LibraryManagementSystem
{
    class BookManagement
    {
        DBTransactions db = new DBTransactions();
        public DataSet loadBooks()
        {
            return db.load("SELECT * FROM books");
        }
        public DataSet loadBooks(int id)
        {
            return db.load("SELECT * FROM books WHERE bookID = '" + id + "' ");
        }
        public DataSet loadBooks(string sql)
        {
            return db.load("SELECT * FROM books WHERE title LIKE '%" + sql + "%' or author LIKE '%" + sql + "%' ");
        }
        public DataSet loadAvailBooks()
        {
            return db.load("SELECT * FROM books WHERE Status = 'Available' ");
        }
        public void addBook(string title, string author, string status)
        {
            db.executeSql("INSERT INTO books (title, author, status) VALUES ('" + title + "','" + author + "','" + status + "') ");
        }
        public void deleteBook(int id)
        {
            db.executeSql("DELETE FROM books WHERE bookID = '" + id + "' ");
        }
    }
}
