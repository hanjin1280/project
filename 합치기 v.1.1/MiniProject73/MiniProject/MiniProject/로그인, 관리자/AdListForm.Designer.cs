namespace MiniProject
{
    partial class AdListForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdProductTbl = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtBf = new System.Windows.Forms.TextBox();
            this.txtStd3 = new System.Windows.Forms.TextBox();
            this.txtStd2 = new System.Windows.Forms.TextBox();
            this.txtStd1 = new System.Windows.Forms.TextBox();
            this.txtBenefits = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPlans = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProductTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(21, 75);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdProductTbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnNew);
            this.splitContainer1.Panel2.Controls.Add(this.txtBf);
            this.splitContainer1.Panel2.Controls.Add(this.txtStd3);
            this.splitContainer1.Panel2.Controls.Add(this.txtStd2);
            this.splitContainer1.Panel2.Controls.Add(this.txtStd1);
            this.splitContainer1.Panel2.Controls.Add(this.txtBenefits);
            this.splitContainer1.Panel2.Controls.Add(this.txtData);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrice);
            this.splitContainer1.Panel2.Controls.Add(this.txtCompany);
            this.splitContainer1.Panel2.Controls.Add(this.txtPlans);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(859, 436);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdProductTbl
            // 
            this.GrdProductTbl.AllowUserToAddRows = false;
            this.GrdProductTbl.AllowUserToDeleteRows = false;
            this.GrdProductTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProductTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdProductTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdProductTbl.Name = "GrdProductTbl";
            this.GrdProductTbl.ReadOnly = true;
            this.GrdProductTbl.RowHeadersWidth = 51;
            this.GrdProductTbl.RowTemplate.Height = 27;
            this.GrdProductTbl.Size = new System.Drawing.Size(430, 436);
            this.GrdProductTbl.TabIndex = 1;
            this.GrdProductTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProductTbl_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 63);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(225, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 63);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 63);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 331);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 63);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtBf
            // 
            this.txtBf.Location = new System.Drawing.Point(145, 279);
            this.txtBf.MaxLength = 50;
            this.txtBf.Name = "txtBf";
            this.txtBf.Size = new System.Drawing.Size(266, 25);
            this.txtBf.TabIndex = 8;
            // 
            // txtStd3
            // 
            this.txtStd3.Location = new System.Drawing.Point(321, 236);
            this.txtStd3.MaxLength = 50;
            this.txtStd3.Name = "txtStd3";
            this.txtStd3.Size = new System.Drawing.Size(82, 25);
            this.txtStd3.TabIndex = 7;
            // 
            // txtStd2
            // 
            this.txtStd2.Location = new System.Drawing.Point(233, 236);
            this.txtStd2.MaxLength = 50;
            this.txtStd2.Name = "txtStd2";
            this.txtStd2.Size = new System.Drawing.Size(82, 25);
            this.txtStd2.TabIndex = 6;
            // 
            // txtStd1
            // 
            this.txtStd1.Location = new System.Drawing.Point(145, 236);
            this.txtStd1.MaxLength = 50;
            this.txtStd1.Name = "txtStd1";
            this.txtStd1.Size = new System.Drawing.Size(82, 25);
            this.txtStd1.TabIndex = 5;
            // 
            // txtBenefits
            // 
            this.txtBenefits.Location = new System.Drawing.Point(145, 196);
            this.txtBenefits.MaxLength = 50;
            this.txtBenefits.Name = "txtBenefits";
            this.txtBenefits.Size = new System.Drawing.Size(266, 25);
            this.txtBenefits.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(145, 154);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(266, 25);
            this.txtData.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(145, 113);
            this.txtPrice.MaxLength = 20;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(266, 25);
            this.txtPrice.TabIndex = 2;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(145, 72);
            this.txtCompany.MaxLength = 20;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(266, 25);
            this.txtCompany.TabIndex = 1;
            // 
            // txtPlans
            // 
            this.txtPlans.Location = new System.Drawing.Point(145, 33);
            this.txtPlans.MaxLength = 50;
            this.txtPlans.Name = "txtPlans";
            this.txtPlans.ReadOnly = true;
            this.txtPlans.Size = new System.Drawing.Size(266, 25);
            this.txtPlans.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "혜택 상세내용";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Standard";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "혜택";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "데이터";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "가격";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "통신사";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "요금제";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(901, 531);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdListForm";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Text = "목록관리";
            this.Load += new System.EventHandler(this.AdListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProductTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GrdProductTbl;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPlans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtBf;
        private System.Windows.Forms.TextBox txtStd3;
        private System.Windows.Forms.TextBox txtStd2;
        private System.Windows.Forms.TextBox txtStd1;
        private System.Windows.Forms.TextBox txtBenefits;
        private System.Windows.Forms.Button btnCancel;
    }
}