using Lap_4_5_6.DTOs;
using Lap_4_5_6.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace Lap_4_5_6.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if(_dbContext.Attendances.Any(x => x.AttendeeId == userId && x.CourseId == attendanceDto.CourseId))
            {
                return BadRequest("Attendance đã tồn tại!");
            }

            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}