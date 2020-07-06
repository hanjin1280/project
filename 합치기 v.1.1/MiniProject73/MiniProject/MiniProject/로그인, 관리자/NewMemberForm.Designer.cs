namespace MiniProject
{
    partial class NewMemberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnID = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.cboUSCallPlan = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(116, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(116, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(116, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "나이";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(116, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "성별";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(116, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "전화번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(41, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "현재 사용 요금제";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 25);
            this.txtName.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(216, 175);
            this.txtID.MaxLength = 50;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 25);
            this.txtID.TabIndex = 20;
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(422, 175);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(101, 25);
            this.btnID.TabIndex = 21;
            this.btnID.Text = "중복확인";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 241);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 25);
            this.txtPassword.TabIndex = 22;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(216, 306);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(185, 25);
            this.txtAge.TabIndex = 23;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(239, 366);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(58, 19);
            this.rdbtnMale.TabIndex = 24;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "남자";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(320, 366);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(58, 19);
            this.rdbtnFemale.TabIndex = 25;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "여자";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(216, 433);
            this.txtMobile.MaxLength = 13;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(185, 25);
            this.txtMobile.TabIndex = 26;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // cboUSCallPlan
            // 
            this.cboUSCallPlan.FormattingEnabled = true;
            this.cboUSCallPlan.ItemHeight = 15;
            this.cboUSCallPlan.Location = new System.Drawing.Point(216, 500);
            this.cboUSCallPlan.Name = "cboUSCallPlan";
            this.cboUSCallPlan.Size = new System.Drawing.Size(185, 23);
            this.cboUSCallPlan.TabIndex = 27;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(138, 602);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 52);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 602);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 52);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 719);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboUSCallPlan);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewMemberForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.NewMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox cboUSCallPlan;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}