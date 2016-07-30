namespace FactoryReflection
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
            this.foxBtn = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.dogBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foxBtn
            // 
            this.foxBtn.Location = new System.Drawing.Point(315, 90);
            this.foxBtn.Name = "foxBtn";
            this.foxBtn.Size = new System.Drawing.Size(95, 46);
            this.foxBtn.TabIndex = 0;
            this.foxBtn.Text = "Fox";
            this.foxBtn.UseVisualStyleBackColor = true;
            this.foxBtn.Click += new System.EventHandler(this.foxBtn_Click);
            // 
            // catBtn
            // 
            this.catBtn.Location = new System.Drawing.Point(184, 90);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(95, 46);
            this.catBtn.TabIndex = 1;
            this.catBtn.Text = "Cat";
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // dogBtn
            // 
            this.dogBtn.Location = new System.Drawing.Point(51, 90);
            this.dogBtn.Name = "dogBtn";
            this.dogBtn.Size = new System.Drawing.Size(95, 46);
            this.dogBtn.TabIndex = 2;
            this.dogBtn.Text = "Dog";
            this.dogBtn.UseVisualStyleBackColor = true;
            this.dogBtn.Click += new System.EventHandler(this.dogBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(213, 233);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 13);
            this.outputLbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 305);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.dogBtn);
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.foxBtn);
            this.Name = "Form1";
            this.Text = "FactoryReflection Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button foxBtn;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button dogBtn;
        private System.Windows.Forms.Label outputLbl;
    }
}

