using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;

namespace LinqNorthWind
{
    [Table(Name = "Customers")]
    public class Customer
    {
        private string _companyName;
        [Column]
        public string CustomerID
        {
            get;
            set;
        }
        [Column(Storage = "_companyName", DbType = "nvarchar(80) not null", CanBeNull = false)]
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        [Column]
        public string City { get; set; }
    }

    [Table(Name = "Orders")]
    public class Orders
    {

        public int _orderId;
        private string _customerID;

        [Column]
        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        private EntityRef<Customer> _Customer;

        [Association(Storage = "_Customer", ThisKey = "_customerID")]
        public Customer Customer
        {
            get
            {
                return this._Customer.Entity;
            }
            set
            {
                this._Customer.Entity = value;
            }
        }
        [Column(IsPrimaryKey = true, Storage = "_orderId")]
        public int OrderID
        {
            get;
            set;
        }
    }
    [Table(Name = "userTable")]
    public class UserTable
    {
        private int _userId;
        private string _username;


        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "int not null")]
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        [Column(DbType = "nvarchar(100)", CanBeNull = false)]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;
        [Column(DbType = "nvarchar(100)", CanBeNull = false)]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            practiceDatatDataContext practiceDB = new practiceDatatDataContext();
            //int count = practiceDB.ExecuteCommand("create table T4(userid int identity primary key, username nvarchar(200) not null, userpass nvarchar(200) not null)");
           int count = practiceDB.ExecuteCommand("drop table T3; drop table T4");
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
