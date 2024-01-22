
namespace FinalProject
{
    partial class parentDGV
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
            this.parent_dgv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.parentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parent_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // parent_dgv
            // 
            this.parent_dgv.AllowUserToDeleteRows = false;
            this.parent_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parent_dgv.Location = new System.Drawing.Point(13, 13);
            this.parent_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.parent_dgv.Name = "parent_dgv";
            this.parent_dgv.RowHeadersWidth = 51;
            this.parent_dgv.Size = new System.Drawing.Size(1152, 391);
            this.parent_dgv.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.btnAdd.Location = new System.Drawing.Point(17, 469);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Parent";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.btnDelete.Location = new System.Drawing.Point(856, 469);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 55);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Parent";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // parentId
            // 
            this.parentId.Location = new System.Drawing.Point(637, 502);
            this.parentId.Margin = new System.Windows.Forms.Padding(4);
            this.parentId.Name = "parentId";
            this.parentId.Size = new System.Drawing.Size(211, 22);
            this.parentId.TabIndex = 4;
            this.parentId.TextChanged += new System.EventHandler(this.parentId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(633, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter index";
            // 
            // parentDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parentId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.parent_dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1220, 789);
            this.Name = "parentDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parentsDGV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.parentDGV_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.parentDGV_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.parent_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parent_dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox parentId;
        private System.Windows.Forms.Label label1;
    }
}