using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.Services
{
    internal class ValidateConditionServices
    {
        private static ValidateConditionServices _INSTANCE = new ValidateConditionServices();

        private ValidateConditionServices() { }
        public static ValidateConditionServices GetInstance()
        {
            return _INSTANCE;
        }

        public bool IsValidForTransaction(string condition)
        {
            List<string> allowFields = new List<string>();
            foreach (TransactionValidFields validField in Enum.GetValues(typeof(TransactionValidFields)))
            {
                allowFields.Add(validField.ToString());
            }

            if (allowFields.Count.Equals(0))
                return false;
            return allowFields.Contains(condition);
        }
    }
}
