using Lap_4_5_6.Models;
using System.Collections.Generic;

namespace Lap_4_5_6.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}