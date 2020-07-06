using System;

namespace MiniProject
{
    partial class QueForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.soo = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.metroRadioButton1 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton2 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton3 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.metroPanel2 = new System.Windows.Forms.Panel();
            this.metroRadioButton7 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton10 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton9 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton6 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.metroPanel3 = new System.Windows.Forms.Panel();
            this.metroRadioButton12 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton15 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton14 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton11 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.metroPanel4 = new System.Windows.Forms.Panel();
            this.metroRadioButton8 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton16 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton13 = new System.Windows.Forms.RadioButton();
            this.metroRadioButton5 = new System.Windows.Forms.RadioButton();
            this.MetroButton1 = new System.Windows.Forms.Button();
            this.MetroButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soo)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // soo
            // 
            this.soo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soo.Location = new System.Drawing.Point(558, 11);
            this.soo.Name = "soo";
            this.soo.RowHeadersWidth = 51;
            this.soo.RowTemplate.Height = 27;
            this.soo.Size = new System.Drawing.Size(506, 150);
            this.soo.TabIndex = 7;
            this.soo.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 25);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "1.영화를 좋아하나요?";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroRadioButton4);
            this.metroPanel1.Controls.Add(this.metroRadioButton3);
            this.metroPanel1.Controls.Add(this.metroRadioButton2);
            this.metroPanel1.Controls.Add(this.metroRadioButton1);
            this.metroPanel1.Location = new System.Drawing.Point(59, 110);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(727, 86);
            this.metroPanel1.TabIndex = 2;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(39, 33);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(123, 19);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "매우 싫어한다";
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(212, 33);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(88, 19);
            this.metroRadioButton2.TabIndex = 1;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "싫어한다";
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(349, 33);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(88, 19);
            this.metroRadioButton3.TabIndex = 2;
            this.metroRadioButton3.TabStop = true;
            this.metroRadioButton3.Text = "좋아한다";
            this.metroRadioButton3.UseVisualStyleBackColor = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(469, 33);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(123, 19);
            this.metroRadioButton4.TabIndex = 3;
            this.metroRadioButton4.TabStop = true;
            this.metroRadioButton4.Text = "매우 좋아한다";
            this.metroRadioButton4.UseVisualStyleBackColor = true;
            this.metroRadioButton4.CheckedChanged += new System.EventHandler(this.metroRadioButton4_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(727, 25);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "2.당신은 어느 직업군에 속하나요?";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroRadioButton7);
            this.metroPanel2.Controls.Add(this.metroRadioButton10);
            this.metroPanel2.Controls.Add(this.metroRadioButton9);
            this.metroPanel2.Controls.Add(this.metroRadioButton6);
            this.metroPanel2.Location = new System.Drawing.Point(59, 231);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(727, 86);
            this.metroPanel2.TabIndex = 4;
            // 
            // metroRadioButton7
            // 
            this.metroRadioButton7.AutoSize = true;
            this.metroRadioButton7.Location = new System.Drawing.Point(469, 33);
            this.metroRadioButton7.Name = "metroRadioButton7";
            this.metroRadioButton7.Size = new System.Drawing.Size(73, 19);
            this.metroRadioButton7.TabIndex = 3;
            this.metroRadioButton7.TabStop = true;
            this.metroRadioButton7.Text = "직장인";
            this.metroRadioButton7.UseVisualStyleBackColor = true;
            this.metroRadioButton7.CheckedChanged += new System.EventHandler(this.metroRadioButton7_CheckedChanged);
            // 
            // metroRadioButton10
            // 
            this.metroRadioButton10.AutoSize = true;
            this.metroRadioButton10.Location = new System.Drawing.Point(349, 33);
            this.metroRadioButton10.Name = "metroRadioButton10";
            this.metroRadioButton10.Size = new System.Drawing.Size(58, 19);
            this.metroRadioButton10.TabIndex = 2;
            this.metroRadioButton10.TabStop = true;
            this.metroRadioButton10.Text = "주부";
            this.metroRadioButton10.UseVisualStyleBackColor = true;
            this.metroRadioButton10.CheckedChanged += new System.EventHandler(this.metroRadioButton10_CheckedChanged);
            // 
            // metroRadioButton9
            // 
            this.metroRadioButton9.AutoSize = true;
            this.metroRadioButton9.Location = new System.Drawing.Point(212, 33);
            this.metroRadioButton9.Name = "metroRadioButton9";
            this.metroRadioButton9.Size = new System.Drawing.Size(73, 19);
            this.metroRadioButton9.TabIndex = 1;
            this.metroRadioButton9.TabStop = true;
            this.metroRadioButton9.Text = "자영업";
            this.metroRadioButton9.UseVisualStyleBackColor = true;
            this.metroRadioButton9.CheckedChanged += new System.EventHandler(this.metroRadioButton9_CheckedChanged);
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.Location = new System.Drawing.Point(39, 33);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(58, 19);
            this.metroRadioButton6.TabIndex = 0;
            this.metroRadioButton6.TabStop = true;
            this.metroRadioButton6.Text = "학생";
            this.metroRadioButton6.UseVisualStyleBackColor = true;
            this.metroRadioButton6.CheckedChanged += new System.EventHandler(this.metroRadioButton6_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(727, 25);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "3.어느 정도의 연령이신가요?";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroRadioButton12);
            this.metroPanel3.Controls.Add(this.metroRadioButton15);
            this.metroPanel3.Controls.Add(this.metroRadioButton14);
            this.metroPanel3.Controls.Add(this.metroRadioButton11);
            this.metroPanel3.Location = new System.Drawing.Point(59, 352);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(727, 86);
            this.metroPanel3.TabIndex = 5;
            // 
            // metroRadioButton12
            // 
            this.metroRadioButton12.AutoSize = true;
            this.metroRadioButton12.Location = new System.Drawing.Point(528, 33);
            this.metroRadioButton12.Name = "metroRadioButton12";
            this.metroRadioButton12.Size = new System.Drawing.Size(101, 19);
            this.metroRadioButton12.TabIndex = 3;
            this.metroRadioButton12.TabStop = true;
            this.metroRadioButton12.Text = "장년(50대)";
            this.metroRadioButton12.UseVisualStyleBackColor = true;
            this.metroRadioButton12.CheckedChanged += new System.EventHandler(this.metroRadioButton12_CheckedChanged);
            // 
            // metroRadioButton15
            // 
            this.metroRadioButton15.AutoSize = true;
            this.metroRadioButton15.Location = new System.Drawing.Point(408, 33);
            this.metroRadioButton15.Name = "metroRadioButton15";
            this.metroRadioButton15.Size = new System.Drawing.Size(101, 19);
            this.metroRadioButton15.TabIndex = 2;
            this.metroRadioButton15.TabStop = true;
            this.metroRadioButton15.Text = "중년(40대)";
            this.metroRadioButton15.UseVisualStyleBackColor = true;
            this.metroRadioButton15.CheckedChanged += new System.EventHandler(this.metroRadioButton15_CheckedChanged);
            // 
            // metroRadioButton14
            // 
            this.metroRadioButton14.AutoSize = true;
            this.metroRadioButton14.Location = new System.Drawing.Point(212, 33);
            this.metroRadioButton14.Name = "metroRadioButton14";
            this.metroRadioButton14.Size = new System.Drawing.Size(193, 19);
            this.metroRadioButton14.TabIndex = 1;
            this.metroRadioButton14.TabStop = true;
            this.metroRadioButton14.Text = "청년(만 19세 ~ 만 39세)";
            this.metroRadioButton14.UseVisualStyleBackColor = true;
            this.metroRadioButton14.CheckedChanged += new System.EventHandler(this.metroRadioButton14_CheckedChanged);
            // 
            // metroRadioButton11
            // 
            this.metroRadioButton11.AutoSize = true;
            this.metroRadioButton11.Location = new System.Drawing.Point(39, 33);
            this.metroRadioButton11.Name = "metroRadioButton11";
            this.metroRadioButton11.Size = new System.Drawing.Size(171, 19);
            this.metroRadioButton11.TabIndex = 0;
            this.metroRadioButton11.TabStop = true;
            this.metroRadioButton11.Text = "청소년(만 18세 이하)";
            this.metroRadioButton11.UseVisualStyleBackColor = true;
            this.metroRadioButton11.CheckedChanged += new System.EventHandler(this.metroRadioButton11_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 444);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(727, 25);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "4.원하는 혜택을 선택하세요";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroRadioButton8);
            this.metroPanel4.Controls.Add(this.metroRadioButton16);
            this.metroPanel4.Controls.Add(this.metroRadioButton13);
            this.metroPanel4.Controls.Add(this.metroRadioButton5);
            this.metroPanel4.Location = new System.Drawing.Point(59, 475);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(727, 86);
            this.metroPanel4.TabIndex = 6;
            // 
            // metroRadioButton8
            // 
            this.metroRadioButton8.AutoSize = true;
            this.metroRadioButton8.Location = new System.Drawing.Point(559, 33);
            this.metroRadioButton8.Name = "metroRadioButton8";
            this.metroRadioButton8.Size = new System.Drawing.Size(134, 19);
            this.metroRadioButton8.TabIndex = 3;
            this.metroRadioButton8.TabStop = true;
            this.metroRadioButton8.Text = "멤버쉽 VIP 받기";
            this.metroRadioButton8.UseVisualStyleBackColor = true;
            this.metroRadioButton8.CheckedChanged += new System.EventHandler(this.metroRadioButton8_CheckedChanged);
            // 
            // metroRadioButton16
            // 
            this.metroRadioButton16.AutoSize = true;
            this.metroRadioButton16.Location = new System.Drawing.Point(372, 33);
            this.metroRadioButton16.Name = "metroRadioButton16";
            this.metroRadioButton16.Size = new System.Drawing.Size(181, 19);
            this.metroRadioButton16.TabIndex = 2;
            this.metroRadioButton16.TabStop = true;
            this.metroRadioButton16.Text = "스마트기기 1회선 무료";
            this.metroRadioButton16.UseVisualStyleBackColor = true;
            this.metroRadioButton16.CheckedChanged += new System.EventHandler(this.metroRadioButton16_CheckedChanged);
            // 
            // metroRadioButton13
            // 
            this.metroRadioButton13.AutoSize = true;
            this.metroRadioButton13.Location = new System.Drawing.Point(212, 33);
            this.metroRadioButton13.Name = "metroRadioButton13";
            this.metroRadioButton13.Size = new System.Drawing.Size(143, 19);
            this.metroRadioButton13.TabIndex = 1;
            this.metroRadioButton13.TabStop = true;
            this.metroRadioButton13.Text = "해외에서 톡 무료";
            this.metroRadioButton13.UseVisualStyleBackColor = true;
            this.metroRadioButton13.CheckedChanged += new System.EventHandler(this.metroRadioButton13_CheckedChanged);
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Location = new System.Drawing.Point(39, 33);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(123, 19);
            this.metroRadioButton5.TabIndex = 0;
            this.metroRadioButton5.TabStop = true;
            this.metroRadioButton5.Text = "미디어팩 무료";
            this.metroRadioButton5.UseVisualStyleBackColor = true;
            this.metroRadioButton5.CheckedChanged += new System.EventHandler(this.metroRadioButton5_CheckedChanged);
            // 
            // MetroButton1
            // 
            this.MetroButton1.Location = new System.Drawing.Point(284, 592);
            this.MetroButton1.Name = "MetroButton1";
            this.MetroButton1.Size = new System.Drawing.Size(75, 23);
            this.MetroButton1.TabIndex = 13;
            this.MetroButton1.Text = "다음";
            this.MetroButton1.UseVisualStyleBackColor = true;
            this.MetroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // MetroButton
            // 
            this.MetroButton.Location = new System.Drawing.Point(493, 592);
            this.MetroButton.Name = "MetroButton";
            this.MetroButton.Size = new System.Drawing.Size(75, 23);
            this.MetroButton.TabIndex = 14;
            this.MetroButton.Text = "건너뛰기";
            this.MetroButton.UseVisualStyleBackColor = true;
            this.MetroButton.Click += new System.EventHandler(this.MetroButton_Click);
            // 
            // QueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 700);
            this.Controls.Add(this.MetroButton);
            this.Controls.Add(this.MetroButton1);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.soo);
            this.Name = "QueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "설문지";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soo)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   



        #endregion
        private System.Windows.Forms.DataGridView soo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel metroPanel1;
        private System.Windows.Forms.RadioButton metroRadioButton2;
        private System.Windows.Forms.RadioButton metroRadioButton1;
        private System.Windows.Forms.RadioButton metroRadioButton4;
        private System.Windows.Forms.RadioButton metroRadioButton3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel metroPanel2;
        private System.Windows.Forms.RadioButton metroRadioButton7;
        private System.Windows.Forms.RadioButton metroRadioButton10;
        private System.Windows.Forms.RadioButton metroRadioButton9;
        private System.Windows.Forms.RadioButton metroRadioButton6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel metroPanel3;
        private System.Windows.Forms.RadioButton metroRadioButton12;
        private System.Windows.Forms.RadioButton metroRadioButton15;
        private System.Windows.Forms.RadioButton metroRadioButton14;
        private System.Windows.Forms.RadioButton metroRadioButton11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel metroPanel4;
        private System.Windows.Forms.RadioButton metroRadioButton8;
        private System.Windows.Forms.RadioButton metroRadioButton16;
        private System.Windows.Forms.RadioButton metroRadioButton13;
        private System.Windows.Forms.RadioButton metroRadioButton5;
        private System.Windows.Forms.Button MetroButton1;
        private System.Windows.Forms.Button MetroButton;
    }
}

