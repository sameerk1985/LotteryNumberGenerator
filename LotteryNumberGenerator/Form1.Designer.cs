namespace LotteryNumberGenerator
{
    partial class Form1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lvLotteryNumbers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(167, 42);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(132, 64);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 7;
            // 
            // lvLotteryNumbers
            // 
            this.lvLotteryNumbers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lvLotteryNumbers.ForeColor = System.Drawing.SystemColors.Window;
            this.lvLotteryNumbers.HideSelection = false;
            this.lvLotteryNumbers.Location = new System.Drawing.Point(12, 117);
            this.lvLotteryNumbers.Name = "lvLotteryNumbers";
            this.lvLotteryNumbers.Size = new System.Drawing.Size(433, 40);
            this.lvLotteryNumbers.TabIndex = 8;
            this.lvLotteryNumbers.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(463, 180);
            this.Controls.Add(this.lvLotteryNumbers);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Lottery Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ListView lvLotteryNumbers;
    }
}

