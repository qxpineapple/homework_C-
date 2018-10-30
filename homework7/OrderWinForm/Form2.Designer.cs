namespace OrderWinForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.CustomertextBox = new System.Windows.Forms.TextBox();
            this.ItemtextBox = new System.Windows.Forms.TextBox();
            this.CounttextBox = new System.Windows.Forms.TextBox();
            this.Item = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomertextBox
            // 
            this.CustomertextBox.Location = new System.Drawing.Point(12, 33);
            this.CustomertextBox.Name = "CustomertextBox";
            this.CustomertextBox.Size = new System.Drawing.Size(100, 21);
            this.CustomertextBox.TabIndex = 2;
            // 
            // ItemtextBox
            // 
            this.ItemtextBox.Location = new System.Drawing.Point(12, 67);
            this.ItemtextBox.Name = "ItemtextBox";
            this.ItemtextBox.Size = new System.Drawing.Size(100, 21);
            this.ItemtextBox.TabIndex = 3;
            // 
            // CounttextBox
            // 
            this.CounttextBox.Location = new System.Drawing.Point(12, 103);
            this.CounttextBox.Name = "CounttextBox";
            this.CounttextBox.Size = new System.Drawing.Size(100, 21);
            this.CounttextBox.TabIndex = 4;
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(118, 73);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(35, 12);
            this.Item.TabIndex = 6;
            this.Item.Text = " 商品";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(118, 107);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 12);
            this.Count.TabIndex = 7;
            this.Count.Text = " 数量";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(118, 40);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(41, 12);
            this.Customer.TabIndex = 5;
            this.Customer.Text = "用户名";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 178);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.CounttextBox);
            this.Controls.Add(this.ItemtextBox);
            this.Controls.Add(this.CustomertextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CustomertextBox;
        private System.Windows.Forms.TextBox ItemtextBox;
        private System.Windows.Forms.TextBox CounttextBox;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}