using SalaryManagementSystem;
namespace SalaryManagementSystem
{
    internal static class Program
    {
       
        [STAThread] //单线程模式
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}