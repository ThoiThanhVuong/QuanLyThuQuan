using System;

namespace ThuQuanWebForm.Model
{
    public class RuleModel
    {
        public int RuleID { get; set; }
        public string RuleTitle { get; set; }
        public string RuleDescription { get; set; }
        public string Penalty { get; set; }
        public DateTime EffectiveDate { get; set; }
        public ActivityStatus RuleStatus { get; set; }

        // Constructor không tham số
        public RuleModel() { }

        public RuleModel(int ruleID, string ruleTitle, string ruleDescription, string penalty, DateTime effectiveDate, ActivityStatus ruleStatus)
        {
            RuleID = ruleID;
            RuleTitle = ruleTitle;
            RuleDescription = ruleDescription;
            Penalty = penalty;
            EffectiveDate = effectiveDate;
            RuleStatus = ruleStatus;
        }

        public RuleModel(string ruleTitle, string ruleDescription, string penalty, DateTime effectiveDate, ActivityStatus ruleStatus)
        {
            RuleTitle = ruleTitle;
            RuleDescription = ruleDescription;
            Penalty = penalty;
            EffectiveDate = effectiveDate;
            RuleStatus = ruleStatus;
        }
    }
}
