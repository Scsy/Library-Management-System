namespace 登陆
{
    partial class duzhexinxi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rno = new System.Windows.Forms.TextBox();
            this.Rname = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Rsex = new System.Windows.Forms.ComboBox();
            this.Rdep = new System.Windows.Forms.ComboBox();
            this.Rage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(208, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(404, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "所在系";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(208, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "年龄";
            // 
            // Rno
            // 
            this.Rno.Location = new System.Drawing.Point(74, 23);
            this.Rno.Name = "Rno";
            this.Rno.Size = new System.Drawing.Size(100, 21);
            this.Rno.TabIndex = 5;
            // 
            // Rname
            // 
            this.Rname.Location = new System.Drawing.Point(254, 22);
            this.Rname.Name = "Rname";
            this.Rname.Size = new System.Drawing.Size(104, 21);
            this.Rname.TabIndex = 6;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(12, 188);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(570, 226);
            this.dataGrid1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "重置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rsex
            // 
            this.Rsex.FormattingEnabled = true;
            this.Rsex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.Rsex.Location = new System.Drawing.Point(450, 22);
            this.Rsex.Name = "Rsex";
            this.Rsex.Size = new System.Drawing.Size(102, 20);
            this.Rsex.TabIndex = 14;
            // 
            // Rdep
            // 
            this.Rdep.FormattingEnabled = true;
            this.Rdep.Items.AddRange(new object[] {
            "计算机信息与科学技术学院",
            "计算机信息管理学院",
            "软件学院",
            "软件技术学院"});
            this.Rdep.Location = new System.Drawing.Point(72, 91);
            this.Rdep.Name = "Rdep";
            this.Rdep.Size = new System.Drawing.Size(102, 20);
            this.Rdep.TabIndex = 15;
            // 
            // Rage
            // 
            this.Rage.FormattingEnabled = true;
            this.Rage.Items.AddRange(new object[] {
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.Rage.Location = new System.Drawing.Point(254, 87);
            this.Rage.Name = "Rage";
            this.Rage.Size = new System.Drawing.Size(104, 20);
            this.Rage.TabIndex = 16;
            // 
            // duzhexinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 426);
            this.Controls.Add(this.Rage);
            this.Controls.Add(this.Rdep);
            this.Controls.Add(this.Rsex);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.Rname);
            this.Controls.Add(this.Rno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "duzhexinxi";
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.duzhexinxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rno;
        private System.Windows.Forms.TextBox Rname;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Rsex;
        private System.Windows.Forms.ComboBox Rdep;
        private System.Windows.Forms.ComboBox Rage;
    }
}