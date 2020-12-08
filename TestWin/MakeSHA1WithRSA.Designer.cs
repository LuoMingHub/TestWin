namespace TestWin
{
    partial class MakeSHA1WithRSA
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
            this.txt_WaitSignStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PrivateKey = new System.Windows.Forms.TextBox();
            this.btn_Sign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "待加密字符串:";
            // 
            // txt_WaitSignStr
            // 
            this.txt_WaitSignStr.Location = new System.Drawing.Point(13, 25);
            this.txt_WaitSignStr.Multiline = true;
            this.txt_WaitSignStr.Name = "txt_WaitSignStr";
            this.txt_WaitSignStr.Size = new System.Drawing.Size(775, 110);
            this.txt_WaitSignStr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "私钥:";
            // 
            // txt_PrivateKey
            // 
            this.txt_PrivateKey.Location = new System.Drawing.Point(53, 165);
            this.txt_PrivateKey.Multiline = true;
            this.txt_PrivateKey.Name = "txt_PrivateKey";
            this.txt_PrivateKey.Size = new System.Drawing.Size(735, 110);
            this.txt_PrivateKey.TabIndex = 1;
            // 
            // btn_Sign
            // 
            this.btn_Sign.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Sign.Location = new System.Drawing.Point(14, 293);
            this.btn_Sign.Name = "btn_Sign";
            this.btn_Sign.Size = new System.Drawing.Size(774, 34);
            this.btn_Sign.TabIndex = 2;
            this.btn_Sign.Text = "加密";
            this.btn_Sign.UseVisualStyleBackColor = false;
            this.btn_Sign.Click += new System.EventHandler(this.btn_Sign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "结果:";
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(53, 356);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(735, 110);
            this.txt_Result.TabIndex = 1;
            // 
            // MakeSHA1WithRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btn_Sign);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PrivateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_WaitSignStr);
            this.Controls.Add(this.label1);
            this.Name = "MakeSHA1WithRSA";
            this.Text = "MakeSHA1WithRSA";
            this.Load += new System.EventHandler(this.MakeSHA1WithRSA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_WaitSignStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PrivateKey;
        private System.Windows.Forms.Button btn_Sign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Result;
    }
}