namespace 登陆
{
    partial class duzhechaxun
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rno = new System.Windows.Forms.TextBox();
            this.Rname = new System.Windows.Forms.TextBox();
            this.Rage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Rsex = new System.Windows.Forms.ComboBox();
            this.Rdep = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(12, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(572, 167);
            this.dataGrid1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(244, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "读者编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(244, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "读者姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "所在系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "性别";
            // 
            // Rno
            // 
            this.Rno.Location = new System.Drawing.Point(332, 233);
            this.Rno.Name = "Rno";
            this.Rno.Size = new System.Drawing.Size(91, 21);
            this.Rno.TabIndex = 6;
            // 
            // Rname
            // 
            this.Rname.Location = new System.Drawing.Point(332, 290);
            this.Rname.Name = "Rname";
            this.Rname.Size = new System.Drawing.Size(91, 21);
            this.Rname.TabIndex = 7;
            this.Rname.TextChanged += new System.EventHandler(this.Rname_TextChanged);
            // 
            // Rage
            // 
            this.Rage.Location = new System.Drawing.Point(77, 227);
            this.Rage.Name = "Rage";
            this.Rage.Size = new System.Drawing.Size(91, 21);
            this.Rage.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(11, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "按照不同类型查询:";
            // 
            // Rsex
            // 
            this.Rsex.FormattingEnabled = true;
            this.Rsex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.Rsex.Location = new System.Drawing.Point(77, 280);
            this.Rsex.Name = "Rsex";
            this.Rsex.Size = new System.Drawing.Size(91, 20);
            this.Rsex.TabIndex = 10;
            // 
            // Rdep
            // 
            this.Rdep.FormattingEnabled = true;
            this.Rdep.Items.AddRange(new object[] {
            "计算机信息与科学技术学院",
            "计算机信息管理学院",
            "软件学院",
            "软件技术学院"});
            this.Rdep.Location = new System.Drawing.Point(77, 329);
            this.Rdep.Name = "Rdep";
            this.Rdep.Size = new System.Drawing.Size(91, 20);
            this.Rdep.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "全部";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(445, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // duzhechaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 493);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rdep);
            this.Controls.Add(this.Rsex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rage);
            this.Controls.Add(this.Rname);
            this.Controls.Add(this.Rno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid1);
            this.Name = "duzhechaxun";
            this.Text = "读者信息查询";
            this.Load += new System.EventHandler(this.duzhechaxun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rno;
        private System.Windows.Forms.TextBox Rname;
        private System.Windows.Forms.TextBox Rage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Rsex;
        private System.Windows.Forms.ComboBox Rdep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}