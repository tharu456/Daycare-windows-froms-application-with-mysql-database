namespace FinalProject
{
    partial class paymentDGV
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
            this.payment_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payment_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_dgv
            // 
            this.payment_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_dgv.Location = new System.Drawing.Point(12, 12);
            this.payment_dgv.Name = "payment_dgv";
            this.payment_dgv.RowHeadersWidth = 51;
            this.payment_dgv.RowTemplate.Height = 24;
            this.payment_dgv.Size = new System.Drawing.Size(1152, 391);
            this.payment_dgv.TabIndex = 0;
            this.payment_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(85, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter index";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(89, 501);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(211, 22);
            this.txtId.TabIndex = 8;
            // 
            // btnDelete1
            // 
            this.btnDelete1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.btnDelete1.Location = new System.Drawing.Point(327, 468);
            this.btnDelete1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(260, 55);
            this.btnDelete1.TabIndex = 7;
            this.btnDelete1.Text = "Delete baby";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.button2.Location = new System.Drawing.Point(896, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 67);
            this.button2.TabIndex = 56;
            this.button2.Text = "BACK TO HOME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paymentDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 742);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.payment_dgv);
            this.MaximumSize = new System.Drawing.Size(1220, 789);
            this.Name = "paymentDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentDGV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.paymentDGV_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.payment_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView payment_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button button2;
    }
}