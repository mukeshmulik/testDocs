using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class RootCauseDTO
    {
        public int ID { get; set; }
        public int CMRequestID { get; set; }
        public int DepartmentID { get; set; }
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string RootCause { get; set; }
        //public string PlantResponse { get; set; }
        public string DepartmentName { get; set; }
        public string PlantName { get; set; }
        public string FullName { get; set; }
        public byte[] ProfilePic { get; set; }

    }
    public class PlantResponseDTO
    {
        public int ID { get; set; }
        public int CMRequestID { get; set; }
        public int DepartmentID { get; set; }
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        //public string RootCause { get; set; }
        public string PlantResponse { get; set; }
        public string DepartmentName { get; set; }
        public string PlantName { get; set; }
        public string FullName { get; set; }
        public byte[] ProfilePic { get; set; }

    }
}
