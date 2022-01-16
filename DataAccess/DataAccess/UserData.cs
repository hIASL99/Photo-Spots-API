using DataAccess.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class UserData
    {
        public void ChangeUsername(string UserName, string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { UserName = UserName ,
                          Id =Id};
            
            sql.SaveData<dynamic>("dbo.spUpdateUsername", p, "DefaultConnection");
        }
    }
}
