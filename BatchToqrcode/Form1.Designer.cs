namespace BatchToqrcode
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
            this.label1 = new System.Windows.Forms.Label();
            this.tburls = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbbgno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbendno = new System.Windows.Forms.TextBox();
            this.btrun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btrestart = new System.Windows.Forms.Button();
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.btpwd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网    址：";
            // 
            // tburls
            // 
            this.tburls.Location = new System.Drawing.Point(108, 44);
            this.tburls.Name = "tburls";
            this.tburls.ReadOnly = true;
            this.tburls.Size = new System.Drawing.Size(134, 21);
            this.tburls.TabIndex = 1;
            this.tburls.Text = "http://jump.6glz.com";
            this.tburls.Click += new System.EventHandler(this.tburls_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始编号：";
            // 
            // tbbgno
            // 
            this.tbbgno.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbbgno.Location = new System.Drawing.Point(108, 76);
            this.tbbgno.Name = "tbbgno";
            this.tbbgno.Size = new System.Drawing.Size(87, 21);
            this.tbbgno.TabIndex = 3;
            this.tbbgno.Text = "51210001";
            this.tbbgno.Leave += new System.EventHandler(this.tbbgno_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "结束编号：";
            // 
            // tbendno
            // 
            this.tbendno.Location = new System.Drawing.Point(108, 132);
            this.tbendno.Name = "tbendno";
            this.tbendno.ReadOnly = true;
            this.tbendno.Size = new System.Drawing.Size(134, 21);
            this.tbendno.TabIndex = 5;
            this.tbendno.Text = "51210010";
            // 
            // btrun
            // 
            this.btrun.Location = new System.Drawing.Point(36, 200);
            this.btrun.Name = "btrun";
            this.btrun.Size = new System.Drawing.Size(206, 23);
            this.btrun.TabIndex = 6;
            this.btrun.Text = "批量生成";
            this.btrun.UseVisualStyleBackColor = true;
            this.btrun.Click += new System.EventHandler(this.btrun_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "默认图片生成在程序同目录下，297PX，PNG格式";
            // 
            // tbno
            // 
            this.tbno.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbno.Location = new System.Drawing.Point(108, 105);
            this.tbno.Name = "tbno";
            this.tbno.Size = new System.Drawing.Size(134, 21);
            this.tbno.TabIndex = 9;
            this.tbno.Text = "10";
            this.tbno.Leave += new System.EventHandler(this.tbno_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数    量：";
            // 
            // btrestart
            // 
            this.btrestart.Location = new System.Drawing.Point(202, 76);
            this.btrestart.Name = "btrestart";
            this.btrestart.Size = new System.Drawing.Size(40, 23);
            this.btrestart.TabIndex = 10;
            this.btrestart.Text = "恢复";
            this.btrestart.UseVisualStyleBackColor = true;
            this.btrestart.Click += new System.EventHandler(this.btrestart_Click);
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(108, 15);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(87, 21);
            this.tbpwd.TabIndex = 11;
            this.tbpwd.Text = "输入解锁密码";
            this.tbpwd.Click += new System.EventHandler(this.tbpwd_Click);
            // 
            // btpwd
            // 
            this.btpwd.Location = new System.Drawing.Point(201, 15);
            this.btpwd.Name = "btpwd";
            this.btpwd.Size = new System.Drawing.Size(40, 23);
            this.btpwd.TabIndex = 12;
            this.btpwd.Text = "恢复";
            this.btpwd.UseVisualStyleBackColor = true;
            this.btpwd.Click += new System.EventHandler(this.btpwd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "@CopyRignt Wfp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btpwd);
            this.Controls.Add(this.tbpwd);
            this.Controls.Add(this.btrestart);
            this.Controls.Add(this.tbno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btrun);
            this.Controls.Add(this.tbendno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbbgno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tburls);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量生成二维码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tburls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbbgno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbendno;
        private System.Windows.Forms.Button btrun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btrestart;
        private System.Windows.Forms.TextBox tbpwd;
        private System.Windows.Forms.Button btpwd;
        private System.Windows.Forms.Label label6;
    }
}

