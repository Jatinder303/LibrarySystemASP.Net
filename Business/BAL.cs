using System;
using System.Collections.Generic;

namespace LibrarySystem.Business
{
    public class BAL
    {
        Database.DAL obj_Database = new Database.DAL();
        public List<User> GetUserData_BAL()
        {
            try
            {
                List<User> obj_user = obj_Database.GetUserData_DAL();
                return obj_user;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}