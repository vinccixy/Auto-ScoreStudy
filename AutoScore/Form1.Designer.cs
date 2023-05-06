namespace AutoScore
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.labA = new System.Windows.Forms.Label();
            this.labOp = new System.Windows.Forms.Label();
            this.labB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnJudge = new System.Windows.Forms.Button();
            this.lstDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(468, 67);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(137, 21);
            this.txtResult.TabIndex = 0;
            // 
            // labA
            // 
            this.labA.AutoSize = true;
            this.labA.Location = new System.Drawing.Point(208, 70);
            this.labA.Name = "labA";
            this.labA.Size = new System.Drawing.Size(0, 12);
            this.labA.TabIndex = 1;
            // 
            // labOp
            // 
            this.labOp.AutoSize = true;
            this.labOp.Location = new System.Drawing.Point(283, 70);
            this.labOp.Name = "labOp";
            this.labOp.Size = new System.Drawing.Size(0, 12);
            this.labOp.TabIndex = 2;
            // 
            // labB
            // 
            this.labB.AutoSize = true;
            this.labB.Location = new System.Drawing.Point(365, 70);
            this.labB.Name = "labB";
            this.labB.Size = new System.Drawing.Size(0, 12);
            this.labB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(210, 121);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 31);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "出题";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(502, 121);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(103, 31);
            this.btnJudge.TabIndex = 6;
            this.btnJudge.Text = "判分";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // lstDisp
            // 
            this.lstDisp.FormattingEnabled = true;
            this.lstDisp.ItemHeight = 12;
            this.lstDisp.Location = new System.Drawing.Point(210, 176);
            this.lstDisp.Name = "lstDisp";
            this.lstDisp.Size = new System.Drawing.Size(395, 136);
            this.lstDisp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 368);
            this.Controls.Add(this.lstDisp);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labB);
            this.Controls.Add(this.labOp);
            this.Controls.Add(this.labA);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label labA;
        private System.Windows.Forms.Label labOp;
        private System.Windows.Forms.Label labB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.ListBox lstDisp;
    }
}

