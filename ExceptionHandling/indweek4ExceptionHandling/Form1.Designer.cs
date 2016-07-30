namespace indweek4ExceptionHandling
{
    partial class ExceptionHandling
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
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnRegExp = new System.Windows.Forms.Button();
            this.btnCustEx = new System.Windows.Forms.Button();
            this.lblRunNormal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(12, 124);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Run Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnRegExp
            // 
            this.btnRegExp.Location = new System.Drawing.Point(124, 62);
            this.btnRegExp.Name = "btnRegExp";
            this.btnRegExp.Size = new System.Drawing.Size(114, 23);
            this.btnRegExp.TabIndex = 1;
            this.btnRegExp.Text = "Regular Exception";
            this.btnRegExp.UseVisualStyleBackColor = true;
            this.btnRegExp.Click += new System.EventHandler(this.btnRegExp_Click);
            // 
            // btnCustEx
            // 
            this.btnCustEx.Location = new System.Drawing.Point(265, 124);
            this.btnCustEx.Name = "btnCustEx";
            this.btnCustEx.Size = new System.Drawing.Size(104, 23);
            this.btnCustEx.TabIndex = 2;
            this.btnCustEx.Text = "Custom Exception";
            this.btnCustEx.UseVisualStyleBackColor = true;
            this.btnCustEx.Click += new System.EventHandler(this.btnCustEx_Click);
            // 
            // lblRunNormal
            // 
            this.lblRunNormal.AutoSize = true;
            this.lblRunNormal.Location = new System.Drawing.Point(30, 170);
            this.lblRunNormal.Name = "lblRunNormal";
            this.lblRunNormal.Size = new System.Drawing.Size(0, 13);
            this.lblRunNormal.TabIndex = 3;
            // 
            // ExceptionHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 228);
            this.Controls.Add(this.lblRunNormal);
            this.Controls.Add(this.btnCustEx);
            this.Controls.Add(this.btnRegExp);
            this.Controls.Add(this.btnNormal);
            this.Name = "ExceptionHandling";
            this.Text = "Exception Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnRegExp;
        private System.Windows.Forms.Button btnCustEx;
        private System.Windows.Forms.Label lblRunNormal;
    }
}

