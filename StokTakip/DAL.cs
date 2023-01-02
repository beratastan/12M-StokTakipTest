using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    internal class DAL
    {
        SqlConnection connection;

        public DAL()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["StokTakipDB"].ConnectionString;
        }

        public void SetConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            else
                connection.Close();
        }

        public SqlDataReader GetTransactionList()
        {
            SqlCommand command = new SqlCommand("GetTransactionList", connection);
            command.CommandType = CommandType.StoredProcedure;
            SetConnect();
            return command.ExecuteReader();
        }

        public SqlDataReader GetTransactionListByCode(string MalKodu)
        {
            SqlCommand command = new SqlCommand("GetTransactionListByCode", connection);
            command.Parameters.Add("@MalKodu", SqlDbType.VarChar).Value = MalKodu;
            command.CommandType = CommandType.StoredProcedure;
            SetConnect();
            return command.ExecuteReader();
        }

        public SqlDataReader GetTransactionListByDate(int Tarih1, int Tarih2)
        {
            SqlCommand command = new SqlCommand("GetTransactionListByDate", connection);
            //DateTime t = Convert.ToDateTime(Tarih1);
            command.Parameters.Add("@Tarih1", SqlDbType.Int).Value = Tarih1;
            command.Parameters.Add("@Tarih2", SqlDbType.Int).Value = Tarih2;
            command.CommandType = CommandType.StoredProcedure;
            SetConnect();
            return command.ExecuteReader();
        }
    }
}
