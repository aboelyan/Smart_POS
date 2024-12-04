namespace Smart_POS.Forms
{
    partial class POSForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemQty = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnItem = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaied = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtItemQty);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Location = new System.Drawing.Point(1058, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 420);
            this.panel1.TabIndex = 0;
            // 
            // txtItemQty
            // 
            this.txtItemQty.Font = new System.Drawing.Font("Droid Sans Arabic", 22F, System.Drawing.FontStyle.Bold);
            this.txtItemQty.Location = new System.Drawing.Point(3, 12);
            this.txtItemQty.Name = "txtItemQty";
            this.txtItemQty.Size = new System.Drawing.Size(219, 49);
            this.txtItemQty.TabIndex = 2;
            this.txtItemQty.Text = "0";
            this.txtItemQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnC.Location = new System.Drawing.Point(155, 291);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(70, 70);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnDot.Location = new System.Drawing.Point(79, 291);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(70, 70);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(3, 291);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(155, 215);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(79, 215);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(3, 215);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(155, 139);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(79, 139);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(3, 139);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(155, 63);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(79, 63);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Droid Sans Arabic", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(3, 63);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Sans Arabic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColItem,
            this.ColQTY,
            this.ColPrice,
            this.ColItemPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Sans Arabic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.Location = new System.Drawing.Point(2, 2);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(301, 420);
            this.dgvItems.TabIndex = 1;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColItem
            // 
            this.ColItem.FillWeight = 130F;
            this.ColItem.HeaderText = "Item";
            this.ColItem.Name = "ColItem";
            this.ColItem.ReadOnly = true;
            this.ColItem.Width = 130;
            // 
            // ColQTY
            // 
            this.ColQTY.FillWeight = 50F;
            this.ColQTY.HeaderText = "QTY";
            this.ColQTY.Name = "ColQTY";
            this.ColQTY.ReadOnly = true;
            this.ColQTY.Width = 50;
            // 
            // ColPrice
            // 
            this.ColPrice.FillWeight = 70F;
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 70;
            // 
            // ColItemPrice
            // 
            this.ColItemPrice.HeaderText = "ColItemPrice";
            this.ColItemPrice.Name = "ColItemPrice";
            this.ColItemPrice.ReadOnly = true;
            this.ColItemPrice.Visible = false;
            // 
            // pnItem
            // 
            this.pnItem.BackColor = System.Drawing.Color.White;
            this.pnItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnItem.Location = new System.Drawing.Point(309, 2);
            this.pnItem.Name = "pnItem";
            this.pnItem.Size = new System.Drawing.Size(749, 420);
            this.pnItem.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Location = new System.Drawing.Point(2, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 145);
            this.panel3.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(87, 15);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(207, 37);
            this.txtTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(8, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Controls.Add(this.cmbPayment);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtChange);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtPaied);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(309, 428);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 145);
            this.panel4.TabIndex = 3;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Droid Sans Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button15.Location = new System.Drawing.Point(811, 70);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(161, 63);
            this.button15.TabIndex = 27;
            this.button15.Text = " Exit";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Droid Sans Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button16.Location = new System.Drawing.Point(811, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(161, 63);
            this.button16.TabIndex = 26;
            this.button16.Text = "Cancel";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Droid Sans Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button13.Location = new System.Drawing.Point(644, 70);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(161, 63);
            this.button13.TabIndex = 25;
            this.button13.Text = "Clear";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Droid Sans Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button14.Location = new System.Drawing.Point(644, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(161, 63);
            this.button14.TabIndex = 24;
            this.button14.Text = "Remove";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Droid Sans Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button12.Location = new System.Drawing.Point(477, 70);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(161, 63);
            this.button12.TabIndex = 23;
            this.button12.Text = "Print";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Droid Sans Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnPay.Location = new System.Drawing.Point(477, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(161, 63);
            this.btnPay.TabIndex = 22;
            this.btnPay.Text = "Pay";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Visa",
            "Bank"});
            this.cmbPayment.Location = new System.Drawing.Point(120, 4);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(286, 38);
            this.cmbPayment.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payment";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtChange.Location = new System.Drawing.Point(120, 91);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(286, 37);
            this.txtChange.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change";
            // 
            // txtPaied
            // 
            this.txtPaied.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPaied.Location = new System.Drawing.Point(120, 48);
            this.txtPaied.Name = "txtPaied";
            this.txtPaied.Size = new System.Drawing.Size(286, 37);
            this.txtPaied.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paied";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 583);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnItem);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSForm";
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel pnItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPaied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemPrice;
    }
}