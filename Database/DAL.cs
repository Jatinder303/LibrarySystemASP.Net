using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem.Database
{
    public class DAL
    {
        public List<User> GetUserData_DAL()
        {
            using (LibrarySystemEntities db = new LibrarySystemEntities())
            {
                var query = (from u in db.Users select u).ToList();
                return query;
            }
        }

    }
}