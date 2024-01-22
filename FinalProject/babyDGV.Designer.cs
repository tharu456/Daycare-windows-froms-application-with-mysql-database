namespace FinalProject
{
    partial class babyDGV
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
            this.baby_dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.txtId1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baby_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // baby_dgv
            // 
            this.baby_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baby_dgv.Location = new System.Drawing.Point(12, 12);
            this.baby_dgv.Name = "baby_dgv";
            this.baby_dgv.RowHeadersWidth = 51;
            this.baby_dgv.RowTemplate.Height = 24;
            this.baby_dgv.Size = new System.Drawing.Size(1152, 391);
            this.baby_dgv.TabIndex = 0;
            this.baby_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.baby_dgv_CellContentClick);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.btnAdd1.Location = new System.Drawing.Point(22, 465);
            this.btnAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(260, 55);
            this.btnAdd1.TabIndex = 2;
            this.btnAdd1.Text = "Add New baby";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.btnDelete1.Location = new System.Drawing.Point(910, 465);
            this.btnDelete1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(260, 55);
            this.btnDelete1.TabIndex = 4;
            this.btnDelete1.Text = "Delete baby";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // txtId1
            // 
            this.txtId1.Location = new System.Drawing.Point(672, 498);
            this.txtId1.Margin = new System.Windows.Forms.Padding(4);
            this.txtId1.Name = "txtId1";
            this.txtId1.Size = new System.Drawing.Size(211, 22);
            this.txtId1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(668, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter index";
            // 
            // babyDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId1);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.baby_dgv);
            this.MaximumSize = new System.Drawing.Size(1220, 789);
            this.Name = "babyDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "babyDGV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.babyDGV_FormClosed);
            this.Load += new System.EventHandler(this.babyDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baby_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView baby_dgv;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.TextBox txtId1;
        private System.Windows.Forms.Label label1;
    }
}