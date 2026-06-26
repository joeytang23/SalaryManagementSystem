using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace SalaryManagementSystem
{
    public class SalaryManager
    {
        private List<SalaryInfo> salaryList; // 存储所有工资记录的列表
        private string dataFilePath; //JSON数据文件完整路径

        public SalaryManager()
        {
            salaryList = new List<SalaryInfo>();
            dataFilePath = Path.Combine(Application.StartupPath, "salary_data.json");
            LoadData();
        }

        public List<SalaryInfo> GetAllData()
        {
            return salaryList.ToList();
        }

        public bool AddSalary(SalaryInfo salary)
        {
            if (salary == null)
                throw new ArgumentNullException(nameof(salary));

            if (salaryList.Any(s => s.编号 == salary.编号)) // 检查编号是否存在
            {
                MessageBox.Show("该编号已存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            salaryList.Add(salary);
            SaveData();
            return true;
        }

        public bool DeleteSalary(int id)
        {
            var item = salaryList.FirstOrDefault(s => s.编号 == id);
            if (item != null)
            {
                salaryList.Remove(item);
                SaveData();
                return true;
            }
            return false;
        }

        public bool UpdateSalary(SalaryInfo salary)
        {
            var index = salaryList.FindIndex(s => s.编号 == salary.编号);
            if (index >= 0)
            {
                salaryList[index] = salary;
                SaveData();
                return true;
            }
            return false;
        }

        public List<SalaryInfo> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return salaryList.ToList();

            return salaryList.Where(s =>
                s.姓名.Contains(keyword) ||
                s.银行卡号.Contains(keyword)
            ).ToList();
        }

        public List<SalaryInfo> SortByCardNumber(bool ascending = true)
        {
            if (ascending)
                return salaryList.OrderBy(s => s.银行卡号).ToList();
            else
                return salaryList.OrderByDescending(s => s.银行卡号).ToList();
        }

        public List<SalaryInfo> SortBySalary(bool ascending = true)
        {
            if (ascending)
                return salaryList.OrderBy(s => s.实发工资).ToList();
            else
                return salaryList.OrderByDescending(s => s.实发工资).ToList();
        }

        public void SaveData()
        {
            try
            {
                var options = new JsonSerializerOptions  //创建配置对象
                {
                    WriteIndented = true //带缩进换行
                };
                string json = JsonSerializer.Serialize(salaryList, options);
                File.WriteAllText(dataFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存数据失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            try
            {
                if (File.Exists(dataFilePath))
                {
                    string json = File.ReadAllText(dataFilePath);
                    var loaded = JsonSerializer.Deserialize<List<SalaryInfo>>(json);
                    if (loaded != null)
                        salaryList = loaded;
                }
            }
            catch (Exception)
            {
                salaryList = new List<SalaryInfo>();
            }
        }

        public int GetNextId()
        {
            if (salaryList.Count == 0) return 1001;
            return salaryList.Max(s => s.编号) + 1;
        }

        internal bool UpdateWithIdChange(int value, SalaryInfo salary)
        {
            MessageBox.Show("不支持修改编号！", "提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
    }
}



