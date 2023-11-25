using System;
using System.Web.UI.WebControls;
using School_Database_by_UI.Repositories;
using School_Database_by_UI;

namespace School_Database_by_UI
{
    public partial class EditStudent : System.Web.UI.Page
    {
        private StudentRepository repository;

        protected void Page_Load(object sender, EventArgs e)
        {
            repository = new StudentRepository(System.Configuration.ConfigurationManager.ConnectionStrings["SchoolDBConnectionString"].ConnectionString);

            // Only populate the DropDownList during the initial page load
            if (!IsPostBack)
            {
                PopulateStudentList();
            }
        }


        protected void ddlStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedStudentID = Convert.ToInt32(ddlStudentList.SelectedValue);
            var existingStudent = repository.GetStudentByID(selectedStudentID);

            if (existingStudent != null)
            {
                txtFirstName.Text = existingStudent.FirstName;
                txtLastName.Text = existingStudent.LastName;
            }
        }


        protected void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(ddlStudentList.SelectedValue);
            var existingStudent = repository.GetStudentByID(studentID);

            if (existingStudent != null)
            {
                existingStudent.FirstName = txtFirstName.Text;
                existingStudent.LastName = txtLastName.Text;

                repository.UpdateStudent(existingStudent);
            }

            Response.Redirect("~/StudentList.aspx");
        }

        private void PopulateStudentList()
        {
            try
            {
                var students = repository.GetStudents();

                ddlStudentList.DataSource = students;
                ddlStudentList.DataTextField = "StudentID"; // Use "FullName" property for display
                ddlStudentList.DataValueField = "StudentID";
                ddlStudentList.DataBind();
            }
            catch (Exception ex)
            {
                // Log or print the exception details for debugging.
                Console.WriteLine(ex.Message);
            }
        }







    }
}
