namespace SalaryManagementSystem
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;
        // IContainer = 容器接口，用来管理需要释放的资源（如图片、字体）


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtCard = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtld = new TextBox();
            txtGross = new TextBox();
            label5 = new Label();
            txtUtilities = new TextBox();
            label6 = new Label();
            txtTax = new TextBox();
            label7 = new Label();
            txtNet = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            btnCalc = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            groupBox2 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label8 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label9 = new Label();
            cmbSortField = new ComboBox();
            cmbSortOrder = new ComboBox();
            btnSort = new Button();
            btnRefresh = new Button();
            panel1 = new Panel();
            lblStats = new Label();
            dataGridView1 = new DataGridView();
            colld = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCard = new DataGridViewTextBoxColumn();
            colGross = new DataGridViewTextBoxColumn();
            colUtilities = new DataGridViewTextBoxColumn();
            colTax = new DataGridViewTextBoxColumn();
            colNet = new DataGridViewTextBoxColumn();
            fontDialog1 = new FontDialog();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1285, 794);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1279, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "工资信息录入（带*为必填）";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtName, 3, 0);
            tableLayoutPanel2.Controls.Add(label3, 4, 0);
            tableLayoutPanel2.Controls.Add(txtCard, 5, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(txtld, 1, 0);
            tableLayoutPanel2.Controls.Add(txtGross, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 2, 1);
            tableLayoutPanel2.Controls.Add(txtUtilities, 3, 1);
            tableLayoutPanel2.Controls.Add(label6, 4, 1);
            tableLayoutPanel2.Controls.Add(txtTax, 5, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(txtNet, 1, 2);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 3, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.Size = new Size(1273, 115);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 0;
            label1.Text = "编号：";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Location = new Point(639, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 30);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(851, 0);
            label3.Name = "label3";
            label3.Size = new Size(206, 38);
            label3.TabIndex = 4;
            label3.Text = "*银行卡号：";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCard
            // 
            txtCard.Location = new Point(1063, 3);
            txtCard.Name = "txtCard";
            txtCard.Size = new Size(150, 30);
            txtCard.TabIndex = 5;
            txtCard.KeyPress += TxtCard_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 38);
            label4.Name = "label4";
            label4.Size = new Size(206, 38);
            label4.TabIndex = 6;
            label4.Text = "*应发工资：";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(427, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 38);
            label2.TabIndex = 2;
            label2.Text = "*姓名：";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtld
            // 
            txtld.BackColor = Color.LightYellow;
            txtld.Location = new Point(215, 3);
            txtld.Name = "txtld";
            txtld.Size = new Size(150, 30);
            txtld.TabIndex = 1;
            // 
            // txtGross
            // 
            txtGross.Location = new Point(215, 41);
            txtGross.Name = "txtGross";
            txtGross.Size = new Size(150, 30);
            txtGross.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(427, 38);
            label5.Name = "label5";
            label5.Size = new Size(206, 38);
            label5.TabIndex = 8;
            label5.Text = "水电费:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUtilities
            // 
            txtUtilities.Location = new Point(639, 41);
            txtUtilities.Name = "txtUtilities";
            txtUtilities.Size = new Size(150, 30);
            txtUtilities.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(851, 38);
            label6.Name = "label6";
            label6.Size = new Size(206, 38);
            label6.TabIndex = 10;
            label6.Text = "税金:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(1063, 41);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(150, 30);
            txtTax.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 76);
            label7.Name = "label7";
            label7.Size = new Size(206, 39);
            label7.TabIndex = 12;
            label7.Text = "实发工资:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNet
            // 
            txtNet.BackColor = Color.LightGreen;
            txtNet.Location = new Point(215, 79);
            txtNet.Name = "txtNet";
            txtNet.ReadOnly = true;
            txtNet.Size = new Size(150, 30);
            txtNet.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel2.SetColumnSpan(flowLayoutPanel1, 3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(btnCalc);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnUpdate);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnClear);
            flowLayoutPanel1.Location = new Point(636, 76);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(637, 39);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.SteelBlue;
            btnCalc.FlatStyle = FlatStyle.Popup;
            btnCalc.ForeColor = Color.White;
            btnCalc.Location = new Point(17, 3);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(100, 39);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "计算工资";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(123, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(229, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 39);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "修改";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(335, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 39);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(441, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 39);
            btnClear.TabIndex = 6;
            btnClear.Text = "清空";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(3, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1279, 64);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "查询与排序";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label8);
            flowLayoutPanel2.Controls.Add(txtSearch);
            flowLayoutPanel2.Controls.Add(btnSearch);
            flowLayoutPanel2.Controls.Add(label9);
            flowLayoutPanel2.Controls.Add(cmbSortField);
            flowLayoutPanel2.Controls.Add(cmbSortOrder);
            flowLayoutPanel2.Controls.Add(btnSort);
            flowLayoutPanel2.Controls.Add(btnRefresh);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 26);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(1273, 35);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 5);
            label8.Name = "label8";
            label8.Size = new Size(166, 25);
            label8.TabIndex = 0;
            label8.Text = "关键字(姓名/卡号):";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(180, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 30);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(336, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "模糊查询";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(454, 5);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 3;
            label9.Text = "排序： ";
            // 
            // cmbSortField
            // 
            cmbSortField.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortField.FormattingEnabled = true;
            cmbSortField.Items.AddRange(new object[] { "银行卡号", "实发工资" });
            cmbSortField.Location = new Point(531, 8);
            cmbSortField.Name = "cmbSortField";
            cmbSortField.Size = new Size(100, 33);
            cmbSortField.TabIndex = 4;
            // 
            // cmbSortOrder
            // 
            cmbSortOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortOrder.FormattingEnabled = true;
            cmbSortOrder.Items.AddRange(new object[] { "升序", "降序" });
            cmbSortOrder.Location = new Point(637, 8);
            cmbSortOrder.Name = "cmbSortOrder";
            cmbSortOrder.Size = new Size(80, 33);
            cmbSortOrder.TabIndex = 5;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.Teal;
            btnSort.ForeColor = Color.White;
            btnSort.Location = new Point(723, 8);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 6;
            btnSort.Text = "排序";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DimGray;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(841, 8);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "显示全部";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightYellow;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblStats);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 24);
            panel1.TabIndex = 2;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Dock = DockStyle.Fill;
            lblStats.ForeColor = Color.DarkBlue;
            lblStats.Location = new Point(0, 0);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(293, 24);
            lblStats.TabIndex = 0;
            lblStats.Text = "共0人|实发合计:0.00元|平均:0.00元";
            lblStats.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colld, colName, colCard, colGross, colUtilities, colTax, colNet });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1279, 538);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colld
            // 
            colld.DataPropertyName = "编号";
            colld.FillWeight = 63.63636F;
            colld.HeaderText = "编号";
            colld.MinimumWidth = 8;
            colld.Name = "colld";
            colld.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "姓名";
            colName.FillWeight = 63.63636F;
            colName.HeaderText = "姓名";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCard
            // 
            colCard.DataPropertyName = "银行卡号";
            colCard.FillWeight = 63.63636F;
            colCard.HeaderText = "银行卡号";
            colCard.MinimumWidth = 8;
            colCard.Name = "colCard";
            colCard.ReadOnly = true;
            // 
            // colGross
            // 
            colGross.DataPropertyName = "应发工资";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            colGross.DefaultCellStyle = dataGridViewCellStyle3;
            colGross.FillWeight = 63.63636F;
            colGross.HeaderText = "应发工资";
            colGross.MinimumWidth = 8;
            colGross.Name = "colGross";
            colGross.ReadOnly = true;
            // 
            // colUtilities
            // 
            colUtilities.DataPropertyName = "水电费";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            colUtilities.DefaultCellStyle = dataGridViewCellStyle4;
            colUtilities.FillWeight = 63.63636F;
            colUtilities.HeaderText = "水电费";
            colUtilities.MinimumWidth = 8;
            colUtilities.Name = "colUtilities";
            colUtilities.ReadOnly = true;
            // 
            // colTax
            // 
            colTax.DataPropertyName = "税金";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            colTax.DefaultCellStyle = dataGridViewCellStyle5;
            colTax.FillWeight = 63.63636F;
            colTax.HeaderText = "税金";
            colTax.MinimumWidth = 8;
            colTax.Name = "colTax";
            colTax.ReadOnly = true;
            // 
            // colNet
            // 
            colNet.DataPropertyName = "实发工资";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("宋体", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            dataGridViewCellStyle6.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            colNet.DefaultCellStyle = dataGridViewCellStyle6;
            colNet.FillWeight = 63.63636F;
            colNet.HeaderText = "实发工资";
            colNet.MinimumWidth = 8;
            colNet.Name = "colNet";
            colNet.ReadOnly = true;
            // 
            // Form1
            // 
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1285, 794);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "工资信息管理系统";
            Load += Form1_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }


        #endregion
    }
}