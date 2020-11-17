using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManyToManyRelationships
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentDBContext studentDBContext = new StudentDBContext();

            var query = from student in studentDBContext.Students
                                   from course in student.Courses
                                   select new
                                   {
                                       StudentName = student.StudentName,
                                       CourseName = course.CourseName
                                   };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentDBContext employeeDBContext = new StudentDBContext();
            Cours WCFCourse = employeeDBContext.Courses
                .FirstOrDefault(x => x.CourseID == 4);

            employeeDBContext.Students.FirstOrDefault(x => x.StudentID == 1)
                .Courses.Add(WCFCourse);
            employeeDBContext.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StudentDBContext employeeDBContext = new StudentDBContext();
            Cours SQLServerCourse = employeeDBContext.Courses
                .FirstOrDefault(x => x.CourseID == 3);

            employeeDBContext.Students.FirstOrDefault(x => x.StudentID == 2)
                .Courses.Remove(SQLServerCourse);
            employeeDBContext.SaveChanges();
        }
        p
    }
}