using System;
using School_Database_by_UI.Repositories;

namespace School_Database_by_UI
{
    public partial class StudentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolDBConnectionString"].ConnectionString;
            var repository = new StudentRepository(connectionString);

            GridViewStudents.DataSource = repository.GetStudents();
            GridViewStudents.DataBind();
        }
    }
}
