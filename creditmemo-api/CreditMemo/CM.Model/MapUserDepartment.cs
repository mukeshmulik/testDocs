using System;

namespace CM.Model
{
    public class MapUserDepartment
    {
        public int MapUserDepartmentId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public string CreditLevel { get; set; }  // need to review 
        public bool IsApproved { get; set; }
        public DateTime MyProperty { get; set; }
    }
}
