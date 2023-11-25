using System;
using School_Database_by_UI.Repositories;
using School_Database_by_UI;

namespace School_Database_by_UI
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolDBConnectionString"].ConnectionString;
            var repository = new StudentRepository(connectionString);

            var newStudent = new Student
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };

            repository.AddStudent(newStudent);

            Response.Redirect("~/StudentList.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
