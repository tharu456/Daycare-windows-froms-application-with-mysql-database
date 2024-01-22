namespace FinalProject
{
    partial class salaryDGV
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
            this.salary_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salary_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // salary_dgv
            // 
            this.salary_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salary_dgv.Location = new System.Drawing.Point(12, 12);
            this.salary_dgv.Name = "salary_dgv";
            this.salary_dgv.RowHeadersWidth = 51;
            this.salary_dgv.RowTemplate.Height = 24;
            this.salary_dgv.Size = new System.Drawing.Size(1152, 391);
            this.salary_dgv.TabIndex = 0;
            this.salary_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.button1.Location = new System.Drawing.Point(904, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salaryDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salary_dgv);
            this.MaximumSize = new System.Drawing.Size(1220, 789);
            this.Name = "salaryDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salaryDGV";
            ((System.ComponentModel.ISupportInitialize)(this.salary_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salary_dgv;
        private System.Windows.Forms.Button button1;
    }
}