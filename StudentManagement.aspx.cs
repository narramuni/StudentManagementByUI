using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School_Database_by_UI
{
    public partial class StudentManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnViewStudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StudentList.aspx");
        }

    }
}