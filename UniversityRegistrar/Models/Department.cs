// using System.Collections.Generic;

// namespace UniversityRegistrar.Models
// {
//   public class Course
//   {
//     public Course()
//     {
//       this.JoinEntities = new HashSet<CourseStudent>();
//     }

//     public int CourseId { get; set; }
//     public string CourseName { get; set; }
//     public string CourseNumber { get; set; }
//     public string Description { get; set; }
//     public string CourseSchedule { get; set; }
//     public string TeacherName { get; set; }
//     public virtual ICollection<CourseStudent> JoinEntities { get; set; }
//   }
// }