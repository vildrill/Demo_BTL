using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo_BTL
{
    internal class KetnoiDb
    {
        string strConnect = @"Data Source=LAPTOP-C2K0J1R6\SQLEXPRESS;Initial Catalog=QLKT;Integrated Security=True";
        SqlConnection conn = null;

        public void Ketnoidb()
        {
            conn = new SqlConnection(strConnect);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void DKetnoidb()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose(); // huy doi tuong 
            }
        }
        public DataTable Docbang(string sql)
        {
            DataTable dtBang = new DataTable();
            Ketnoidb();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            sqlDataAdapter.Fill(dtBang);
            Ketnoidb();
            return dtBang;

        }
        public void CapNhatDuLieu(string sql)

        {
            Ketnoidb();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = conn;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DKetnoidb();

        }
    }
}
