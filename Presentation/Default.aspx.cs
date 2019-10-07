using System;
using System.Collections.Generic;
using System.Web.UI;

namespace LibrarySystem
{
    public partial class _Default : Page
    {
        Business.BAL obj_Business = new Business.BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            FillUser();
        }


        private void FillUser()
        {

            List<User> Obj_user_list = obj_Business.GetUserData_BAL();
            if (Obj_user_list != null && Obj_user_list.Count > 0)
            {
                gvUser.DataSource = Obj_user_list;
                gvUser.DataBind();
            }
        }
    }
}