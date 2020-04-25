using System.Collections.Generic;

namespace CM.Model
{
    public class RootCauseInvestigationActionList
    {
        public int CreditMemoReqestNo { get; set; }
        public virtual ICollection<RootCauseInvestigation> RootCauseInvestigationList { get; set; }

    }
}
