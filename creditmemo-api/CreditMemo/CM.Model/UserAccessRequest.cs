namespace CM.Model
{
    public class UserAccessRequest
    {
        public int ID { get; set; }
        public string GlobalID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int? CreditAmountID { get; set; }
        public string CreditAmountName { get; set; }
        public decimal CreditAmountFrom { get; set; }
        public decimal CreditAmountTo { get; set; }
        public int? DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public bool? ApprovalStatus { get; set; }
        public string Comments { get; set; }
        public string RequesterEmail { get; set; }
        public string PlantName { get; set; }
        public int RoleID { get; set; }
        public int PlantID { get; set; }
    }
}
