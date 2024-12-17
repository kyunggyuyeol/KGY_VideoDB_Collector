using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_DB_Collecter
{
    public class DbInfo
    {

        public static string server
        {
            get; set;
        }

        public static string id
        {
            get; set;
        }

        public static string pw
        {
            get; set;
        }

        public static string port
        {
            get; set;
        }

        static MySqlConnection dbcon;

        public static MySqlConnection conn
        {
            get
            {
                if (dbcon == null)
                {
                    string strConn = "Server="+server+";Database=videodb;Uid="+id+";Pwd="+pw+";Port='"+port+"';Charset=utf8";
                    dbcon = new MySqlConnection(strConn);
                    return dbcon;
                }
                return dbcon;
            }
        }
    }
}
