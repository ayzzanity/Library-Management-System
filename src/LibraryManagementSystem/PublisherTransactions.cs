using System.Data;

namespace LibraryManagementSystem
{
    class PublisherTransactions
    {
        DBTransactions db = new DBTransactions();
        public DataSet loadBooks(string sql)
        {
            return db.load("SELECT * FROM publishers WHERE publishername LIKE '"+sql+"%' ");
        }
        public DataSet loadPublishers()
        {
            return db.load("SELECT DISTINCT publishername FROM publishers");
        }
    }
}
