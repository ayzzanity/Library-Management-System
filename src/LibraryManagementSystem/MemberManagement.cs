using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class MemberManagement
    {
        DBTransactions db = new DBTransactions();
        public DataSet loadMembers()
        {
            return db.load("SELECT * FROM members");
        }
        public DataSet loadMembers(int id)
        {
            return db.load("SELECT * FROM members WHERE memberID = '" + id + "' ");
        }
        public DataSet loadMembers(string sql)
        {
            return db.load("SELECT * FROM members WHERE CONCAT(firstname,' ',lastname) LIKE '" + sql + "%' OR CONCAT(lastname,' ',firstname) LIKE '" + sql + "%' ");
        }
        public DataSet loadNames(string date)
        {
            return db.load("SELECT CONCAT(firstname,' ',lastname) AS Fullname FROM members WHERE expirydate >= '"+date+"' ORDER BY Fullname ASC");
        }
        public void addMember(string firstname, string lastname, string memdate, string expdate, string memtype)
        {
            db.executeSql("INSERT INTO members (firstname, lastname, membershipdate, expirydate, membershiptype) VALUES ('" + firstname + "','" + lastname + "','" + memdate + "','" + expdate + "','" + memtype + "') ");
        }
        public void updateMember(int id, string firstname, string lastname, string memdate, string expdate, string memtype)
        {
            db.executeSql("UPDATE members SET firstname = '" + firstname + "', lastname = '" + lastname + "', membershipdate = '" + memdate + "', expirydate = '" + expdate + "', membershiptype = '" + memtype + "' WHERE memberID = '"+id+"' ");
        }
        public void deleteMember(int id)
        {
            db.executeSql("DELETE FROM members WHERE memberID = '" + id + "' ");
        }
    }
}
