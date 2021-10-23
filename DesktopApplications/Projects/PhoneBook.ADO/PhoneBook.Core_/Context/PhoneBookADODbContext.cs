using System.Data.SqlClient;

namespace PhoneBook.Core_.Context
{
    public class PhoneBookADODbContext
    {

        public PhoneBookADODbContext()
        {
            _connection = new SqlConnection("Data Source=.;Initial Catalog=PhoneBook;Integrated Security=True");
        }
        private SqlConnection _connection;

        public SqlConnection Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        private SqlCommand _command;

        public SqlCommand Command
        {
            get { return _command; }
            set { _command = value; }
        }

        private SqlDataReader _dataReader;

        public SqlDataReader DataReader
        {
            get { return _dataReader; }
            set { _dataReader = value; }
        }

        private int _returnValues;

        public int ReturnValues
        {
            get { return _returnValues; }
            set { _returnValues = value; }
        }


        public void SetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open) _connection.Close();
            else _connection.Open();
        }

    }
}

