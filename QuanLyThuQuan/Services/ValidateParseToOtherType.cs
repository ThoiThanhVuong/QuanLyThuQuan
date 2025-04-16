using System;
using System.Diagnostics;

namespace QuanLyThuQuan.Services
{
    internal class ValidateParseToOtherType
    {
        private static ValidateParseToOtherType _INSTANCE = new ValidateParseToOtherType();

        private ValidateParseToOtherType() { }
        public static ValidateParseToOtherType GetInstance()
        {
            return _INSTANCE;
        }

        public int CanParseToInt(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.StackTrace);
                return -1;
            }
        }
    }
}
