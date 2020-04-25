using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{

    public class UserInfo
    {
        public int UserID { get; set; }
        public string GlobalID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string LoginGUID { get; set; }
        public byte[] ProfileImage { get; set; }
        public Secrole[] SecRoles { get; set; }
    }

    public class Secrole
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public Sysplant[] SysPlant { get; set; }
    }

    public class Sysplant
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public Sysdepartment[] SysDepartment { get; set; }
    }

    public class Sysdepartment
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Syscreditapprovallevel[] SysCreditApprovalLevel { get; set; }
    }

    public class Syscreditapprovallevel
    {
        public int CreditApprovalLevelID { get; set; }
        public string CreditApprovalLevelName { get; set; }
    }

}
