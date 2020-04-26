
using System;

namespace Auxillo.Model
{
    public class WidgetTypeMaster
    {
        public int Id { get; set; }
        public string WidgetName { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
