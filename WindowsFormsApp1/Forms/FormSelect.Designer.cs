namespace Smart_POS.Forms
{
    partial class FormSelect
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDes});
            this.dgvItems.Location = new System.Drawing.Point(12, 65);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(384, 437);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            // 
            // ColDes
            // 
            this.ColDes.HeaderText = "DES";
            this.ColDes.Name = "ColDes";
            this.ColDes.ReadOnly = true;
            this.ColDes.Width = 230;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Droid Sans Arabic", 12F);
            this.txtDes.Location = new System.Drawing.Point(72, 15);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(251, 30);
            this.txtDes.TabIndex = 22;
            this.txtDes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyUp);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Droid Sans Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.lblDes.Location = new System.Drawing.Point(12, 23);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(44, 22);
            this.lblDes.TabIndex = 21;
            this.lblDes.Text = "Des";
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 512);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.dgvItems);
            this.Name = "FormSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Select";
            this.Load += new System.EventHandler(this.FormSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDes;
    }
}