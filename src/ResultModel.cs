
using System;
using Starcounter;

namespace PresModels
{
    public enum ResultFlag
    {
        Pass,
        Note,
        Error
    }

    [Database]
    public class ResultModel
    {
        public ResultFlag ResultFlag { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Account { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
    }
}