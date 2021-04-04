using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAttendance.model
{
    class Attendance
    {

        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public String StartTime { get; set; }
        public String LeaveTime { get; set; }
        public String Comment { get; set; }
        public Attendance(int TeacherId, int CourseId, int RoomId, string StartTime, string LeaveTime,string Comment)
        {
            this.TeacherId = TeacherId;
            this.CourseId = CourseId;
            this.RoomId = RoomId;
            this.StartTime = StartTime;
            this.LeaveTime = LeaveTime;
            this.Comment = Comment;
        }

    }

}
