namespace MiniProject
{
    partial class LoginForm
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rdbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rdbtnMember = new System.Windows.Forms.RadioButton();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(163, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(282, 96);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 25);
            this.txtID.TabIndex = 9;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(282, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(234, 25);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // rdbtnAdmin
            // 
            this.rdbtnAdmin.AutoSize = true;
            this.rdbtnAdmin.Location = new System.Drawing.Point(374, 205);
            this.rdbtnAdmin.Name = "rdbtnAdmin";
            this.rdbtnAdmin.Size = new System.Drawing.Size(73, 19);
            this.rdbtnAdmin.TabIndex = 11;
            this.rdbtnAdmin.TabStop = true;
            this.rdbtnAdmin.Text = "관리자";
            this.rdbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbtnMember
            // 
            this.rdbtnMember.AutoSize = true;
            this.rdbtnMember.Location = new System.Drawing.Point(453, 205);
            this.rdbtnMember.Name = "rdbtnMember";
            this.rdbtnMember.Size = new System.Drawing.Size(73, 19);
            this.rdbtnMember.TabIndex = 12;
            this.rdbtnMember.TabStop = true;
            this.rdbtnMember.Text = "사용자";
            this.rdbtnMember.UseVisualStyleBackColor = true;
            this.rdbtnMember.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbtnMember_MouseClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(170, 254);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 53);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(292, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 53);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 53);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.rdbtnMember);
            this.Controls.Add(this.rdbtnAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdbtnAdmin;
        private System.Windows.Forms.RadioButton rdbtnMember;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}