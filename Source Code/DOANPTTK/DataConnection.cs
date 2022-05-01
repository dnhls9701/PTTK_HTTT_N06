using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DataConnection
    {
        String con;
        public DataConnection()
        {
            con = "Data Source=LAPTOP-1ETUQ04I\\SQLEXPRESS;Initial Catalog=QLTC;Persist Security Info=True;User ID=sa;Password=12345";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(@con);
        }
    }
}
