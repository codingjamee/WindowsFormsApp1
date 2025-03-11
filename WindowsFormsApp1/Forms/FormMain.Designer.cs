namespace WindowsFormsApp1.Forms
{
    partial class FormMain
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
            this.Employees = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Employees.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Employees.BackColor = System.Drawing.Color.RosyBrown;
            this.Employees.Controls.Add(this.BtnClose);
            this.Employees.Controls.Add(this.label1);
            this.Employees.ForeColor = System.Drawing.Color.Crimson;
            this.Employees.Location = new System.Drawing.Point(0, 0);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(1095, 183);
            this.Employees.TabIndex = 0;
            this.Employees.Paint += new System.Windows.Forms.PaintEventHandler(this.Employees_Paint);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.AutoSize = true;
            this.BtnClose.Font = new System.Drawing.Font("Tempus Sans ITC", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.MintCream;
            this.BtnClose.Location = new System.Drawing.Point(1021, 48);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(46, 49);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            this.label1.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1095, 860);
            this.Controls.Add(this.Employees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Employees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BtnClose;
    }
}