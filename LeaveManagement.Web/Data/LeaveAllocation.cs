using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {

        public int NumberOfDays { get; set; }


        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; } //connected to leavetype table
        public int LeaveTypeId { get; set; } //foreign key relationship with table

        public string EmployeeId { get; set; }


    }
}
