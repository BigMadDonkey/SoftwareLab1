namespace Within100MathQuiz
{
    partial class Quiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.LabelTimerDescribe = new System.Windows.Forms.Label();
            this.LabelLeftNum1 = new System.Windows.Forms.Label();
            this.LabelRightNum1 = new System.Windows.Forms.Label();
            this.LabelOp1 = new System.Windows.Forms.Label();
            this.LabelEqualSign_1 = new System.Windows.Forms.Label();
            this.LabelEqualSign_2 = new System.Windows.Forms.Label();
            this.LabelOp2 = new System.Windows.Forms.Label();
            this.LabelRightNum2 = new System.Windows.Forms.Label();
            this.LabelLeftNum2 = new System.Windows.Forms.Label();
            this.LabelEqualSign_3 = new System.Windows.Forms.Label();
            this.LabelOp3 = new System.Windows.Forms.Label();
            this.LabelRightNum3 = new System.Windows.Forms.Label();
            this.LabelLeftNum3 = new System.Windows.Forms.Label();
            this.LabelLeftNum4 = new System.Windows.Forms.Label();
            this.LabelRightNum4 = new System.Windows.Forms.Label();
            this.LabelOp4 = new System.Windows.Forms.Label();
            this.LabelEqualSign_4 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ans1 = new System.Windows.Forms.RichTextBox();
            this.Ans2 = new System.Windows.Forms.RichTextBox();
            this.Ans3 = new System.Windows.Forms.RichTextBox();
            this.Ans4 = new System.Windows.Forms.RichTextBox();
            this.button_pagedown = new System.Windows.Forms.Button();
            this.button_pageup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(232, 27);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "小火汁，你能算出来吗？";
            // 
            // LabelTimer
            // 
            this.LabelTimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTimer.Location = new System.Drawing.Point(376, 9);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(101, 30);
            this.LabelTimer.TabIndex = 1;
            this.LabelTimer.Text = "TimeLeft";
            // 
            // LabelTimerDescribe
            // 
            this.LabelTimerDescribe.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTimerDescribe.Location = new System.Drawing.Point(264, 9);
            this.LabelTimerDescribe.Name = "LabelTimerDescribe";
            this.LabelTimerDescribe.Size = new System.Drawing.Size(106, 30);
            this.LabelTimerDescribe.TabIndex = 2;
            this.LabelTimerDescribe.Text = "你还剩下:";
            // 
            // LabelLeftNum1
            // 
            this.LabelLeftNum1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LabelLeftNum1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftNum1.Location = new System.Drawing.Point(20, 78);
            this.LabelLeftNum1.Name = "LabelLeftNum1";
            this.LabelLeftNum1.Size = new System.Drawing.Size(80, 29);
            this.LabelLeftNum1.TabIndex = 3;
            this.LabelLeftNum1.Text = "?";
            this.LabelLeftNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelLeftNum1.UseCompatibleTextRendering = true;
            // 
            // LabelRightNum1
            // 
            this.LabelRightNum1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightNum1.Location = new System.Drawing.Point(158, 78);
            this.LabelRightNum1.Name = "LabelRightNum1";
            this.LabelRightNum1.Size = new System.Drawing.Size(80, 29);
            this.LabelRightNum1.TabIndex = 3;
            this.LabelRightNum1.Text = "?";
            this.LabelRightNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelOp1
            // 
            this.LabelOp1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelOp1.Location = new System.Drawing.Point(100, 78);
            this.LabelOp1.Name = "LabelOp1";
            this.LabelOp1.Size = new System.Drawing.Size(52, 29);
            this.LabelOp1.TabIndex = 3;
            this.LabelOp1.Text = "+";
            this.LabelOp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_1
            // 
            this.LabelEqualSign_1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_1.Location = new System.Drawing.Point(238, 78);
            this.LabelEqualSign_1.Name = "LabelEqualSign_1";
            this.LabelEqualSign_1.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_1.TabIndex = 3;
            this.LabelEqualSign_1.Text = "=";
            this.LabelEqualSign_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_2
            // 
            this.LabelEqualSign_2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_2.Location = new System.Drawing.Point(238, 147);
            this.LabelEqualSign_2.Name = "LabelEqualSign_2";
            this.LabelEqualSign_2.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_2.TabIndex = 3;
            this.LabelEqualSign_2.Text = "=";
            this.LabelEqualSign_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelOp2
            // 
            this.LabelOp2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelOp2.Location = new System.Drawing.Point(99, 147);
            this.LabelOp2.Name = "LabelOp2";
            this.LabelOp2.Size = new System.Drawing.Size(52, 29);
            this.LabelOp2.TabIndex = 3;
            this.LabelOp2.Text = "-";
            this.LabelOp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRightNum2
            // 
            this.LabelRightNum2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightNum2.Location = new System.Drawing.Point(158, 147);
            this.LabelRightNum2.Name = "LabelRightNum2";
            this.LabelRightNum2.Size = new System.Drawing.Size(80, 29);
            this.LabelRightNum2.TabIndex = 3;
            this.LabelRightNum2.Text = "?";
            this.LabelRightNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLeftNum2
            // 
            this.LabelLeftNum2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftNum2.Location = new System.Drawing.Point(20, 147);
            this.LabelLeftNum2.Name = "LabelLeftNum2";
            this.LabelLeftNum2.Size = new System.Drawing.Size(80, 29);
            this.LabelLeftNum2.TabIndex = 3;
            this.LabelLeftNum2.Text = "?";
            this.LabelLeftNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_3
            // 
            this.LabelEqualSign_3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_3.Location = new System.Drawing.Point(238, 215);
            this.LabelEqualSign_3.Name = "LabelEqualSign_3";
            this.LabelEqualSign_3.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_3.TabIndex = 3;
            this.LabelEqualSign_3.Text = "=";
            this.LabelEqualSign_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelOp3
            // 
            this.LabelOp3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelOp3.Location = new System.Drawing.Point(99, 215);
            this.LabelOp3.Name = "LabelOp3";
            this.LabelOp3.Size = new System.Drawing.Size(52, 29);
            this.LabelOp3.TabIndex = 3;
            this.LabelOp3.Text = "*";
            this.LabelOp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRightNum3
            // 
            this.LabelRightNum3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightNum3.Location = new System.Drawing.Point(158, 215);
            this.LabelRightNum3.Name = "LabelRightNum3";
            this.LabelRightNum3.Size = new System.Drawing.Size(80, 29);
            this.LabelRightNum3.TabIndex = 3;
            this.LabelRightNum3.Text = "?";
            this.LabelRightNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLeftNum3
            // 
            this.LabelLeftNum3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftNum3.Location = new System.Drawing.Point(20, 215);
            this.LabelLeftNum3.Name = "LabelLeftNum3";
            this.LabelLeftNum3.Size = new System.Drawing.Size(80, 29);
            this.LabelLeftNum3.TabIndex = 3;
            this.LabelLeftNum3.Text = "?";
            this.LabelLeftNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLeftNum4
            // 
            this.LabelLeftNum4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftNum4.Location = new System.Drawing.Point(20, 280);
            this.LabelLeftNum4.Name = "LabelLeftNum4";
            this.LabelLeftNum4.Size = new System.Drawing.Size(80, 29);
            this.LabelLeftNum4.TabIndex = 3;
            this.LabelLeftNum4.Text = "?";
            this.LabelLeftNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRightNum4
            // 
            this.LabelRightNum4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightNum4.Location = new System.Drawing.Point(158, 280);
            this.LabelRightNum4.Name = "LabelRightNum4";
            this.LabelRightNum4.Size = new System.Drawing.Size(80, 29);
            this.LabelRightNum4.TabIndex = 3;
            this.LabelRightNum4.Text = "?";
            this.LabelRightNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelOp4
            // 
            this.LabelOp4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelOp4.Location = new System.Drawing.Point(99, 280);
            this.LabelOp4.Name = "LabelOp4";
            this.LabelOp4.Size = new System.Drawing.Size(52, 29);
            this.LabelOp4.TabIndex = 3;
            this.LabelOp4.Text = "/";
            this.LabelOp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_4
            // 
            this.LabelEqualSign_4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_4.Location = new System.Drawing.Point(238, 280);
            this.LabelEqualSign_4.Name = "LabelEqualSign_4";
            this.LabelEqualSign_4.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_4.TabIndex = 3;
            this.LabelEqualSign_4.Text = "=";
            this.LabelEqualSign_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonStart.Location = new System.Drawing.Point(433, 252);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(121, 65);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "开始测验？";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ans1
            // 
            this.Ans1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ans1.Location = new System.Drawing.Point(296, 75);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(80, 46);
            this.Ans1.TabIndex = 6;
            this.Ans1.Text = "";
            // 
            // Ans2
            // 
            this.Ans2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ans2.Location = new System.Drawing.Point(296, 144);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(80, 46);
            this.Ans2.TabIndex = 6;
            this.Ans2.Text = "";
            // 
            // Ans3
            // 
            this.Ans3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ans3.Location = new System.Drawing.Point(296, 212);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(80, 46);
            this.Ans3.TabIndex = 6;
            this.Ans3.Text = "";
            // 
            // Ans4
            // 
            this.Ans4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ans4.Location = new System.Drawing.Point(296, 277);
            this.Ans4.Name = "Ans4";
            this.Ans4.Size = new System.Drawing.Size(80, 46);
            this.Ans4.TabIndex = 6;
            this.Ans4.Text = "";
            // 
            // button_pagedown
            // 
            this.button_pagedown.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_pagedown.Location = new System.Drawing.Point(475, 191);
            this.button_pagedown.Name = "button_pagedown";
            this.button_pagedown.Size = new System.Drawing.Size(79, 42);
            this.button_pagedown.TabIndex = 1;
            this.button_pagedown.Text = "下一页";
            this.button_pagedown.UseVisualStyleBackColor = true;
            this.button_pagedown.Click += new System.EventHandler(this.ButtonPageDown_Click);
            // 
            // button_pageup
            // 
            this.button_pageup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_pageup.Location = new System.Drawing.Point(475, 134);
            this.button_pageup.Name = "button_pageup";
            this.button_pageup.Size = new System.Drawing.Size(79, 42);
            this.button_pageup.TabIndex = 1;
            this.button_pageup.Text = "上一页";
            this.button_pageup.UseVisualStyleBackColor = true;
            this.button_pageup.Click += new System.EventHandler(this.ButtonPageUp_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(579, 368);
            this.Controls.Add(this.button_pageup);
            this.Controls.Add(this.button_pagedown);
            this.Controls.Add(this.Ans4);
            this.Controls.Add(this.Ans3);
            this.Controls.Add(this.Ans2);
            this.Controls.Add(this.Ans1);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelEqualSign_4);
            this.Controls.Add(this.LabelOp4);
            this.Controls.Add(this.LabelRightNum4);
            this.Controls.Add(this.LabelLeftNum4);
            this.Controls.Add(this.LabelLeftNum3);
            this.Controls.Add(this.LabelRightNum3);
            this.Controls.Add(this.LabelOp3);
            this.Controls.Add(this.LabelEqualSign_3);
            this.Controls.Add(this.LabelLeftNum2);
            this.Controls.Add(this.LabelRightNum2);
            this.Controls.Add(this.LabelOp2);
            this.Controls.Add(this.LabelEqualSign_2);
            this.Controls.Add(this.LabelEqualSign_1);
            this.Controls.Add(this.LabelOp1);
            this.Controls.Add(this.LabelRightNum1);
            this.Controls.Add(this.LabelLeftNum1);
            this.Controls.Add(this.LabelTimerDescribe);
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Quiz";
            this.Text = "加减法测验";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Label LabelTimerDescribe;
        private System.Windows.Forms.Label LabelLeftNum1;
        private System.Windows.Forms.Label LabelRightNum1;
        private System.Windows.Forms.Label LabelOp1;
        private System.Windows.Forms.Label LabelEqualSign_1;
        private System.Windows.Forms.Label LabelEqualSign_2;
        private System.Windows.Forms.Label LabelOp2;
        private System.Windows.Forms.Label LabelRightNum2;
        private System.Windows.Forms.Label LabelLeftNum2;
        private System.Windows.Forms.Label LabelEqualSign_3;
        private System.Windows.Forms.Label LabelOp3;
        private System.Windows.Forms.Label LabelRightNum3;
        private System.Windows.Forms.Label LabelLeftNum3;
        private System.Windows.Forms.Label LabelLeftNum4;
        private System.Windows.Forms.Label LabelRightNum4;
        private System.Windows.Forms.Label LabelOp4;
        private System.Windows.Forms.Label LabelEqualSign_4;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox Ans1;
        private System.Windows.Forms.RichTextBox Ans2;
        private System.Windows.Forms.RichTextBox Ans3;
        private System.Windows.Forms.RichTextBox Ans4;
        private System.Windows.Forms.Button button_pagedown;
        private System.Windows.Forms.Button button_pageup;
    }
}

