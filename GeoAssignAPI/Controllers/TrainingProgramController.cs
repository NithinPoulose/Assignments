using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeoAssignAPI.Controllers
{
    [ApiController]
    public class TrainingProgramController : ControllerBase
    {
        int id;
        int CId;
        int Flag = 0;
        public static List<Student> stud = new List<Student>();
        public static List<Course> crs = new List<Course>();

        //Course part

        [HttpPost("api/course")]
        public IActionResult AddCourse(Course Cou)
        {
            var LastCourse = crs.OrderByDescending(x => x.CourseId).FirstOrDefault();
            CId = LastCourse == null ? 1 : LastCourse.CourseId + 1;
            var Addcrs = new Course
            {
                CourseId = CId,
                CourseCode = Cou.CourseCode,
                CourseName = Cou.CourseName,
            };
            crs.Add(Addcrs);
            return Ok(Addcrs);
        }

        [HttpGet("api/course")]
        public IActionResult GetCourses()
        {
            return Ok(crs);
        }

        [HttpDelete("api/course/{Id}")]
        public IActionResult DeleteCourse(int id)
        {
            foreach (var data in crs)
            {
                if (data == null)
                    return NotFound("Course Not Found");
                if (data.CourseId == id)
                {
                    crs.Remove(crs.Single(x => x.CourseId == id));
                    return Ok("Course Deleted");
                }
            }
            return Ok();
        }

        [HttpPut("api/course")]
        public IActionResult EditCourse(Course PutCourse)
        {
            foreach (var data in crs)
            {
                if (data == null)
                    return NotFound();
                if (data.CourseId == PutCourse.CourseId)
                {
                    data.CourseId = PutCourse.CourseId;
                    data.CourseCode = PutCourse.CourseCode;
                    data.CourseName = PutCourse.CourseName;
                    return Ok("Update Successful");
                }
            }
            return Ok();
        }

        //Course and Student Details
        [HttpGet("api/course/count")]
        public IActionResult CourseAndStudents()
        {
            var list = from c in crs
                       join s in stud
                       on c.CourseName equals s.Course
                       group s by s.Course into grp
                       select new { Course = grp.Key, Count = grp.Count() };
            return Ok(list);
        }


        //Student part

        [HttpPost("api/student")]
        public IActionResult CreateStudent(Student std)
        {

            foreach (var course in crs)
            {
                if (std.Course == course.CourseName)
                {
                    Flag = 1;
                }
            }
            if (Flag == 0)
                return Conflict("Course not Found");
            if (Convert.ToDateTime(std.DOB) > DateTime.Now || Convert.ToDateTime(std.EnrolDate) > DateTime.Now)
            {
                return Conflict("Enter valid Date");
            }
            else
            {
                var LastStudent = stud.OrderByDescending(x => x.Id).FirstOrDefault();
                id = LastStudent == null ? 1 : LastStudent.Id + 1;
                var newstudentdata = new Student
                {
                    Id = id,
                    FirstName = std.FirstName,
                    LastName = std.LastName,
                    DOB = std.DOB,
                    Address = std.Address,
                    PhNo = std.PhNo,
                    Course = std.Course,
                    EnrolDate = std.EnrolDate
                };
                stud.Add(newstudentdata);
                return Ok(newstudentdata);
            }
        }

        [HttpGet("api/student")]
        public IActionResult GetStudentData()
        {
            return Ok(stud);
        }

        [HttpGet("api/student/{id}")]
        public IActionResult GetStudentbyId(int id)
        {
            var Student = stud.SingleOrDefault(x => x.Id == id);
            if (Student == null)
            {
                return NotFound();
            }

            return Ok(new Student
            {
                Id = Student.Id,
                FirstName = Student.FirstName,
                LastName = Student.LastName,
                DOB = Student.DOB,
                Address = Student.Address,
                PhNo = Student.PhNo,
                Course = Student.Course,
                EnrolDate = Student.EnrolDate
            });

        }

        [HttpPut("api/student")]
        public IActionResult EditStudent(Student PutData)
        {
            foreach (var data in stud)
            {
                if (data.Id == PutData.Id)
                {
                    data.Id = PutData.Id;
                    data.FirstName = PutData.FirstName;
                    data.LastName = PutData.LastName;
                    data.DOB = PutData.DOB;
                    data.Address = PutData.Address;
                    data.PhNo = PutData.PhNo;
                    data.Course = PutData.Course;
                    data.EnrolDate = PutData.EnrolDate;
                    return Ok();
                }
            }
            return NotFound();
        }

        [HttpDelete("api/student/{id}")]
        public IActionResult DeleteStudentByID(int id)
        {

            foreach (var item in stud)
            {
                if (item.Id == null)
                {
                    return NotFound("Student Not Found");
                }
                else if (item.Id == id)
                {
                    stud.Remove(stud.Single(x => x.Id == id));
                    return Ok("Deleted Successfully");
                }

            }
            return Ok();

        }

    }

}