using System;

namespace SalaryManagementSystem
{
    public class SalaryInfo
    {
        public int 编号 { get; set; }
        public string 姓名 { get; set; }
        public string 银行卡号 { get; set; }
        public decimal 应发工资 { get; set; }
        public decimal 水电费 { get; set; }
        public decimal 税金 { get; set; }
        public decimal 实发工资 { get; set; }
        public void CalculateNetSalary()
        {
            实发工资 = 应发工资 - 水电费 - 税金;
        }
    }
}