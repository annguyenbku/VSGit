using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Quản__lí_nhà_hàng.DAO
{
    class AccountDAO
    {
        public bool Login(string username,string password)
        {
            string query = "SELECT * FROM dbo.ACOUNT WHERE UserName='"+username+"' AND Password = '"+password+"'";
            Data_Provider result = new Data_Provider();
            DataTable kq = result.ExecuteQuery(query);
                return kq.Rows.Count > 0;
        }
        public bool check_admin(string username, string password)
        {
            string query = "SELECT TYPE FROM dbo.ACOUNT WHERE UserName='" + username + "' AND Password = '" + password + "' AND TYPE = 1";
            Data_Provider result = new Data_Provider();
            DataTable kq = result.ExecuteQuery(query);
            return kq.Rows.Count>0;
        }
    }
}
