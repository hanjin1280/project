﻿namespace MiniProject
{
    partial class RmdForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RmdForm));
            this.FlpRmd = new System.Windows.Forms.FlowLayoutPanel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.FlpRmdName = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlpRmd
            // 
            this.FlpRmd.Location = new System.Drawing.Point(31, 87);
            this.FlpRmd.Name = "FlpRmd";
            this.FlpRmd.Size = new System.Drawing.Size(837, 196);
            this.FlpRmd.TabIndex = 0;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "1.png");
            this.imgList.Images.SetKeyName(1, "2.png");
            this.imgList.Images.SetKeyName(2, "3.png");
            this.imgList.Images.SetKeyName(3, "4.png");
            this.imgList.Images.SetKeyName(4, "5.png");
            this.imgList.Images.SetKeyName(5, "6.png");
            this.imgList.Images.SetKeyName(6, "7.png");
            // 
            // FlpRmdName
            // 
            this.FlpRmdName.Location = new System.Drawing.Point(31, 275);
            this.FlpRmdName.Name = "FlpRmdName";
            this.FlpRmdName.Size = new System.Drawing.Size(837, 47);
            this.FlpRmdName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 331);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FlpRmdName);
            this.Controls.Add(this.FlpRmd);
            this.Name = "RmdForm";
            this.Text = "추천목록";
            this.Load += new System.EventHandler(this.RmdForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpRmd;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.FlowLayoutPanel FlpRmdName;
        private System.Windows.Forms.Button button1;
    }
}

