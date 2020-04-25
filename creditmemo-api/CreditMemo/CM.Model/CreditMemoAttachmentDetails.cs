namespace CM.Model
{
    public class CreditMemoAttachmentDetails
    {
        public int ID { get; set; }
        public int CMRequestID { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsFromCreditMemo { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public int CMAttachmentDetailID { get; set; }
        //public string FileName { get; set; }
        //public string Path { get; set; }
        //public bool IsFromCreditMemo { get; set; }
        //public string Type { get; set; }
        //public string Size { get; set; }
    }
}
