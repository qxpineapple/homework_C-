namespace OrderWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelOfFunction = new System.Windows.Forms.Panel();
            this.FoundVIP = new System.Windows.Forms.Button();
            this.panelOfFound = new System.Windows.Forms.Panel();
            this.FoundByID = new System.Windows.Forms.RadioButton();
            this.FoundByName = new System.Windows.Forms.RadioButton();
            this.Found = new System.Windows.Forms.Button();
            this.FoundtextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.renew = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Infomation = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtmlOut = new System.Windows.Forms.Button();
            this.panelOfFunction.SuspendLayout();
            this.panelOfFound.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOfFunction
            // 
            this.panelOfFunction.Controls.Add(this.FoundVIP);
            this.panelOfFunction.Controls.Add(this.panelOfFound);
            this.panelOfFunction.Controls.Add(this.Found);
            this.panelOfFunction.Controls.Add(this.FoundtextBox);
            this.panelOfFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOfFunction.Location = new System.Drawing.Point(0, 0);
            this.panelOfFunction.Name = "panelOfFunction";
            this.panelOfFunction.Size = new System.Drawing.Size(791, 67);
            this.panelOfFunction.TabIndex = 0;
           
            // 
            // FoundVIP
            // 
            this.FoundVIP.Location = new System.Drawing.Point(303, 22);
            this.FoundVIP.Name = "FoundVIP";
            this.FoundVIP.Size = new System.Drawing.Size(75, 23);
            this.FoundVIP.TabIndex = 4;
            this.FoundVIP.Text = "查找VIP";
            this.FoundVIP.UseVisualStyleBackColor = true;
            this.FoundVIP.Click += new System.EventHandler(this.FoundVIP_Click);
            // 
            // panelOfFound
            // 
            this.panelOfFound.Controls.Add(this.FoundByID);
            this.panelOfFound.Controls.Add(this.FoundByName);
            this.panelOfFound.Location = new System.Drawing.Point(105, 3);
            this.panelOfFound.Name = "panelOfFound";
            this.panelOfFound.Size = new System.Drawing.Size(64, 58);
            this.panelOfFound.TabIndex = 3;
           
            // 
            // FoundByID
            // 
            this.FoundByID.AutoSize = true;
            this.FoundByID.Location = new System.Drawing.Point(3, 31);
            this.FoundByID.Name = "FoundByID";
            this.FoundByID.Size = new System.Drawing.Size(47, 16);
            this.FoundByID.TabIndex = 1;
            this.FoundByID.TabStop = true;
            this.FoundByID.Text = "按ID";
            this.FoundByID.UseVisualStyleBackColor = true;
           
            // 
            // FoundByName
            // 
            this.FoundByName.AutoSize = true;
            this.FoundByName.Location = new System.Drawing.Point(3, 9);
            this.FoundByName.Name = "FoundByName";
            this.FoundByName.Size = new System.Drawing.Size(59, 16);
            this.FoundByName.TabIndex = 0;
            this.FoundByName.TabStop = true;
            this.FoundByName.Text = "按名字";
            this.FoundByName.UseVisualStyleBackColor = true;
         
            // 
            // Found
            // 
            this.Found.Location = new System.Drawing.Point(24, 24);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(75, 23);
            this.Found.TabIndex = 1;
            this.Found.Text = "查找";
            this.Found.UseVisualStyleBackColor = true;
            this.Found.Click += new System.EventHandler(this.Founding_Click);
            // 
            // FoundtextBox
            // 
            this.FoundtextBox.Location = new System.Drawing.Point(175, 24);
            this.FoundtextBox.Name = "FoundtextBox";
            this.FoundtextBox.Size = new System.Drawing.Size(100, 21);
            this.FoundtextBox.TabIndex = 0;
        
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtmlOut);
            this.panel1.Controls.Add(this.renew);
            this.panel1.Controls.Add(this.Insert);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Infomation);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 100);
            this.panel1.TabIndex = 2;
            
            // 
            // renew
            // 
            this.renew.Location = new System.Drawing.Point(211, 47);
            this.renew.Name = "renew";
            this.renew.Size = new System.Drawing.Size(75, 23);
            this.renew.TabIndex = 5;
            this.renew.Text = "刷新";
            this.renew.UseVisualStyleBackColor = true;
            this.renew.Click += new System.EventHandler(this.renew_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(105, 47);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "新增";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "订单号:";
            // 
            // Infomation
            // 
            this.Infomation.AutoSize = true;
            this.Infomation.Location = new System.Drawing.Point(56, 12);
            this.Infomation.Name = "Infomation";
            this.Infomation.Size = new System.Drawing.Size(23, 12);
            this.Infomation.TabIndex = 2;
            this.Infomation.Text = "( )";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(4, 47);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 268);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Id,
            this.customerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(785, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Id";
            this.Time.Name = "Time";
            this.Time.Width = 150;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(OrderWinForm.OrderDetails);
            // 
            // xtmlOut
            // 
            this.xtmlOut.Location = new System.Drawing.Point(318, 47);
            this.xtmlOut.Name = "xtmlOut";
            this.xtmlOut.Size = new System.Drawing.Size(75, 23);
            this.xtmlOut.TabIndex = 6;
            this.xtmlOut.Text = "导出";
            this.xtmlOut.UseVisualStyleBackColor = true;
            this.xtmlOut.Click += new System.EventHandler(this.htmlOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOfFunction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelOfFunction.ResumeLayout(false);
            this.panelOfFunction.PerformLayout();
            this.panelOfFound.ResumeLayout(false);
            this.panelOfFound.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOfFunction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Found;
        private System.Windows.Forms.TextBox FoundtextBox;
        private System.Windows.Forms.Panel panelOfFound;
        private System.Windows.Forms.RadioButton FoundByID;
        private System.Windows.Forms.RadioButton FoundByName;
        private System.Windows.Forms.Button FoundVIP;
        private System.Windows.Forms.Label Infomation;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button renew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button xtmlOut;
    }
}

