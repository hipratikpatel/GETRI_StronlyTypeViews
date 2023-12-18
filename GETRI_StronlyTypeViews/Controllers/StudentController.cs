using GETRI_StronlyTypeViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_StronlyTypeViews.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student() { StudentId="ST-101", StudentName="Student1", StudentBranch="IT", StudentSection="Programming", StudentGender="Male"},
                new Student() { StudentId="ST-501", StudentName="Student2", StudentBranch="EC", StudentSection="MicroPorcessor", StudentGender="FeMale"},
                new Student() { StudentId="ST-701", StudentName="Student3", StudentBranch="Electrical", StudentSection="Battery", StudentGender="Male"},
                new Student() { StudentId="ST-901", StudentName="Student4", StudentBranch="Mechanical", StudentSection="Pumps", StudentGender="FeMale"}
            };

            return View(students);
        }
    }
}
