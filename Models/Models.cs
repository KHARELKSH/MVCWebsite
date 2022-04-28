using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace WebApplication1.Models
{
    public class Models
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }



    public class Campus
    {
        public int? campusId { get; set; }
        public string? campusLocation { get; set; }

        public List<Department?> DepartmentId { get; set; }
    }

    public class Department
    {
        public int? departmentId { get; set; }
        public string? departmentName { get; set; }

        public List<Student?> StudentId { get; set; }
    }
    
    public class Student
    {
        public int? studentId { get; set; }
        public string? studentName { get; set; }
        
    }

    public class BigModel
    {
        public Student Student { get; set; }
        public Campus Campus { get; set; }

        public Department Department { get; set; }
    }

}