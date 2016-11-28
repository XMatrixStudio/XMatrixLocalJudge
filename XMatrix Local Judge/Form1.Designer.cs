namespace XMatrix_Local_Judge
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
            this.buttonJudge = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.listProgram = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboCom = new System.Windows.Forms.ComboBox();
            this.webProgram = new System.Windows.Forms.WebBrowser();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.Setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(897, 567);
            this.buttonJudge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(107, 31);
            this.buttonJudge.TabIndex = 0;
            this.buttonJudge.Text = "Judge";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.button1_Click);
            // 
            // textInput
            // 
            this.textInput.AcceptsReturn = true;
            this.textInput.AcceptsTab = true;
            this.textInput.AllowDrop = true;
            this.textInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textInput.Location = new System.Drawing.Point(650, 0);
            this.textInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInput.Size = new System.Drawing.Size(364, 559);
            this.textInput.TabIndex = 1;
            // 
            // listProgram
            // 
            this.listProgram.FormattingEnabled = true;
            this.listProgram.ItemHeight = 17;
            this.listProgram.Location = new System.Drawing.Point(0, 42);
            this.listProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listProgram.Name = "listProgram";
            this.listProgram.Size = new System.Drawing.Size(93, 548);
            this.listProgram.TabIndex = 2;
            this.listProgram.SelectedIndexChanged += new System.EventHandler(this.listProgram_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(0, 0);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(93, 42);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboCom
            // 
            this.comboCom.FormattingEnabled = true;
            this.comboCom.Items.AddRange(new object[] {
            "GNU GCC",
            "GNU G++"});
            this.comboCom.Location = new System.Drawing.Point(763, 570);
            this.comboCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboCom.Name = "comboCom";
            this.comboCom.Size = new System.Drawing.Size(116, 25);
            this.comboCom.TabIndex = 4;
            this.comboCom.Text = "GNU GCC";
            // 
            // webProgram
            // 
            this.webProgram.Location = new System.Drawing.Point(95, 0);
            this.webProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webProgram.MinimumSize = new System.Drawing.Size(23, 28);
            this.webProgram.Name = "webProgram";
            this.webProgram.Size = new System.Drawing.Size(549, 590);
            this.webProgram.TabIndex = 6;
            // 
            // textOutput
            // 
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput.Location = new System.Drawing.Point(1, 602);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutput.Size = new System.Drawing.Size(1013, 132);
            this.textOutput.TabIndex = 7;
            this.textOutput.Text = "None of Update       No Question\r\n";
            // 
            // Setting
            // 
            this.Setting.Location = new System.Drawing.Point(650, 568);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(107, 28);
            this.Setting.TabIndex = 8;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 733);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.webProgram);
            this.Controls.Add(this.comboCom);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listProgram);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.buttonJudge);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "XMatrix Local Judge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.ListBox listProgram;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboCom;
        private System.Windows.Forms.WebBrowser webProgram;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button Setting;
    }
}

