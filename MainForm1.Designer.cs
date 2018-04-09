namespace 登陆
{
    partial class MainForm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.已有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.已有ToolStripMenuItem,
            this.学生信息ToolStripMenuItem,
            this.借阅信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 已有ToolStripMenuItem
            // 
            this.已有ToolStripMenuItem.Name = "已有ToolStripMenuItem";
            this.已有ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.已有ToolStripMenuItem.Text = "现存图书";
            this.已有ToolStripMenuItem.Click += new System.EventHandler(this.已有ToolStripMenuItem_Click);
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.学生信息ToolStripMenuItem.Text = "读者信息";
            this.学生信息ToolStripMenuItem.Click += new System.EventHandler(this.学生信息ToolStripMenuItem_Click);
            // 
            // 借阅信息ToolStripMenuItem
            // 
            this.借阅信息ToolStripMenuItem.Name = "借阅信息ToolStripMenuItem";
            this.借阅信息ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.借阅信息ToolStripMenuItem.Text = "借阅信息";
            this.借阅信息ToolStripMenuItem.Click += new System.EventHandler(this.借阅信息ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "由于该页面功能暂未开启不能在主窗体里\r\n显示子窗体。单击确定按钮进入登陆界面\r\n切换到管理员权限，单击取消按钮退出该\r\n系统。\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(92, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(219, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "温馨提示：";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(518, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm1";
            this.Text = "学生窗口";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 已有ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅信息ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}