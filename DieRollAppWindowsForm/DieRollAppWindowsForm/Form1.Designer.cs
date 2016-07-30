namespace DieRollAppWindowsForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lvDieDouble = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(47, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(47, 147);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(129, 110);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll the Die";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lvDieDouble
            // 
            this.lvDieDouble.Location = new System.Drawing.Point(240, 12);
            this.lvDieDouble.Name = "lvDieDouble";
            this.lvDieDouble.Size = new System.Drawing.Size(153, 409);
            this.lvDieDouble.TabIndex = 3;
            this.lvDieDouble.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(405, 455);
            this.Controls.Add(this.lvDieDouble);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListView lvDieDouble;
    }
}

