namespace FinalProject
{
    partial class babysittersDGV
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
            this.babysitters_dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.babysitters_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // babysitters_dgv
            // 
            this.babysitters_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.babysitters_dgv.Location = new System.Drawing.Point(19, 12);
            this.babysitters_dgv.Name = "babysitters_dgv";
            this.babysitters_dgv.RowHeadersWidth = 51;
            this.babysitters_dgv.RowTemplate.Height = 24;
            this.babysitters_dgv.Size = new System.Drawing.Size(1152, 391);
            this.babysitters_dgv.TabIndex = 0;
            this.babysitters_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.btnAdd2.Location = new System.Drawing.Point(19, 458);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(260, 55);
            this.btnAdd2.TabIndex = 1;
            this.btnAdd2.Text = "Add New Babysitter";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.btnDelete2.Location = new System.Drawing.Point(911, 458);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(260, 55);
            this.btnDelete2.TabIndex = 2;
            this.btnDelete2.Text = "Delete Babysitter";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(682, 491);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(682, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter index";
            // 
            // babysittersDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.babysitters_dgv);
            this.MaximumSize = new System.Drawing.Size(1220, 789);
            this.Name = "babysittersDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "babysittersDGV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.babysittersDGV_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.babysitters_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView babysitters_dgv;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}