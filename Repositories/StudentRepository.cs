using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using School_Database_by_UI; 
 

namespace School_Database_by_UI.Repositories
{
    public class StudentRepository
    {
        private readonly string connectionString;

        public StudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Students";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString()
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }


        public Student GetStudentByID(int studentID)
        {
            // Implementation to retrieve a student by ID
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString()
                            };
                        }
                    }
                }
            }

            return null; // Return null if the student with the given ID is not found
        }

        public void UpdateStudent(Student updatedStudent)
        {
            // Implementation to update a student
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", updatedStudent.StudentID);
                    command.Parameters.AddWithValue("@FirstName", updatedStudent.FirstName);
                    command.Parameters.AddWithValue("@LastName", updatedStudent.LastName);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStudent(Student studentToDelete)
        {
            // Implementation to delete a student
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentToDelete.StudentID);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Students (FirstName, LastName) VALUES (@FirstName, @LastName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
