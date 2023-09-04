using System.Web.Http;

namespace Phase3Section5._5.Controllers
{
    public class StudentController : ApiController
    {
        Models.Student[] students = new Models.Student[]{
         new  Models.Student {Name="Walter", Class="7A", Address="Address 1", Email="walter@email.com" },
         new Models.Student {Name="Matthew", Class="7A", Address="Address 2", Email="matthew@email.com" },
         new Models.Student {Name="Anne", Class="7A", Address="Address 3", Email="anne@email.com" },
        };

        public IEnumerable<Models.Student> GetAllStudents()
        {
            return students;
        }

        public IHttpActionResult GetStudent(string name)
        {
            var student = students.FirstOrDefault((p) => p.Name == name);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
