using System;

namespace CM.Model
{
    public class LoggedinUser
    {
        public string Loggedin_GlobalID { get; set; }
    }
    public class User
    {
        public int UserId { get; set; }
        public int ID { get; set; }
        public int RoleId { get; set; }
        public Byte[] ProfileImage { get; set; }
        public string GlobalID { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public string RoleName { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public string Mobile { get; set; }
        public string OfficeLocation { get; set; }
        public string Title { get; set; }
        public string LoginGUID { get; set; }
    }

    public class UserDetail: LoggedinUser
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string GlobalID { get; set; }
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public string ContactNo { get; set; }
        public int? DepartmentID { get; set; }
        public string DepartmentName { get; set; }        
        public int CreditLevelID { get; set; }
        public string CreditLevel { get; set; }
        public int RecordStatusID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Comments { get; set; }
        public string RequesterEmail { get; set; }
        public int PlantID { get; set; }
        public int? CreditAmountID { get; set; }
        public string CreditAmount { get; set; }

    }

}
