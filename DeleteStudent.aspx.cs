using School_Database_by_UI.Repositories;
using System;
using System.Web.UI.WebControls;

namespace School_Database_by_UI
{
    public partial class DeleteStudent : System.Web.UI.Page
    {
        private StudentRepository repository;

        protected void Page_Load(object sender, EventArgs e)
        {
            repository = new StudentRepository(System.Configuration.ConfigurationManager.ConnectionStrings["SchoolDBConnectionString"].ConnectionString);

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
                lblStudentDetails.Text = $"Student ID: {existingStudent.StudentID}<br />" +
                                         $"First Name: {existingStudent.FirstName}<br />" +
                                         $"Last Name: {existingStudent.LastName}";
            }
        }

        protected void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(ddlStudentList.SelectedValue);
            var existingStudent = repository.GetStudentByID(studentID);

            if (existingStudent != null)
            {
                repository.DeleteStudent(existingStudent);
            }

            Response.Redirect("~/StudentList.aspx");
        }

        private void PopulateStudentList()
        {
            try
            {
                var students = repository.GetStudents();

                ddlStudentList.DataSource = students;
                ddlStudentList.DataTextField = "StudentID"; // Display StudentID in the DropDownList
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
