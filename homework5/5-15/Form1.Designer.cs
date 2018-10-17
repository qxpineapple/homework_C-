namespace _5_15
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Angel1 = new System.Windows.Forms.TextBox();
            this.Angle2 = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.TextBox();
            this.whatwidth = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.valueOfK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.TextBox();
            this.blue = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "可改变角度1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "可改变角度2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(33, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "线条颜色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(33, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "线条粗细";
            // 
            // Angel1
            // 
            this.Angel1.Location = new System.Drawing.Point(94, 58);
            this.Angel1.Name = "Angel1";
            this.Angel1.Size = new System.Drawing.Size(100, 21);
            this.Angel1.TabIndex = 5;
            this.Angel1.TextChanged += new System.EventHandler(this.Angel_TextChanged);
            // 
            // Angle2
            // 
            this.Angle2.Location = new System.Drawing.Point(94, 85);
            this.Angle2.Name = "Angle2";
            this.Angle2.Size = new System.Drawing.Size(100, 21);
            this.Angle2.TabIndex = 6;
            this.Angle2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(94, 137);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(28, 21);
            this.red.TabIndex = 7;
            this.red.TextChanged += new System.EventHandler(this.whatcolor_TextChanged);
            // 
            // whatwidth
            // 
            this.whatwidth.Location = new System.Drawing.Point(94, 164);
            this.whatwidth.Name = "whatwidth";
            this.whatwidth.Size = new System.Drawing.Size(100, 21);
            this.whatwidth.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Random";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valueOfK
            // 
            this.valueOfK.Location = new System.Drawing.Point(94, 110);
            this.valueOfK.Name = "valueOfK";
            this.valueOfK.Size = new System.Drawing.Size(100, 21);
            this.valueOfK.TabIndex = 10;
            this.valueOfK.TextChanged += new System.EventHandler(this.valueOfK_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(33, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "放大倍率";
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(128, 137);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(28, 21);
            this.green.TabIndex = 14;
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(162, 137);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(28, 21);
            this.blue.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "CleanAll";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 559);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valueOfK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.whatwidth);
            this.Controls.Add(this.red);
            this.Controls.Add(this.Angle2);
            this.Controls.Add(this.Angel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Angel1;
        private System.Windows.Forms.TextBox Angle2;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.TextBox whatwidth;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox valueOfK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.TextBox blue;
        private System.Windows.Forms.Button button3;
    }
}

