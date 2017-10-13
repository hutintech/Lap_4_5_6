using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lap_4_5_6.Models
{
    public class Attendance
    {
        public Course Course { get; set; }
        [Key]
        [Column(Order = 1)]
        public int CourseId { get; set; }

        public ApplicationUser Attendee { get; set; }
        [Key]
        [Column(Order =2)]
        public string AttendeeId { get; set; }
        public ICollection<object> Followers { get; internal set; }
    }
}