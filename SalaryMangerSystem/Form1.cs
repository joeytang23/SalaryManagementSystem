using SalaryManagementSystem;
using System;
using System.Collections.Generic; //泛型集合<List<T>>
using System.Drawing; //颜色 字体等图形相关类
using System.Linq; //LINQ查询where select等
using System.Windows.Forms;


namespace SalaryManagementSystem
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class Form1 : Form
    {
        private SalaryManager manager; // 负责数据管理的类实例
        private List<SalaryInfo> currentData;// 当前显示的数据列表
        // 使用设计器生成的 dataGridView1，删除旧的重复字段以避免空引用
        private ComboBox cmbSortField, cmbSortOrder;// 排序选项的 ComboBox
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox txtld;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtCard;
        private Label label4;
        private TextBox txtGross;
        private Label label5;
        private TextBox txtUtilities;
        private Label label6;
        private TextBox txtTax;
        private Label label7;
        private TextBox txtNet;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private FontDialog fontDialog1;
        private Button btnCalc;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label8;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label9;
        private Button btnSort;
        private Button btnRefresh;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colld;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCard;
        private DataGridViewTextBoxColumn colGross;
        private DataGridViewTextBoxColumn colUtilities;
        private DataGridViewTextBoxColumn colTax;
        private DataGridViewTextBoxColumn colNet;
        private Label lblStats;
        private TextBox txtId;
        // private SalaryInfo salary;
        private int? selectedOriginalId;
        // ========== 分页功能（新增） ==========
        private Panel panelPagination;// 分页面板，包含分页按钮和页码显示
        private Button btnFirst, btnPrev, btnNext, btnLast;
        private Label lblPageInfo;
        private int currentPage = 1;
        private int pageSize = 36;        // 大窗口每页20条
        private List<SalaryInfo> allDataForPaging;
        private bool isPagingMode = false;
        private bool formLoaded = false;  // 标记Form是否加载完成
        public Form1()
        {
            InitializeComponent();
            txtId = txtld;
            manager = new SalaryManager();
            currentData = new List<SalaryInfo>();
            CreatePaginationPanel();  // 创建分页面板
        }
        // ========== 分页功能实现 ==========
        private void CreatePaginationPanel()
        {

            panelPagination = new Panel();
            panelPagination.Height = 45;
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Visible = false;
            panelPagination.BackColor = Color.LightSteelBlue;

            var flow = new FlowLayoutPanel();// 使用FlowLayoutPanel自动布局分页按钮
            flow.Dock = DockStyle.Fill;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.Padding = new Padding(5);// 内边距，避免按钮贴边

            btnFirst = CreatePageButton("⏮ 首页");
            btnPrev = CreatePageButton("◀ 上一页");
            lblPageInfo = new Label { Text = "第 1/1 页", Width = 100, TextAlign = ContentAlignment.MiddleCenter, Height = 30 };
            btnNext = CreatePageButton("下一页 ▶");
            btnLast = CreatePageButton("末页 ⏭");

            btnFirst.Click += (s, e) => GoToPage(1);//+=事件绑定，调用GoToPage方法跳转到指定页
            btnPrev.Click += (s, e) => GoToPage(currentPage - 1);//lambda表达式简化事件处理
            btnNext.Click += (s, e) => GoToPage(currentPage + 1);
            btnLast.Click += (s, e) => GoToPage(int.MaxValue);

            flow.Controls.AddRange(new Control[] { btnFirst, btnPrev, lblPageInfo, btnNext, btnLast });
            // 将按钮添加到FlowLayoutPanel
            panelPagination.Controls.Add(flow);
            // 将FlowLayoutPanel添加到分页面板

            this.Controls.Add(panelPagination);// 将分页面板添加到Form
            panelPagination.BringToFront();

            // 关键：等Form加载完成后再判断，避免初始化时误触发
            this.Load += (s, e) => {
                formLoaded = true;
                CheckWindowMode();
            };
            this.SizeChanged += (s, e) =>
            { //拖动窗口时触发
                if (!formLoaded) return;

                bool wasPaging = isPagingMode;
                CheckWindowMode();

                if (isPagingMode && wasPaging)
                {
                    CalculatePageSize();
                    ShowPagedData();
                }
            };
        }

        private Button CreatePageButton(string text)
        {
            return new Button
            {
                Text = text,
                Width = 75,
                Height = 30,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                Margin = new Padding(3)
            };
        }

        private void CheckWindowMode()
        {
            bool shouldPaging = this.WindowState == FormWindowState.Maximized ||
                               (this.Width >= 1400 && this.Height >= 700);

            if (shouldPaging != isPagingMode)
            {
                isPagingMode = shouldPaging;
                panelPagination.Visible = isPagingMode;// 显示或隐藏分页面板

                if (isPagingMode)
                {
                    dataGridView1.ScrollBars = ScrollBars.None;// 隐藏滚动条，分页显示
                    allDataForPaging = manager.GetAllData();
                    currentPage = 1;
                    CalculatePageSize();
                    ShowPagedData();
                }
                else
                {
                    dataGridView1.ScrollBars = ScrollBars.Vertical;
                    LoadData();
                }
            }
        }

        private void ShowPagedData()
        {
            if (allDataForPaging == null) return;
            // 计算总页数，向上取整，确保至少1页
            int totalPages = (int)Math.Ceiling(allDataForPaging.Count / (double)pageSize);
            if (totalPages < 1) totalPages = 1;

            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            var pageData = allDataForPaging // 跳过前面页的数据，取当前页的数据
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            dataGridView1.DataSource = null;// 先清空数据源，避免绑定时的刷新问题
            dataGridView1.DataSource = pageData;

            lblPageInfo.Text = $"第 {currentPage}/{totalPages} 页";

            btnFirst.Enabled = currentPage > 1;
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;

            UpdateStats();
        }

        private void GoToPage(int page)
        {
            if (allDataForPaging == null) return;

            int totalPages = (int)Math.Ceiling(allDataForPaging.Count / (double)pageSize);

            if (page < 1) page = 1;
            if (page > totalPages) page = totalPages;

            currentPage = page;
            ShowPagedData();
        }
        private void CalculatePageSize()
        {
            int gridHeight = dataGridView1.Height;
            int headerHeight = dataGridView1.ColumnHeadersHeight;

            // 关键修复：多减5像素边距，再减1行，确保不溢出
            int availableHeight = gridHeight - headerHeight - 5;

            int rowHeight = dataGridView1.RowTemplate.Height;// 获取模板行高，
            if (rowHeight < 1)
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[0].Height > 0)
                    rowHeight = dataGridView1.Rows[0].Height;
                else
                    rowHeight = 30;
            }

            // 再减1行确保最后一行不被遮挡
            pageSize = Math.Max(1, (availableHeight / rowHeight) - 1);

            if (pageSize < 10) pageSize = 10;
            if (pageSize > 50) pageSize = 50;
        }   

        // 加载数据
        private void LoadData()
        {
            currentData = manager.GetAllData();
            RefreshGrid();
            UpdateStats();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = currentData;
        }

        private void UpdateStats()
        {
            var dataToCount = isPagingMode ? allDataForPaging : currentData;

            if (dataToCount != null && dataToCount.Count > 0)
            {
                decimal total = dataToCount.Sum(s => s.实发工资);
                decimal avg = dataToCount.Average(s => s.实发工资);
                lblStats.Text = $"  共 {dataToCount.Count} 人  |  实发合计：{total:N2}元  |  平均：{avg:N2}元";
            }
            else
            {
                lblStats.Text = "  暂无数据，请添加工资记录";
            }
        }

        // 计算工资
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGross.Text, out decimal gross))// 验证应发工资输入是否有效
            {
                MessageBox.Show("应发工资格式错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal utilities = string.IsNullOrEmpty(txtUtilities.Text) ? 0 : decimal.Parse(txtUtilities.Text);
            decimal tax = string.IsNullOrEmpty(txtTax.Text) ? 0 : decimal.Parse(txtTax.Text);

            decimal net = gross - utilities - tax;
            txtNet.Text = net.ToString("N2");
        }

        // 添加
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            BtnCalc_Click(null, null); // 先计算实发工资

            var salary = new SalaryInfo
            {
                编号 = int.Parse(txtId.Text),
                姓名 = txtName.Text.Trim(),
                银行卡号 = txtCard.Text.Trim(),
                应发工资 = decimal.Parse(txtGross.Text),
                水电费 = string.IsNullOrEmpty(txtUtilities.Text) ? 0 : decimal.Parse(txtUtilities.Text),
                税金 = string.IsNullOrEmpty(txtTax.Text) ? 0 : decimal.Parse(txtTax.Text),
                实发工资 = decimal.Parse(txtNet.Text)
            };

            if (manager.AddSalary(salary))
            {
                MessageBox.Show("添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
        }
        

        private void ClearForm()
        {
            txtld.Text = manager.GetNextId().ToString();
            txtName.Clear();
            txtCard.Clear();
            txtGross.Clear();
            txtUtilities.Clear();
            txtTax.Clear();
            txtNet.Clear();
            dataGridView1.ClearSelection();
        }

        // 验证输入
        // 限制银行卡号只能输入数字，且最多19位
        private void TxtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许数字键(0-9)和退格键(Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;  // 拦截这个按键，不输入到文本框
            }

            // 如果已经19位了，再按数字键也拦截（退格键除外）
            if (txtCard.Text.Length >= 19 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("请输入姓名！", "验证错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCard.Text))
            {
                MessageBox.Show("请输入银行卡号！", "验证错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCard.Focus();
                return false;
            }
            string card = txtCard.Text.Trim();
            if (card.Length < 16 || card.Length > 19)
            {
                MessageBox.Show("银行卡号位数错误！\n请输入 16-19 位数字。", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCard.Focus();
                return false;
            }
            if (!decimal.TryParse(txtGross.Text, out _))
            {
                MessageBox.Show("应发工资格式错误！", "验证错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGross.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            LoadData();
            ClearForm();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedOriginalId == null)
            {
                MessageBox.Show("请先从表格中选择记录！");
                return;
            }

            btnCalc_Click(null, null);

            if (!int.TryParse(txtld.Text, out int newId))
            {
                MessageBox.Show("编号格式错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var salary = new SalaryInfo
            {
                编号 = newId,
                姓名 = txtName.Text,
                银行卡号 = txtCard.Text,
                应发工资 = decimal.Parse(txtGross.Text),
                水电费 = string.IsNullOrEmpty(txtUtilities.Text) ? 0 : decimal.Parse(txtUtilities.Text),
                税金 = string.IsNullOrEmpty(txtTax.Text) ? 0 : decimal.Parse(txtTax.Text),
                实发工资 = decimal.Parse(txtNet.Text)
            };

            // 如果编号不变，直接更新；否则调用支持 id 变更的接口
            if (selectedOriginalId.HasValue && selectedOriginalId.Value == salary.编号)
            {
                if (manager.UpdateSalary(salary))
                {
                    MessageBox.Show("修改成功！");
                    ClearForm();
                    btnRefresh_Click(null, null);
                }
                else
                {
                    MessageBox.Show("修改失败，记录不存在或已被删除。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // 尝试数据层原子更新（旧 id -> 新 id），若失败提示冲突
                if (manager.UpdateWithIdChange(selectedOriginalId.Value, salary))
                {
                    MessageBox.Show("修改成功（编号已变更）！");
                    ClearForm();
                    btnRefresh_Click(null, null);
                }
                else
                {
                    MessageBox.Show("修改失败：新编号已存在或原记录不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manager.GetAllData();
            UpdateStats();
        }

        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGross.Text, out decimal gross))
            {
                MessageBox.Show("应发工资格式错误！", "提示");
                return;
            }
            decimal utilities = string.IsNullOrEmpty(txtUtilities.Text) ? 0 : decimal.Parse(txtUtilities.Text);
            decimal tax = string.IsNullOrEmpty(txtTax.Text) ? 0 : decimal.Parse(txtTax.Text);
            txtNet.Text = (gross - utilities - tax).ToString("N2");
        }



        private void btnRefresh_Click(object value1, object value2)
        {
            // 转发到 UI 刷新实现，供旧调用使用
            btnRefresh_Click_1(null, null);
        }

        private void btnCalc_Click(object value1, object value2)
        {
            // 转发到 UI 计算实现，供旧调用使用
            btnCalc_Click_1(null, null);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先从表格中选择记录！");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            int id;

            // 首先尝试直接从绑定的模型读取编号，最稳健
            if (row.DataBoundItem is SalaryInfo info) //databounditem是当前行绑定的数据对象
            {
                id = info.编号;
            }
            else
            {
                // 兼容旧版：尝试按列名 'Id' 查找，再降级到第一列
                DataGridViewCell cell = null;
                try
                {
                    cell = row.Cells["Id"];
                }
                catch (ArgumentException)
                {
                    // 如果不存在名为 "Id" 的列，忽略异常并使用索引回退
                }

                cell ??= (row.Cells.Count > 0 ? row.Cells[0] : null);//??=如果左边为null，则将右边的值赋给左边

                if (cell == null || !int.TryParse(cell.Value?.ToString(), out id))//?. 运算符：左边null,全null,否则执行右边

                {
                    MessageBox.Show("无法读取有效的编号，请检查所选行。");
                    return;
                }
            }

            if (MessageBox.Show($"确定删除编号 {id}？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (manager.DeleteSalary(id))
                {
                    MessageBox.Show("删除成功！");
                    ClearForm();
                    btnRefresh_Click(null, null);
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var result = manager.Search(txtSearch.Text);
            dataGridView1.DataSource = result;
            UpdateStats();
        }

        private void btnSort_Click_1(object sender, EventArgs e)
        {
            bool ascending = cmbSortOrder.SelectedIndex == 0;
            var result = cmbSortField.SelectedIndex == 0
                ? manager.SortByCardNumber(ascending)
                : manager.SortBySalary(ascending);
            dataGridView1.DataSource = result;
            UpdateStats();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            var idText = row.Cells.Count > 0 ? row.Cells[0].Value?.ToString() : string.Empty;
            if (txtld != null) txtld.Text = idText;
            if (txtId != null) txtId.Text = idText; // 兼容旧引用

            // 记录原始编号，供修改时判断是否变更
            selectedOriginalId = int.TryParse(idText, out var parsedId) ? parsedId : (int?)null;

            txtName.Text = row.Cells.Count > 1 ? row.Cells[1].Value?.ToString() : string.Empty;
            txtCard.Text = row.Cells.Count > 2 ? row.Cells[2].Value?.ToString() : string.Empty;
            txtGross.Text = row.Cells.Count > 3 ? row.Cells[3].Value?.ToString() : string.Empty;
            txtUtilities.Text = row.Cells.Count > 4 ? row.Cells[4].Value?.ToString() : string.Empty;
            txtTax.Text = row.Cells.Count > 5 ? row.Cells[5].Value?.ToString() : string.Empty;
            txtNet.Text = row.Cells.Count > 6 ? row.Cells[6].Value?.ToString() : string.Empty;
        }
    }
}
