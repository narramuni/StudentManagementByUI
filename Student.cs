using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Database_by_UI
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Computed property for full name
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}