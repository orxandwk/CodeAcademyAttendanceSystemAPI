//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeAcademyAttendanceSystemAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lesson_Times
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lesson_Times()
        {
            this.Groups = new HashSet<Groups>();
        }
    
        public int lesson_times_id { get; set; }
        public string lesson_times_name { get; set; }
        public Nullable<System.TimeSpan> lesson_times_start_time { get; set; }
        public Nullable<System.TimeSpan> lesson_times_end_time { get; set; }
        public Nullable<int> lesson_times_group_schedule_id { get; set; }
    
        public virtual Group_Schedule Group_Schedule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groups> Groups { get; set; }
    }
}
