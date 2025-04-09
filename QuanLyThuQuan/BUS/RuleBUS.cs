using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
{
    class RuleBUS
    {
        public List<RuleModel> GetAllRules()
        {
            RuleDAO ruleDAO = new RuleDAO();
            return ruleDAO.GetAllRules();
        }
        public bool AddRule(RuleModel rule)
        {
            RuleDAO ruleDAO = new RuleDAO();
            return ruleDAO.AddRule(rule);
        }
        public bool UpdateRule(RuleModel rule)
        {
            RuleDAO ruleDAO = new RuleDAO();
            return ruleDAO.UpdateRule(rule);
        }

        public bool GetRuleById(int ruleID)
        {
            RuleDAO ruleDAO = new RuleDAO();
            return ruleDAO.RuleExistsById(ruleID);
        }

        public int getMaxRuleID()
        {
            RuleDAO ruleDAO = new RuleDAO();
            return ruleDAO.GetMaxRuleId();
        }
        public bool DeleteRule(int ruleID)
        {
            RuleDAO ruleDAO = new RuleDAO();
            return ruleDAO.DeleteRule(ruleID);
        }

        public List<RuleModel> GetActiveRules()
        {
            RuleDAO ruleDAO = new RuleDAO();
            return ruleDAO.GetActiveRules();
        }
    }
}
