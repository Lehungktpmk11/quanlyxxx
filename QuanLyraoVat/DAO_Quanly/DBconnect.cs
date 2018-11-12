using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO_Quanly
{
    public class DBconnect
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Raovat\QuanLyRaoVat\QuanLyraoVat\Database1.mdf;Integrated Security=True
        protected SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["xxx"].ConnectionString);
        string sqlconnection = ConfigurationManager.ConnectionStrings["xxx"].ConnectionString;
        
    }
}
