using System.Data;
using System.Data.SqlClient;

namespace ReportApi.Utility
{
    public class BLL
    {
        private SqlConnection con = new SqlConnection(Getway.AspCoreCon);
        private SqlConnection dgpayconn = new SqlConnection(Getway.Payroll);

        public DataTable get_AspCoreInformationdataTable(string sqlstatement)
        {
            SqlDataAdapter cmd = new SqlDataAdapter(sqlstatement, con);

            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return dt;
        }

        public DataTable get_dgDataTable(string sqlstatement)
        {
            SqlDataAdapter cmd = new SqlDataAdapter(sqlstatement, dgpayconn);

            if (dgpayconn.State == ConnectionState.Closed || dgpayconn.State == ConnectionState.Broken)
            {
                dgpayconn.Open();
            }
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            if (dgpayconn.State == ConnectionState.Open)
            {
                dgpayconn.Close();
            }
            return dt;
        }
    }
}
